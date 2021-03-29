
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
            this.realTimeFactorButton = new System.Windows.Forms.Button();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.setSignalStateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.movementComboBox = new System.Windows.Forms.ComboBox();
            this.signalIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.getVehicleStatusButton = new System.Windows.Forms.Button();
            this.getDetectorStatusButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.detectorActivateButton = new System.Windows.Forms.Button();
            this.detectorIDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.detectorIsActiveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // realTimeFactorButton
            // 
            this.realTimeFactorButton.Enabled = false;
            this.realTimeFactorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realTimeFactorButton.Location = new System.Drawing.Point(265, 105);
            this.realTimeFactorButton.Name = "realTimeFactorButton";
            this.realTimeFactorButton.Size = new System.Drawing.Size(100, 30);
            this.realTimeFactorButton.TabIndex = 2;
            this.realTimeFactorButton.Text = "Real-Time";
            this.realTimeFactorButton.UseVisualStyleBackColor = true;
            this.realTimeFactorButton.Click += new System.EventHandler(this.realTimeFactorButton_Click);
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
            this.closeButton.Location = new System.Drawing.Point(111, 475);
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
            this.groupBox1.Controls.Add(this.realTimeFactorButton);
            this.groupBox1.Controls.Add(this.slowDownButton);
            this.groupBox1.Controls.Add(this.runSimulationButton);
            this.groupBox1.Controls.Add(this.stepForwardButton);
            this.groupBox1.Controls.Add(this.pauseButton);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.stepModeButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.setSignalStateButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.colorComboBox);
            this.groupBox2.Controls.Add(this.movementComboBox);
            this.groupBox2.Controls.Add(this.signalIDTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Signal";
            // 
            // setSignalStateButton
            // 
            this.setSignalStateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setSignalStateButton.Location = new System.Drawing.Point(114, 61);
            this.setSignalStateButton.Name = "setSignalStateButton";
            this.setSignalStateButton.Size = new System.Drawing.Size(133, 30);
            this.setSignalStateButton.TabIndex = 16;
            this.setSignalStateButton.Text = "Set Signal State";
            this.setSignalStateButton.UseVisualStyleBackColor = true;
            this.setSignalStateButton.Click += new System.EventHandler(this.setSignalStateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Movement";
            // 
            // colorComboBox
            // 
            this.colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Green",
            "Yellow",
            "Red",
            "Blank"});
            this.colorComboBox.Location = new System.Drawing.Point(297, 23);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(69, 24);
            this.colorComboBox.TabIndex = 12;
            // 
            // movementComboBox
            // 
            this.movementComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movementComboBox.FormattingEnabled = true;
            this.movementComboBox.Items.AddRange(new object[] {
            "R",
            "T",
            "L",
            "U"});
            this.movementComboBox.Location = new System.Drawing.Point(184, 25);
            this.movementComboBox.Name = "movementComboBox";
            this.movementComboBox.Size = new System.Drawing.Size(63, 24);
            this.movementComboBox.TabIndex = 13;
            // 
            // signalIDTextBox
            // 
            this.signalIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signalIDTextBox.Location = new System.Drawing.Point(29, 28);
            this.signalIDTextBox.Name = "signalIDTextBox";
            this.signalIDTextBox.Size = new System.Drawing.Size(76, 22);
            this.signalIDTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.getVehicleStatusButton);
            this.groupBox3.Controls.Add(this.getDetectorStatusButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 75);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // getVehicleStatusButton
            // 
            this.getVehicleStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getVehicleStatusButton.Location = new System.Drawing.Point(187, 28);
            this.getVehicleStatusButton.Name = "getVehicleStatusButton";
            this.getVehicleStatusButton.Size = new System.Drawing.Size(178, 30);
            this.getVehicleStatusButton.TabIndex = 17;
            this.getVehicleStatusButton.Text = "Vehicles";
            this.getVehicleStatusButton.UseVisualStyleBackColor = true;
            this.getVehicleStatusButton.Click += new System.EventHandler(this.getVehicleStatusButton_Click);
            // 
            // getDetectorStatusButton
            // 
            this.getDetectorStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDetectorStatusButton.Location = new System.Drawing.Point(10, 28);
            this.getDetectorStatusButton.Name = "getDetectorStatusButton";
            this.getDetectorStatusButton.Size = new System.Drawing.Size(171, 30);
            this.getDetectorStatusButton.TabIndex = 16;
            this.getDetectorStatusButton.Text = "Detectors";
            this.getDetectorStatusButton.UseVisualStyleBackColor = true;
            this.getDetectorStatusButton.Click += new System.EventHandler(this.getDetectorStatusButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.detectorIsActiveButton);
            this.groupBox4.Controls.Add(this.detectorActivateButton);
            this.groupBox4.Controls.Add(this.detectorIDTextBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(24, 315);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 73);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detector";
            // 
            // detectorActivateButton
            // 
            this.detectorActivateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectorActivateButton.Location = new System.Drawing.Point(266, 23);
            this.detectorActivateButton.Name = "detectorActivateButton";
            this.detectorActivateButton.Size = new System.Drawing.Size(100, 30);
            this.detectorActivateButton.TabIndex = 16;
            this.detectorActivateButton.Text = "Activate";
            this.detectorActivateButton.UseVisualStyleBackColor = true;
            this.detectorActivateButton.Click += new System.EventHandler(this.detectorActivateButton_Click);
            // 
            // detectorIDTextBox
            // 
            this.detectorIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectorIDTextBox.Location = new System.Drawing.Point(29, 28);
            this.detectorIDTextBox.Name = "detectorIDTextBox";
            this.detectorIDTextBox.Size = new System.Drawing.Size(76, 22);
            this.detectorIDTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID";
            // 
            // detectorIsActiveButton
            // 
            this.detectorIsActiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectorIsActiveButton.Location = new System.Drawing.Point(137, 24);
            this.detectorIsActiveButton.Name = "detectorIsActiveButton";
            this.detectorIsActiveButton.Size = new System.Drawing.Size(100, 30);
            this.detectorIsActiveButton.TabIndex = 17;
            this.detectorIsActiveButton.Text = "Is Active?";
            this.detectorIsActiveButton.UseVisualStyleBackColor = true;
            this.detectorIsActiveButton.Click += new System.EventHandler(this.detectorIsActiveButton_Click);
            // 
            // Form
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(411, 513);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "TransModeler Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button runSimulationButton;
        private System.Windows.Forms.Button realTimeFactorButton;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button setSignalStateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ComboBox movementComboBox;
        private System.Windows.Forms.TextBox signalIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button getVehicleStatusButton;
        private System.Windows.Forms.Button getDetectorStatusButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button detectorIsActiveButton;
        private System.Windows.Forms.Button detectorActivateButton;
        private System.Windows.Forms.TextBox detectorIDTextBox;
        private System.Windows.Forms.Label label7;
    }
}

