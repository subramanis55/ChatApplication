namespace ChatApplication
{
    partial class ContactSimpleU
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLB = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Panel();
            this.mainP = new System.Windows.Forms.Panel();
            this.groupAdminLB = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.dpPictureBox = new ChatApplication.CustomPictureBox();
            this.ellipseControl1 = new ChatApplication.EllipseControl();
            this.labelP.SuspendLayout();
            this.mainP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLB.Location = new System.Drawing.Point(46, 8);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(44, 17);
            this.nameLB.TabIndex = 1;
            this.nameLB.Text = "Name";
            this.nameLB.Click += new System.EventHandler(this.ContactSimpleUClick);
            // 
            // labelP
            // 
            this.labelP.BackColor = System.Drawing.Color.Transparent;
            this.labelP.Controls.Add(this.mainP);
            this.labelP.Controls.Add(this.checkBox);
            this.labelP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelP.Location = new System.Drawing.Point(59, 0);
            this.labelP.Name = "labelP";
            this.labelP.Padding = new System.Windows.Forms.Padding(1, 1, 15, 1);
            this.labelP.Size = new System.Drawing.Size(190, 39);
            this.labelP.TabIndex = 2;
            this.labelP.Click += new System.EventHandler(this.ContactSimpleUClick);
            // 
            // mainP
            // 
            this.mainP.Controls.Add(this.groupAdminLB);
            this.mainP.Controls.Add(this.nameLB);
            this.mainP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainP.Location = new System.Drawing.Point(1, 1);
            this.mainP.Name = "mainP";
            this.mainP.Size = new System.Drawing.Size(159, 37);
            this.mainP.TabIndex = 3;
            this.mainP.Click += new System.EventHandler(this.ContactSimpleUClick);
            this.mainP.MouseEnter += new System.EventHandler(this.ContactSimpleUMouseEnter);
            this.mainP.MouseLeave += new System.EventHandler(this.ContactSimpleUMouseLeave);
            this.mainP.Resize += new System.EventHandler(this.ContactSimpleUResize);
            // 
            // groupAdminLB
            // 
            this.groupAdminLB.AutoSize = true;
            this.groupAdminLB.BackColor = System.Drawing.SystemColors.Control;
            this.groupAdminLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.groupAdminLB.Location = new System.Drawing.Point(120, 24);
            this.groupAdminLB.Name = "groupAdminLB";
            this.groupAdminLB.Size = new System.Drawing.Size(36, 13);
            this.groupAdminLB.TabIndex = 3;
            this.groupAdminLB.Text = "Admin";
            this.groupAdminLB.Visible = false;
            this.groupAdminLB.Click += new System.EventHandler(this.ContactSimpleUClick);
            this.groupAdminLB.MouseEnter += new System.EventHandler(this.ContactSimpleUMouseEnter);
            this.groupAdminLB.MouseLeave += new System.EventHandler(this.ContactSimpleUMouseLeave);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.Transparent;
            this.checkBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox.Location = new System.Drawing.Point(160, 1);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 37);
            this.checkBox.TabIndex = 2;
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.Visible = false;
            // 
            // dpPictureBox
            // 
            this.dpPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.dpPictureBox.Image = global::ChatApplication.Properties.Resources.profile_user;
            this.dpPictureBox.Location = new System.Drawing.Point(20, 0);
            this.dpPictureBox.Name = "dpPictureBox";
            this.dpPictureBox.Size = new System.Drawing.Size(39, 39);
            this.dpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dpPictureBox.TabIndex = 0;
            this.dpPictureBox.TabStop = false;
            this.dpPictureBox.Click += new System.EventHandler(this.ContactSimpleUClick);
            this.dpPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DpPictureBoxPaint);
            this.dpPictureBox.MouseEnter += new System.EventHandler(this.ContactSimpleUMouseEnter);
            this.dpPictureBox.MouseLeave += new System.EventHandler(this.ContactSimpleUMouseLeave);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // ContactSimpleU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.dpPictureBox);
            this.Name = "ContactSimpleU";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Size = new System.Drawing.Size(249, 39);
            this.Click += new System.EventHandler(this.ContactSimpleUClick);
            this.MouseEnter += new System.EventHandler(this.ContactSimpleUMouseEnter);
            this.MouseLeave += new System.EventHandler(this.ContactSimpleUMouseLeave);
            this.labelP.ResumeLayout(false);
            this.labelP.PerformLayout();
            this.mainP.ResumeLayout(false);
            this.mainP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPictureBox dpPictureBox;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.Panel labelP;
        private EllipseControl ellipseControl1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Panel mainP;
        private System.Windows.Forms.Label groupAdminLB;
    }
}
