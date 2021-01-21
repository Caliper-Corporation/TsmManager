using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private CaliperForm.Connection connection;
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

                connection = new CaliperForm.Connection { MappingServer = product };
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
                connection?.Close(); // Closes the connection. If transmodeler was running before, it will keep it running.
                connection?.Terminate(); // kills the product exe process
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

        public bool ChangeSettings()
        {
            //change project settings, output settings, getsignals, setsignals etc.
            return false;
        }

        public void Stop()
        {
            runManager?.StopSimulation();
            runManager?.TsmApi?.Reset();
        }

        public string Pause(string pause)
        {
            //if pause = "True" simulation is paused, else ("Flase") simulation is resumed.
            return runManager?.PauseSimulation(pause);
        }

        public string EnterStepMode()
        {
            return runManager?.SetStepMode("True");
        }

        public void StepForward(int stepSize = 1)
        {
            //stepSize is the size in seconds of step for Step Mode simulation, default value is 1 second
            runManager?.Step(stepSize);
        }

        public void SpeedUp()
        {
            runManager?.SpeedUpSimulation();
        }

        public void SlowDown()
        {
            runManager?.SlowDownSimulation();
        }

        public void RunTo(string time)
        {
            runManager?.TsmApi?.RunTo(time);
        }

        public void SetTimeFactor(double factor = 1.0)
        {
            dk?.SetSimulationDesireSpeed(factor);
        }

        public void Close()
        {
            connection?.Close(); //Closes the connection. If transmodeler was running before, it will keep it running.
            connection?.Terminate(); //kills the product exe process if it was opened during connection setup as a background process
            tsmProcess?.CloseMainWindow();
        }
    }
}
