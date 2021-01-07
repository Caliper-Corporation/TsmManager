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
        //private string product = "TransModeler"; //for full version        
        private string product = "TransModeler SE"; //for SE
        //private const string productPath = "C:\\Program Files\\TransModeler 6.0\\tsm.exe";  //for full version
        private const string productPath = "C:\\Program Files\\TransModeler SE 6.0\\TsmSE.exe"; //for SE
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

                Thread.Sleep(2000);

                connection = new CaliperForm.Connection { MappingServer = product };
                bool opened = connection.Open(logFile);
                if (opened)
                {
                    // You must declare dk as "dynamic" or the compiler will throw an error
                    dk = connection.Gisdk;

                    // Obtain information about connection: an array of [ "program_path" , "program name" , "program type" , build number (integer) , version number (real) , instance number ]
                    var programInfo = dk.GetProgram();
                    var programName = programInfo[1] as string;
                    var buildNumber = (int) programInfo[3];
                    var versionNumber = (double) programInfo[4];

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
            if(runManager == null)
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
            if (runManager == null)
            {
                dk.ShowMessage("Run Manager has no value assigned to it. Simulation can not be stopped.");
                return;
            }

            runManager.StopSimulation();
        }
        
        public void Close()
        {
            connection?.Close(); //Closes the connection. If transmodeler was running before, it will keep it running.
            connection?.Terminate(); //kills the product exe process if it was opened during connection setup as a background process
            tsmProcess?.CloseMainWindow();
        }
    }
}
