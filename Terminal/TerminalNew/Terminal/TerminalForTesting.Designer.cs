namespace Terminal
{
    partial  class TerminalForTesting
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private  void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminalForTesting));
            this.comPortsCombo = new System.Windows.Forms.ComboBox();
            this.Ports = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.readTextBox = new System.Windows.Forms.RichTextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testsPathLineTextBox = new System.Windows.Forms.TextBox();
            this.testsComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.testsCommandsListBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.timeForWaitBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dcuComPortsCombo = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.connectDcuButton = new System.Windows.Forms.Button();
            this.closeDcuButton = new System.Windows.Forms.Button();
            this.dcuSendButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.DcuTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.validateSignalsListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dcuRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comPortsCombo
            // 
            this.comPortsCombo.FormattingEnabled = true;
            this.comPortsCombo.Location = new System.Drawing.Point(7, 30);
            this.comPortsCombo.Name = "comPortsCombo";
            this.comPortsCombo.Size = new System.Drawing.Size(121, 21);
            this.comPortsCombo.TabIndex = 1;
            // 
            // Ports
            // 
            this.Ports.AutoSize = true;
            this.Ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ports.Location = new System.Drawing.Point(7, 10);
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(112, 17);
            this.Ports.TabIndex = 3;
            this.Ports.Text = "Ports for Imitator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(131, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rate for Imitator";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "460800";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(7, 57);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(121, 36);
            this.connectBtn.TabIndex = 5;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.ConnectButtonClick);
            // 
            // readTextBox
            // 
            this.readTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readTextBox.Location = new System.Drawing.Point(261, 30);
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.Size = new System.Drawing.Size(421, 579);
            this.readTextBox.TabIndex = 7;
            this.readTextBox.Text = "";
            // 
            // closeBtn
            // 
            this.closeBtn.Enabled = false;
            this.closeBtn.Location = new System.Drawing.Point(134, 57);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(121, 36);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(7, 132);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(248, 45);
            this.sendButton.TabIndex = 10;
            this.sendButton.Text = "SEND MESSAGE";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "MESSAGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(347, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "READ DATA FROM IMITATOR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // testsPathLineTextBox
            // 
            this.testsPathLineTextBox.Location = new System.Drawing.Point(11, 269);
            this.testsPathLineTextBox.Name = "testsPathLineTextBox";
            this.testsPathLineTextBox.Size = new System.Drawing.Size(244, 20);
            this.testsPathLineTextBox.TabIndex = 12;
            this.testsPathLineTextBox.Text = "C:\\Users\\Vasilii\\Documents\\MyWorks\\trunk\\Terminal\\TerminalNew\\Terminal\\bin\\Debug\\" +
    "Tests";
            // 
            // testsComboBox
            // 
            this.testsComboBox.FormattingEnabled = true;
            this.testsComboBox.Location = new System.Drawing.Point(11, 295);
            this.testsComboBox.Name = "testsComboBox";
            this.testsComboBox.Size = new System.Drawing.Size(244, 21);
            this.testsComboBox.TabIndex = 13;
            this.testsComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Load All Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadAllTestClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 44);
            this.button2.TabIndex = 16;
            this.button2.Text = "Send One Command";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SendOneCommandClick);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(73, 106);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(182, 20);
            this.messageTextBox.TabIndex = 17;
            // 
            // testsCommandsListBox
            // 
            this.testsCommandsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testsCommandsListBox.FormattingEnabled = true;
            this.testsCommandsListBox.ItemHeight = 18;
            this.testsCommandsListBox.Location = new System.Drawing.Point(11, 322);
            this.testsCommandsListBox.Name = "testsCommandsListBox";
            this.testsCommandsListBox.Size = new System.Drawing.Size(244, 130);
            this.testsCommandsListBox.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "sa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 40);
            this.button4.TabIndex = 20;
            this.button4.Text = "vi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ViSendClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 573);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(244, 36);
            this.progressBar1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(83, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "TEST END";
            this.label4.Visible = false;
            // 
            // timeForWaitBox3
            // 
            this.timeForWaitBox3.Location = new System.Drawing.Point(117, 217);
            this.timeForWaitBox3.Name = "timeForWaitBox3";
            this.timeForWaitBox3.Size = new System.Drawing.Size(138, 20);
            this.timeForWaitBox3.TabIndex = 23;
            this.timeForWaitBox3.Text = "2000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Time bettwen commands, ms";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(261, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "REBOOT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dcuComPortsCombo
            // 
            this.dcuComPortsCombo.FormattingEnabled = true;
            this.dcuComPortsCombo.Location = new System.Drawing.Point(688, 31);
            this.dcuComPortsCombo.Name = "dcuComPortsCombo";
            this.dcuComPortsCombo.Size = new System.Drawing.Size(121, 21);
            this.dcuComPortsCombo.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(815, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 28;
            this.textBox2.Text = "460800";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(696, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ports for DCU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(812, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Rate for DCU";
            // 
            // connectDcuButton
            // 
            this.connectDcuButton.Location = new System.Drawing.Point(688, 64);
            this.connectDcuButton.Name = "connectDcuButton";
            this.connectDcuButton.Size = new System.Drawing.Size(121, 29);
            this.connectDcuButton.TabIndex = 29;
            this.connectDcuButton.Text = "Connect";
            this.connectDcuButton.UseVisualStyleBackColor = true;
            this.connectDcuButton.Click += new System.EventHandler(this.DcuConnectClick);
            // 
            // closeDcuButton
            // 
            this.closeDcuButton.Enabled = false;
            this.closeDcuButton.Location = new System.Drawing.Point(816, 64);
            this.closeDcuButton.Name = "closeDcuButton";
            this.closeDcuButton.Size = new System.Drawing.Size(99, 29);
            this.closeDcuButton.TabIndex = 30;
            this.closeDcuButton.Text = "Close";
            this.closeDcuButton.UseVisualStyleBackColor = true;
            this.closeDcuButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // dcuSendButton
            // 
            this.dcuSendButton.Enabled = false;
            this.dcuSendButton.Location = new System.Drawing.Point(815, 230);
            this.dcuSendButton.Name = "dcuSendButton";
            this.dcuSendButton.Size = new System.Drawing.Size(88, 33);
            this.dcuSendButton.TabIndex = 31;
            this.dcuSendButton.Text = "send";
            this.dcuSendButton.UseVisualStyleBackColor = true;
            this.dcuSendButton.Click += new System.EventHandler(this.dcuSendButton_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(688, 106);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(45, 52);
            this.button10.TabIndex = 32;
            this.button10.Text = "vi";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(739, 106);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(45, 52);
            this.button11.TabIndex = 32;
            this.button11.Text = "sa";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(790, 106);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(45, 52);
            this.button12.TabIndex = 32;
            this.button12.Text = "reboot";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // DcuTextBox
            // 
            this.DcuTextBox.Location = new System.Drawing.Point(688, 243);
            this.DcuTextBox.Name = "DcuTextBox";
            this.DcuTextBox.Size = new System.Drawing.Size(121, 20);
            this.DcuTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(688, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "MESSAGE";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(71, 430);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 33;
            // 
            // validateSignalsListBox
            // 
            this.validateSignalsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.validateSignalsListBox.FormattingEnabled = true;
            this.validateSignalsListBox.ItemHeight = 16;
            this.validateSignalsListBox.Location = new System.Drawing.Point(921, 32);
            this.validateSignalsListBox.Name = "validateSignalsListBox";
            this.validateSignalsListBox.Size = new System.Drawing.Size(182, 164);
            this.validateSignalsListBox.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(957, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Vasidate Signals";
            // 
            // dcuRichTextBox
            // 
            this.dcuRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dcuRichTextBox.Location = new System.Drawing.Point(688, 269);
            this.dcuRichTextBox.Name = "dcuRichTextBox";
            this.dcuRichTextBox.Size = new System.Drawing.Size(413, 340);
            this.dcuRichTextBox.TabIndex = 35;
            this.dcuRichTextBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(909, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "READ DATA FROM DCU";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1026, 202);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 36;
            this.button7.Text = "AutoTest";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // TerminalForTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1113, 622);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dcuRichTextBox);
            this.Controls.Add(this.validateSignalsListBox);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.dcuSendButton);
            this.Controls.Add(this.closeDcuButton);
            this.Controls.Add(this.connectDcuButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dcuComPortsCombo);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeForWaitBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.testsCommandsListBox);
            this.Controls.Add(this.DcuTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testsComboBox);
            this.Controls.Add(this.testsPathLineTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.readTextBox);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ports);
            this.Controls.Add(this.comPortsCombo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TerminalForTesting";
            this.Text = "TerminalForTesting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.ComboBox comPortsCombo;
        public  System.Windows.Forms.Label Ports;
        public  System.Windows.Forms.Label label1;
        public  System.Windows.Forms.TextBox textBox1;
        public  System.Windows.Forms.Button connectBtn;
        public  System.Windows.Forms.RichTextBox readTextBox;
        public  System.Windows.Forms.Button closeBtn;
        public  System.Windows.Forms.Button sendButton;
        public  System.Windows.Forms.Label label2;
        public  System.Windows.Forms.Label label3;
        public  System.Windows.Forms.TextBox testsPathLineTextBox;
        public  System.Windows.Forms.ComboBox testsComboBox;
        public  System.Windows.Forms.Button button1;
        public  System.Windows.Forms.Button button2;
        public  System.Windows.Forms.TextBox messageTextBox;
        public  System.Windows.Forms.ListBox testsCommandsListBox;
        public  System.Windows.Forms.Button button3;
        public  System.Windows.Forms.Button button4;
        public  System.Windows.Forms.ProgressBar progressBar1;
        public  System.Windows.Forms.Label label4;
        public  System.Windows.Forms.TextBox timeForWaitBox3;
        public  System.Windows.Forms.Label label5;
        public  System.Windows.Forms.Button button5;
        public  System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox dcuComPortsCombo;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button connectDcuButton;
        private System.Windows.Forms.Button closeDcuButton;
        private System.Windows.Forms.Button dcuSendButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        public System.Windows.Forms.TextBox DcuTextBox;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox validateSignalsListBox;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox dcuRichTextBox;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
    }
}

