using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TsmManager
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Manager manager;
        private bool isPaused;
        public Form()
        {
            InitializeComponent();
            manager = new Manager();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (!manager.Open())
            {
                MessageBox.Show("An error occurred while opening TransModeler or the specified project. Please see the log file for more details.");
                manager.Close();
                return;
            }
            runSimulationButton.Enabled = true;
            openButton.Enabled = false;
        }

        private void runSimulationButton_Click(object sender, EventArgs e)
        {
            manager.Start();
            pauseButton.Enabled = true;
            stopButton.Enabled = true;
            stepModeButton.Enabled = true;
            stepForwardButton.Enabled = true;
            speedUpButton.Enabled = true;
            slowDownButton.Enabled = true;
            runSimulationButton.Enabled = false;
            label1.Enabled = true;
            stepSizeTextBox.Enabled = true;
            realTimeFactorButton.Enabled = true;
            MessageBox.Show("Simulation started!");
        }

        private void realTimeFactorButton_Click(object sender, EventArgs e)
        {
            manager.SetTimeFactor(1.0);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            manager.Stop();
            MessageBox.Show("Simulation stopped!");
            pauseButton.Enabled = false;
            stopButton.Enabled = false;
            stepModeButton.Enabled = false;
            stepForwardButton.Enabled = false;
            speedUpButton.Enabled = false;
            slowDownButton.Enabled = false;
            runSimulationButton.Enabled = true;
            label1.Enabled = false;
            stepSizeTextBox.Enabled = false;
            pauseButton.Text = "Pause";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            manager.Stop();
            manager.Close();
            Close();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            string status;
            if (!isPaused)
            {
                isPaused = true;
                pauseButton.Text = "Resume";
                status = manager.Pause("True");
                if (status.ToLower() == "true") MessageBox.Show("Simulation paused!");
            }
            else
            {
                isPaused = false;
                pauseButton.Text = "Pause";
                status = manager.Pause("False");
                if (status.ToLower() == "true") MessageBox.Show("Simulation resumed!");
            }
        }

        private void stepModeButton_Click(object sender, EventArgs e)
        {
            var status = manager.EnterStepMode();
            pauseButton.Enabled = false;
            speedUpButton.Enabled = false;
            slowDownButton.Enabled = false;
            realTimeFactorButton.Enabled = false;
            MessageBox.Show($"The staus of enter step mode is {status}");
        }

        private void stepForwardButton_Click(object sender, EventArgs e)
        {
            var stepSize = int.Parse(stepSizeTextBox.Text);
            //stepSize is the size in seconds of step for Step Mode simulation, default value is 1 second
            manager.StepForward(stepSize);
        }

        private void speedUpButton_Click(object sender, EventArgs e)
        {
            manager.SpeedUp();
        }

        private void slowDownButton_Click(object sender, EventArgs e)
        {
            manager.SlowDown();
        }

        private void setSignalStateButton_Click(object sender, EventArgs e)
        {
            var sigId = int.Parse(signalIDTextBox.Text);
            var turn = movementComboBox.SelectedIndex == 3 ? 2 : movementComboBox.SelectedIndex;
            var color = colorComboBox.SelectedIndex == 0 ? "Green": colorComboBox.SelectedIndex == 1 ? "Yellow": "Red";
            manager.SetSignalState(sigId, turn, color);
        }

        private void getDetectorStatusButton_Click(object sender, EventArgs e)
        {
            var dt = DateTime.Now;
            manager.OutputDetectorInformation(manager.GetTimeStamp(dt));
            MessageBox.Show($"Detector information writing initiated at {dt}");
        }

        private void getVehicleStatusButton_Click(object sender, EventArgs e)
        {
            manager.GetVehicleInformation();
        }

        private void detectorIsActiveButton_Click(object sender, EventArgs e)
        {
            var sensorId = int.Parse(detectorIDTextBox.Text);
            if(sensorId > 0)
            {
                var isActive = manager.IsSensorActive(sensorId);
                var status = isActive ? "activated" : "not activated";
                MessageBox.Show($"Detector id {sensorId} is currently {status}."); ;
            }
        }

        private void detectorActivateButton_Click(object sender, EventArgs e)
        {
            var sensorId = int.Parse(detectorIDTextBox.Text);
            if (sensorId > 0)
            {
                var activated = manager.ActivateSensor(sensorId);
                var status = activated ? "has been successfully activated" : "could not be activated";
                MessageBox.Show($"Detector id {sensorId} {status}."); ;
            }
        }
    }
}
