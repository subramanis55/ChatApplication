namespace ChatApplication.UForms
{
    partial class GroupInformationF
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.numberOfMembersLB = new System.Windows.Forms.Label();
            this.adminnameLB = new System.Windows.Forms.Label();
            this.groupnameLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ellipseControl1 = new ChatApplication.EllipseControl();
            this.adminHostName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createdDateAndTimeLabel = new System.Windows.Forms.Label();
            this.adminHostNameLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.adminHostNameLabel);
            this.panel2.Controls.Add(this.createdDateAndTimeLabel);
            this.panel2.Controls.Add(this.numberOfMembersLB);
            this.panel2.Controls.Add(this.adminnameLB);
            this.panel2.Controls.Add(this.groupnameLB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(107, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 267);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // numberOfMembersLB
            // 
            this.numberOfMembersLB.AutoSize = true;
            this.numberOfMembersLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfMembersLB.Location = new System.Drawing.Point(14, 224);
            this.numberOfMembersLB.Name = "numberOfMembersLB";
            this.numberOfMembersLB.Size = new System.Drawing.Size(0, 19);
            this.numberOfMembersLB.TabIndex = 6;
            // 
            // adminnameLB
            // 
            this.adminnameLB.AutoSize = true;
            this.adminnameLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminnameLB.Location = new System.Drawing.Point(14, 73);
            this.adminnameLB.Name = "adminnameLB";
            this.adminnameLB.Size = new System.Drawing.Size(0, 19);
            this.adminnameLB.TabIndex = 5;
            // 
            // groupnameLB
            // 
            this.groupnameLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupnameLB.Location = new System.Drawing.Point(14, 20);
            this.groupnameLB.Name = "groupnameLB";
            this.groupnameLB.Size = new System.Drawing.Size(124, 39);
            this.groupnameLB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number Of   Member        ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin          ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "GroupName ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.adminHostName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 267);
            this.panel1.TabIndex = 10;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // adminHostName
            // 
            this.adminHostName.AllowDrop = true;
            this.adminHostName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminHostName.Location = new System.Drawing.Point(3, 155);
            this.adminHostName.Name = "adminHostName";
            this.adminHostName.Size = new System.Drawing.Size(101, 45);
            this.adminHostName.TabIndex = 3;
            this.adminHostName.Text = "AdminHost   Name            ";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 47);
            this.label4.TabIndex = 4;
            this.label4.Text = "Created           DateAndTime ";
            // 
            // createdDateAndTimeLabel
            // 
            this.createdDateAndTimeLabel.AutoSize = true;
            this.createdDateAndTimeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdDateAndTimeLabel.Location = new System.Drawing.Point(14, 118);
            this.createdDateAndTimeLabel.Name = "createdDateAndTimeLabel";
            this.createdDateAndTimeLabel.Size = new System.Drawing.Size(0, 19);
            this.createdDateAndTimeLabel.TabIndex = 7;
            // 
            // adminHostNameLabel
            // 
            this.adminHostNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminHostNameLabel.Location = new System.Drawing.Point(14, 155);
            this.adminHostNameLabel.Name = "adminHostNameLabel";
            this.adminHostNameLabel.Size = new System.Drawing.Size(124, 39);
            this.adminHostNameLabel.TabIndex = 8;
            // 
            // GroupInformationF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 267);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupInformationF";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GroupInformationF";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EllipseControl ellipseControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label numberOfMembersLB;
        private System.Windows.Forms.Label adminnameLB;
        private System.Windows.Forms.Label groupnameLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label adminHostName;
        private System.Windows.Forms.Label adminHostNameLabel;
        private System.Windows.Forms.Label createdDateAndTimeLabel;
        private System.Windows.Forms.Label label4;
    }
}