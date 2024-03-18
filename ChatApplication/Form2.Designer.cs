namespace ChatApplication
{
    partial class Form2
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
            this.messageShowTB = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IPLB = new System.Windows.Forms.Label();
            this.ConnectionBtn = new System.Windows.Forms.Button();
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.messageTB = new System.Windows.Forms.TextBox();
            this.sentBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageShowTB
            // 
            this.messageShowTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageShowTB.Location = new System.Drawing.Point(0, 106);
            this.messageShowTB.Name = "messageShowTB";
            this.messageShowTB.Size = new System.Drawing.Size(742, 273);
            this.messageShowTB.TabIndex = 6;
            this.messageShowTB.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IPLB);
            this.panel2.Controls.Add(this.ConnectionBtn);
            this.panel2.Controls.Add(this.IPtextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(742, 53);
            this.panel2.TabIndex = 5;
            // 
            // IPLB
            // 
            this.IPLB.AutoSize = true;
            this.IPLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLB.Location = new System.Drawing.Point(53, 21);
            this.IPLB.Name = "IPLB";
            this.IPLB.Size = new System.Drawing.Size(24, 20);
            this.IPLB.TabIndex = 2;
            this.IPLB.Text = "IP";
            // 
            // ConnectionBtn
            // 
            this.ConnectionBtn.BackColor = System.Drawing.Color.White;
            this.ConnectionBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ConnectionBtn.FlatAppearance.BorderSize = 0;
            this.ConnectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectionBtn.Location = new System.Drawing.Point(621, 10);
            this.ConnectionBtn.Name = "ConnectionBtn";
            this.ConnectionBtn.Size = new System.Drawing.Size(111, 33);
            this.ConnectionBtn.TabIndex = 1;
            this.ConnectionBtn.Text = "Connection";
            this.ConnectionBtn.UseVisualStyleBackColor = false;
            this.ConnectionBtn.Click += new System.EventHandler(this.ConnectionBtn_Click);
            // 
            // IPtextBox
            // 
            this.IPtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPtextBox.Location = new System.Drawing.Point(101, 18);
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(150, 26);
            this.IPtextBox.TabIndex = 0;
            this.IPtextBox.Text = "192.168.3.62";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 53);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.messageTB);
            this.panel3.Controls.Add(this.sentBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 379);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(742, 77);
            this.panel3.TabIndex = 7;
            // 
            // messageTB
            // 
            this.messageTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.messageTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTB.Location = new System.Drawing.Point(20, 20);
            this.messageTB.Multiline = true;
            this.messageTB.Name = "messageTB";
            this.messageTB.Size = new System.Drawing.Size(571, 37);
            this.messageTB.TabIndex = 1;
            // 
            // sentBtn
            // 
            this.sentBtn.BackColor = System.Drawing.Color.White;
            this.sentBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.sentBtn.FlatAppearance.BorderSize = 0;
            this.sentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sentBtn.Location = new System.Drawing.Point(611, 20);
            this.sentBtn.Name = "sentBtn";
            this.sentBtn.Size = new System.Drawing.Size(111, 37);
            this.sentBtn.TabIndex = 2;
            this.sentBtn.Text = "Sent";
            this.sentBtn.UseVisualStyleBackColor = false;
            this.sentBtn.Click += new System.EventHandler(this.sentBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 456);
            this.Controls.Add(this.messageShowTB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox messageShowTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label IPLB;
        private System.Windows.Forms.Button ConnectionBtn;
        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox messageTB;
        private System.Windows.Forms.Button sentBtn;
    }
}