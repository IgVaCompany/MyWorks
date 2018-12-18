namespace Terminal
{
    partial class AutoTest
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
            this.listBox1TestCases = new System.Windows.Forms.ListBox();
            this.pathLineAutoTextBox = new System.Windows.Forms.TextBox();
            this.listBox1Tests = new System.Windows.Forms.ListBox();
            this.listBox1Command = new System.Windows.Forms.ListBox();
            this.listBox2ValidParam = new System.Windows.Forms.ListBox();
            this.button1StartButton = new System.Windows.Forms.Button();
            this.button1StopButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1TestCases
            // 
            this.listBox1TestCases.FormattingEnabled = true;
            this.listBox1TestCases.Location = new System.Drawing.Point(12, 46);
            this.listBox1TestCases.Name = "listBox1TestCases";
            this.listBox1TestCases.Size = new System.Drawing.Size(156, 95);
            this.listBox1TestCases.TabIndex = 0;
            this.listBox1TestCases.SelectedIndexChanged += new System.EventHandler(this.listBox1TestCases_SelectedIndexChanged);
            // 
            // pathLineAutoTextBox
            // 
            this.pathLineAutoTextBox.Location = new System.Drawing.Point(13, 13);
            this.pathLineAutoTextBox.Name = "pathLineAutoTextBox";
            this.pathLineAutoTextBox.Size = new System.Drawing.Size(479, 20);
            this.pathLineAutoTextBox.TabIndex = 1;
            // 
            // listBox1Tests
            // 
            this.listBox1Tests.FormattingEnabled = true;
            this.listBox1Tests.Location = new System.Drawing.Point(174, 46);
            this.listBox1Tests.Name = "listBox1Tests";
            this.listBox1Tests.Size = new System.Drawing.Size(156, 95);
            this.listBox1Tests.TabIndex = 2;
            this.listBox1Tests.SelectedIndexChanged += new System.EventHandler(this.listBox1Tests_SelectedIndexChanged);
            // 
            // listBox1Command
            // 
            this.listBox1Command.FormattingEnabled = true;
            this.listBox1Command.Location = new System.Drawing.Point(336, 46);
            this.listBox1Command.Name = "listBox1Command";
            this.listBox1Command.Size = new System.Drawing.Size(156, 95);
            this.listBox1Command.TabIndex = 3;
            // 
            // listBox2ValidParam
            // 
            this.listBox2ValidParam.FormattingEnabled = true;
            this.listBox2ValidParam.Location = new System.Drawing.Point(498, 46);
            this.listBox2ValidParam.Name = "listBox2ValidParam";
            this.listBox2ValidParam.Size = new System.Drawing.Size(156, 95);
            this.listBox2ValidParam.TabIndex = 4;
            // 
            // button1StartButton
            // 
            this.button1StartButton.Location = new System.Drawing.Point(509, 13);
            this.button1StartButton.Name = "button1StartButton";
            this.button1StartButton.Size = new System.Drawing.Size(75, 20);
            this.button1StartButton.TabIndex = 5;
            this.button1StartButton.Text = "Start";
            this.button1StartButton.UseVisualStyleBackColor = true;
            this.button1StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1StopButton
            // 
            this.button1StopButton.Enabled = false;
            this.button1StopButton.Location = new System.Drawing.Point(600, 13);
            this.button1StopButton.Name = "button1StopButton";
            this.button1StopButton.Size = new System.Drawing.Size(75, 20);
            this.button1StopButton.TabIndex = 6;
            this.button1StopButton.Text = "Stop";
            this.button1StopButton.UseVisualStyleBackColor = true;
            this.button1StopButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(670, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ViewTests";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(670, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PrepareToTesting";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "do";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(336, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 394);
            this.listBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // AutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1StopButton);
            this.Controls.Add(this.button1StartButton);
            this.Controls.Add(this.listBox2ValidParam);
            this.Controls.Add(this.listBox1Command);
            this.Controls.Add(this.listBox1Tests);
            this.Controls.Add(this.pathLineAutoTextBox);
            this.Controls.Add(this.listBox1TestCases);
            this.Name = "AutoTest";
            this.Text = "AutoTest";
            this.Load += new System.EventHandler(this.AutoTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1TestCases;
        private System.Windows.Forms.TextBox pathLineAutoTextBox;
        private System.Windows.Forms.ListBox listBox1Tests;
        private System.Windows.Forms.ListBox listBox1Command;
        private System.Windows.Forms.ListBox listBox2ValidParam;
        private System.Windows.Forms.Button button1StartButton;
        private System.Windows.Forms.Button button1StopButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}