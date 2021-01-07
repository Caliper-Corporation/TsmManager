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
            }
        }

        private void runSimulationButton_Click(object sender, EventArgs e)
        {
            manager.Start();
            MessageBox.Show("Simulation started!");
        }

        private void changeSettingsButton_Click(object sender, EventArgs e)
        {
            manager.ChangeSettings();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            manager.Stop();
            MessageBox.Show("Simulation stopped!");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            manager.Close();
            Close();
        }
    }
}
