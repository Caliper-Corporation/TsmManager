
namespace TsmManager
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openButton = new System.Windows.Forms.Button();
            this.runSimulationButton = new System.Windows.Forms.Button();
            this.changeSettingsButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(25, 23);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(250, 30);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open TransModeler Project";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // runSimulationButton
            // 
            this.runSimulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runSimulationButton.Location = new System.Drawing.Point(25, 67);
            this.runSimulationButton.Name = "runSimulationButton";
            this.runSimulationButton.Size = new System.Drawing.Size(250, 30);
            this.runSimulationButton.TabIndex = 1;
            this.runSimulationButton.Text = "Run Simulation";
            this.runSimulationButton.UseVisualStyleBackColor = true;
            this.runSimulationButton.Click += new System.EventHandler(this.runSimulationButton_Click);
            // 
            // changeSettingsButton
            // 
            this.changeSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSettingsButton.Location = new System.Drawing.Point(25, 113);
            this.changeSettingsButton.Name = "changeSettingsButton";
            this.changeSettingsButton.Size = new System.Drawing.Size(250, 30);
            this.changeSettingsButton.TabIndex = 2;
            this.changeSettingsButton.Text = "Change Settings";
            this.changeSettingsButton.UseVisualStyleBackColor = true;
            this.changeSettingsButton.Click += new System.EventHandler(this.changeSettingsButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(25, 157);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(250, 30);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop Simulation";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(25, 199);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(250, 30);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close and Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(306, 254);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.changeSettingsButton);
            this.Controls.Add(this.runSimulationButton);
            this.Controls.Add(this.openButton);
            this.Name = "Form";
            this.Text = "TransModeler Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button runSimulationButton;
        private System.Windows.Forms.Button changeSettingsButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button closeButton;
    }
}

