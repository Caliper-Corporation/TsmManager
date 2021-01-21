
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
            this.pauseButton = new System.Windows.Forms.Button();
            this.stepModeButton = new System.Windows.Forms.Button();
            this.stepForwardButton = new System.Windows.Forms.Button();
            this.speedUpButton = new System.Windows.Forms.Button();
            this.slowDownButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stepSizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(111, 19);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(200, 30);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open TransModeler Project";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // runSimulationButton
            // 
            this.runSimulationButton.Enabled = false;
            this.runSimulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runSimulationButton.Location = new System.Drawing.Point(10, 29);
            this.runSimulationButton.Name = "runSimulationButton";
            this.runSimulationButton.Size = new System.Drawing.Size(100, 30);
            this.runSimulationButton.TabIndex = 1;
            this.runSimulationButton.Text = "Start";
            this.runSimulationButton.UseVisualStyleBackColor = true;
            this.runSimulationButton.Click += new System.EventHandler(this.runSimulationButton_Click);
            // 
            // changeSettingsButton
            // 
            this.changeSettingsButton.Enabled = false;
            this.changeSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSettingsButton.Location = new System.Drawing.Point(265, 105);
            this.changeSettingsButton.Name = "changeSettingsButton";
            this.changeSettingsButton.Size = new System.Drawing.Size(100, 30);
            this.changeSettingsButton.TabIndex = 2;
            this.changeSettingsButton.Text = "Change Settings";
            this.changeSettingsButton.UseVisualStyleBackColor = true;
            this.changeSettingsButton.Visible = false;
            this.changeSettingsButton.Click += new System.EventHandler(this.changeSettingsButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(10, 105);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 30);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(111, 216);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(200, 30);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close and Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Enabled = false;
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(10, 67);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(100, 30);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stepModeButton
            // 
            this.stepModeButton.Enabled = false;
            this.stepModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepModeButton.Location = new System.Drawing.Point(136, 29);
            this.stepModeButton.Name = "stepModeButton";
            this.stepModeButton.Size = new System.Drawing.Size(100, 30);
            this.stepModeButton.TabIndex = 6;
            this.stepModeButton.Text = "Step Mode";
            this.stepModeButton.UseVisualStyleBackColor = true;
            this.stepModeButton.Click += new System.EventHandler(this.stepModeButton_Click);
            // 
            // stepForwardButton
            // 
            this.stepForwardButton.Enabled = false;
            this.stepForwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepForwardButton.Location = new System.Drawing.Point(136, 105);
            this.stepForwardButton.Name = "stepForwardButton";
            this.stepForwardButton.Size = new System.Drawing.Size(100, 30);
            this.stepForwardButton.TabIndex = 7;
            this.stepForwardButton.Text = "Step Forward";
            this.stepForwardButton.UseVisualStyleBackColor = true;
            this.stepForwardButton.Click += new System.EventHandler(this.stepForwardButton_Click);
            // 
            // speedUpButton
            // 
            this.speedUpButton.Enabled = false;
            this.speedUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedUpButton.Location = new System.Drawing.Point(265, 29);
            this.speedUpButton.Name = "speedUpButton";
            this.speedUpButton.Size = new System.Drawing.Size(100, 30);
            this.speedUpButton.TabIndex = 8;
            this.speedUpButton.Text = "Speed Up";
            this.speedUpButton.UseVisualStyleBackColor = true;
            this.speedUpButton.Click += new System.EventHandler(this.speedUpButton_Click);
            // 
            // slowDownButton
            // 
            this.slowDownButton.Enabled = false;
            this.slowDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowDownButton.Location = new System.Drawing.Point(265, 67);
            this.slowDownButton.Name = "slowDownButton";
            this.slowDownButton.Size = new System.Drawing.Size(100, 30);
            this.slowDownButton.TabIndex = 9;
            this.slowDownButton.Text = "Slow Down";
            this.slowDownButton.UseVisualStyleBackColor = true;
            this.slowDownButton.Click += new System.EventHandler(this.slowDownButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stepSizeTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.speedUpButton);
            this.groupBox1.Controls.Add(this.changeSettingsButton);
            this.groupBox1.Controls.Add(this.slowDownButton);
            this.groupBox1.Controls.Add(this.runSimulationButton);
            this.groupBox1.Controls.Add(this.stepForwardButton);
            this.groupBox1.Controls.Add(this.pauseButton);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.stepModeButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 144);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation";
            // 
            // stepSizeTextBox
            // 
            this.stepSizeTextBox.Enabled = false;
            this.stepSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepSizeTextBox.Location = new System.Drawing.Point(203, 69);
            this.stepSizeTextBox.Name = "stepSizeTextBox";
            this.stepSizeTextBox.Size = new System.Drawing.Size(33, 22);
            this.stepSizeTextBox.TabIndex = 10;
            this.stepSizeTextBox.Text = "1";
            this.stepSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Step (s)";
            // 
            // Form
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(425, 260);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "TransModeler Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button runSimulationButton;
        private System.Windows.Forms.Button changeSettingsButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stepModeButton;
        private System.Windows.Forms.Button stepForwardButton;
        private System.Windows.Forms.Button speedUpButton;
        private System.Windows.Forms.Button slowDownButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox stepSizeTextBox;
        private System.Windows.Forms.Label label1;
    }
}

