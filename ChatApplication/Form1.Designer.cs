namespace ChatApplication
{
    partial class Form1
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
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.ConnectionBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clientPortTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerPortTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientIPTB = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IPLB = new System.Windows.Forms.Label();
            this.ServerIPtextBox = new System.Windows.Forms.TextBox();
            this.sentBtn = new System.Windows.Forms.Button();
            this.messageTB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.messageShowTB = new System.Windows.Forms.RichTextBox();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 65);
            this.panel1.TabIndex = 8;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.White;
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(0, 0);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(121, 33);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtnClick);
            // 
            // ConnectionBtn
            // 
            this.ConnectionBtn.BackColor = System.Drawing.Color.White;
            this.ConnectionBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConnectionBtn.FlatAppearance.BorderSize = 0;
            this.ConnectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionBtn.Location = new System.Drawing.Point(0, 50);
            this.ConnectionBtn.Name = "ConnectionBtn";
            this.ConnectionBtn.Size = new System.Drawing.Size(121, 33);
            this.ConnectionBtn.TabIndex = 1;
            this.ConnectionBtn.Text = "Connection";
            this.ConnectionBtn.UseVisualStyleBackColor = false;
            this.ConnectionBtn.Click += new System.EventHandler(this.ConnectionBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "port";
            // 
            // clientPortTB
            // 
            this.clientPortTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPortTB.Location = new System.Drawing.Point(395, 64);
            this.clientPortTB.Name = "clientPortTB";
            this.clientPortTB.Size = new System.Drawing.Size(150, 26);
            this.clientPortTB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "port";
            // 
            // ServerPortTB
            // 
            this.ServerPortTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerPortTB.Location = new System.Drawing.Point(395, 18);
            this.ServerPortTB.Name = "ServerPortTB";
            this.ServerPortTB.Size = new System.Drawing.Size(150, 26);
            this.ServerPortTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client";
            // 
            // clientIPTB
            // 
            this.clientIPTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIPTB.Location = new System.Drawing.Point(101, 62);
            this.clientIPTB.Name = "clientIPTB";
            this.clientIPTB.Size = new System.Drawing.Size(150, 26);
            this.clientIPTB.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.startBtn);
            this.panel4.Controls.Add(this.ConnectionBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(708, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 83);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.clientPortTB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ServerPortTB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.clientIPTB);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.IPLB);
            this.panel2.Controls.Add(this.ServerIPtextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(839, 103);
            this.panel2.TabIndex = 9;
            // 
            // IPLB
            // 
            this.IPLB.AutoSize = true;
            this.IPLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLB.Location = new System.Drawing.Point(40, 21);
            this.IPLB.Name = "IPLB";
            this.IPLB.Size = new System.Drawing.Size(55, 20);
            this.IPLB.TabIndex = 2;
            this.IPLB.Text = "Server";
            // 
            // ServerIPtextBox
            // 
            this.ServerIPtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIPtextBox.Location = new System.Drawing.Point(101, 18);
            this.ServerIPtextBox.Name = "ServerIPtextBox";
            this.ServerIPtextBox.Size = new System.Drawing.Size(150, 26);
            this.ServerIPtextBox.TabIndex = 0;
            // 
            // sentBtn
            // 
            this.sentBtn.BackColor = System.Drawing.Color.White;
            this.sentBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.sentBtn.FlatAppearance.BorderSize = 0;
            this.sentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sentBtn.Location = new System.Drawing.Point(708, 20);
            this.sentBtn.Name = "sentBtn";
            this.sentBtn.Size = new System.Drawing.Size(111, 37);
            this.sentBtn.TabIndex = 2;
            this.sentBtn.Text = "Sent";
            this.sentBtn.UseVisualStyleBackColor = false;
            this.sentBtn.Click += new System.EventHandler(this.SentBtn_Click);
            // 
            // messageTB
            // 
            this.messageTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.messageTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTB.Location = new System.Drawing.Point(20, 20);
            this.messageTB.Multiline = true;
            this.messageTB.Name = "messageTB";
            this.messageTB.Size = new System.Drawing.Size(504, 37);
            this.messageTB.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.messageTB);
            this.panel3.Controls.Add(this.sentBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 413);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(839, 77);
            this.panel3.TabIndex = 10;
            // 
            // messageShowTB
            // 
            this.messageShowTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageShowTB.Location = new System.Drawing.Point(0, 168);
            this.messageShowTB.Name = "messageShowTB";
            this.messageShowTB.Size = new System.Drawing.Size(839, 245);
            this.messageShowTB.TabIndex = 11;
            this.messageShowTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 490);
            this.Controls.Add(this.messageShowTB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button ConnectionBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientPortTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServerPortTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientIPTB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label IPLB;
        private System.Windows.Forms.TextBox ServerIPtextBox;
        private System.Windows.Forms.Button sentBtn;
        private System.Windows.Forms.TextBox messageTB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox messageShowTB;
    }
}

