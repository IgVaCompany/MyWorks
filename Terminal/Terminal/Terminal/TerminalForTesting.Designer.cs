namespace Terminal
{
    partial class TerminalForTesting
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
        private void InitializeComponent()
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
            this.SuspendLayout();
            // 
            // comPortsCombo
            // 
            this.comPortsCombo.FormattingEnabled = true;
            this.comPortsCombo.Location = new System.Drawing.Point(12, 52);
            this.comPortsCombo.Name = "comPortsCombo";
            this.comPortsCombo.Size = new System.Drawing.Size(121, 21);
            this.comPortsCombo.TabIndex = 1;
            // 
            // Ports
            // 
            this.Ports.AutoSize = true;
            this.Ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ports.Location = new System.Drawing.Point(12, 26);
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(52, 24);
            this.Ports.TabIndex = 3;
            this.Ports.Text = "Ports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(135, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "460800";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(12, 79);
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
            this.readTextBox.Location = new System.Drawing.Point(279, 55);
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.Size = new System.Drawing.Size(590, 579);
            this.readTextBox.TabIndex = 7;
            this.readTextBox.Text = "";
            // 
            // closeBtn
            // 
            this.closeBtn.Enabled = false;
            this.closeBtn.Location = new System.Drawing.Point(139, 79);
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
            this.sendButton.Location = new System.Drawing.Point(12, 154);
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
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "MESSAGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(430, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "READ DATA";
            // 
            // testsPathLineTextBox
            // 
            this.testsPathLineTextBox.Location = new System.Drawing.Point(16, 291);
            this.testsPathLineTextBox.Name = "testsPathLineTextBox";
            this.testsPathLineTextBox.Size = new System.Drawing.Size(244, 20);
            this.testsPathLineTextBox.TabIndex = 12;
            this.testsPathLineTextBox.Text = "C:\\Users\\Vasilii\\Documents\\MyWorks\\trunk\\Terminal\\Terminal\\Terminal\\bin\\Debug\\Tes" +
    "ts";
            // 
            // testsComboBox
            // 
            this.testsComboBox.FormattingEnabled = true;
            this.testsComboBox.Location = new System.Drawing.Point(16, 317);
            this.testsComboBox.Name = "testsComboBox";
            this.testsComboBox.Size = new System.Drawing.Size(244, 21);
            this.testsComboBox.TabIndex = 13;
            this.testsComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Load All Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadAllTestClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 44);
            this.button2.TabIndex = 16;
            this.button2.Text = "Send One Command";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SendOneCommandClick);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(78, 128);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(182, 20);
            this.messageTextBox.TabIndex = 17;
            // 
            // testsCommandsListBox
            // 
            this.testsCommandsListBox.FormattingEnabled = true;
            this.testsCommandsListBox.Location = new System.Drawing.Point(16, 344);
            this.testsCommandsListBox.Name = "testsCommandsListBox";
            this.testsCommandsListBox.Size = new System.Drawing.Size(244, 134);
            this.testsCommandsListBox.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "sa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 40);
            this.button4.TabIndex = 20;
            this.button4.Text = "vi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ViSendClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 595);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(244, 36);
            this.progressBar1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(88, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "TEST END";
            this.label4.Visible = false;
            // 
            // timeForWaitBox3
            // 
            this.timeForWaitBox3.Location = new System.Drawing.Point(122, 239);
            this.timeForWaitBox3.Name = "timeForWaitBox3";
            this.timeForWaitBox3.Size = new System.Drawing.Size(138, 20);
            this.timeForWaitBox3.TabIndex = 23;
            this.timeForWaitBox3.Text = "2000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Time bettwen commands, ms";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(817, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 252);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "REBOOT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TerminalForTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(881, 646);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeForWaitBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.testsCommandsListBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testsComboBox);
            this.Controls.Add(this.testsPathLineTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.readTextBox);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.ComboBox comPortsCombo;
        private System.Windows.Forms.Label Ports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.RichTextBox readTextBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox testsPathLineTextBox;
        private System.Windows.Forms.ComboBox testsComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.ListBox testsCommandsListBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeForWaitBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

