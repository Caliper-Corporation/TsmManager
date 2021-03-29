using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaliperForm;
using Tsm;
using System.Text;

namespace TsmManager
{
    public class Manager
    {
        public static string logFile = "C:\\Temp\\transmodeler.txt";
        private string product = "TransModeler"; //for full version        
        //private string product = "TransModeler SE"; //for SE
        //private const string productPath = "C:\\Program Files\\TransModeler 6.0\\tsm.exe";  //for full version        
        private const string productPath = "C:\\Platform\\TsmDev\\tsm.exe";  //for dev version
        //private const string productPath = "C:\\Program Files\\TransModeler SE 6.0\\TsmSE.exe"; //for SE
        private const string project = "C:\\Temp\\SignalCoordination\\SignalCoordination.smp"; //project path for project of your choice, avoid spaces in filepath

        //For interaction with CaliperForm.dll
        private Connection connection;
        private dynamic dk;

        //For interaction with TransModeler GISDK API
        private dynamic runManager;

        private Process tsmProcess;
        public bool Open()
        {
            try
            {
                tsmProcess = new Process();
                tsmProcess.StartInfo.FileName = productPath;
                tsmProcess.StartInfo.Arguments = project;
                tsmProcess.Start();

                Thread.Sleep(2000); //If the tsmProcess has not started yet, the connection code below will start a new process, 
                //this 2 s delay ensures that the connection does not create a new process and attaches to the tsmProcess from above

                connection = new Connection { MappingServer = product };
                bool opened = connection.Open(logFile);
                if (opened)
                {
                    // You must declare dk as "dynamic" or the compiler will throw an error
                    dk = connection.Gisdk;

                    // Obtain information about connection: an array of [ "program_path" , "program name" , "program type" , build number (integer) , version number (real) , instance number ]
                    var programInfo = dk.GetProgram();
                    var programName = programInfo[1] as string;
                    var buildNumber = (int)programInfo[3];
                    var versionNumber = (double)programInfo[4];

                    dk.ShowMessage("Successfully conntected to " +
                        "Program name: " + programName + " Version number: " + versionNumber + " Build number: " + buildNumber);

                    runManager = dk.CreateObject("TSM.RunManager");
                    //runManager.OpenSimulationProject(project); //opens the product exe and project in engine mode with no UI
                }
            }
            catch (Exception e)
            {
                var errorDetails = e.Message + "\nDetails:\n" + e.StackTrace;
                if (dk != null) dk.ShowMessage(errorDetails);
                else File.AppendAllText(logFile, errorDetails);
                connection.Close(); // Closes the connection. If transmodeler was running before, it will keep it running.
                connection.Terminate(); // kills the product exe process
                return false;
            }
            return true;
        }

        public void Start()
        {
            if (runManager == null)
            {
                dk.ShowMessage("Run Manager has no value assigned to it. Simulation can not be run.");
                return;
            }
            runManager.SuppressAllWarnings();
            runManager.SetSimulationRunMode("Simulation");
            Task.Run(() => runManager.RunSimulation());
        }

        public void Stop()
        {
            runManager.StopSimulation();
        }

        public string Pause(string pause)
        {
            //if pause = "True" simulation is paused, else ("Flase") simulation is resumed.
            return runManager.PauseSimulation(pause);
        }

        public string EnterStepMode()
        {
            return runManager.SetStepMode("True");
        }

        public void SetSignalState(int sigId, int turn, string color)
        {
            var signal = runManager.TsmApi.Network.Signal[sigId];
            TsmSignalState state;
            if (color == "Green") state = TsmSignalState.GREEN_SIGNAL;
            else if (color == "Yellow") state = TsmSignalState.YELLOW_SIGNAL;
            else if (color == "Red") state = TsmSignalState.RED_SIGNAL;
            else state = TsmSignalState.BLANK_SIGNAL;
            signal.TurnSignalState[(short)turn] = state;
        }

        internal void OutputVehicleInformation(string timeStamp)
        {
            Task.Run(() =>
            {
                try
                {
                    var sb = new StringBuilder();
                    var vehicles = runManager.TsmApi.Network.Vehicles;
                    sb.AppendLine("Vehicle Id,Vehicle Class,Segment Id,Speed,Headway");
                    foreach (var v in vehicles)
                    {
                        var speed = v.Speed > 0 ? v.Speed.ToString() : string.Empty;
                        
                        var line = $"{v.id},{v.Class},{v.Segment?.id},{speed},{v.Headway}";
                        sb.AppendLine(line);
                    }
                    var filePath = $"Vehicles-{timeStamp}.csv";
                    File.WriteAllText(filePath, sb.ToString());
                    MessageBox.Show("Vehicle information written successfully!");
                }
                catch (Exception e)
                {
                    MessageBox.Show($"An error occurred while writing vehicle information.\nDetails:{e.Message}");
                }
            });
        }

        public bool ActivateSensor(int sensorId)
        {
            if (runManager.TsmApi.Network.Sensor[sensorId] != null)
            {
                runManager.TsmApi.Network.Sensor[sensorId].IsActivated = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSensorActive(int sensorId)
        {
            if (runManager.TsmApi.Network.Sensor[sensorId] != null)
            {
                return runManager.TsmApi.Network.Sensor[sensorId].IsActivated;
            }
            else
            {
                return false;
            }
        }

        internal string GetTimeStamp(DateTime dt)
        {
            var timeStamp = $"{dt.Year.ToString("D4")}{dt.Month.ToString("D2")}{dt.Day.ToString("D2")}-{dt.Hour.ToString("D2")}{dt.Minute.ToString("D2")}{dt.Second.ToString("D2")}";
            return timeStamp;
        }

        public void OutputDetectorInformation(string timeStamp)
        {
            Task.Run(() =>
            {
                try
                {
                    var sb = new StringBuilder();
                    var sensors = runManager.TsmApi.Network.Sensors;
                    sb.AppendLine("Sensor Id,IsActivated,LastActuationTime,Speed,IsOccupied,Occupancy");
                    foreach (var s in sensors)
                    {
                        dynamic lastActuationTime = s.LastActuationTime.ToString();
                        if (lastActuationTime.Contains("-")) lastActuationTime = string.Empty;
                        var line = $"{s.id},{s.IsActivated},{lastActuationTime},{s.Speed},{s.IsOccupied},{s.Occupancy}";
                        sb.AppendLine(line);
                    }
                    var filePath = $"Detectors-{timeStamp}.csv";
                    File.WriteAllText(filePath, sb.ToString());
                    MessageBox.Show("Detector information written successfully!");
                }
                catch (Exception e)
                {
                    MessageBox.Show($"An error occurred while writing sensor information.\nDetails:{e.Message}");
                }
            });
        }

        public void StepForward(int stepSize = 1)
        {
            //stepSize is the size in seconds of step for Step Mode simulation, default value is 1 second
            runManager.Step(stepSize);
        }

        public void SpeedUp()
        {
            runManager.SpeedUpSimulation();
        }

        public void SlowDown()
        {
            runManager.SlowDownSimulation();
        }

        public void RunTo(string time)
        {
            runManager.TsmApi.RunTo(time);
        }

        public void SetTimeFactor(double factor = 1.0)
        {
            dk.SetSimulationDesireSpeed(factor);
        }

        public void Close()
        {
            connection.Close(); //Closes the connection. If transmodeler was running before, it will keep it running.
            connection.Terminate(); //kills the product exe process if it was opened during connection setup as a background process
            tsmProcess.CloseMainWindow();
        }
    }
}
