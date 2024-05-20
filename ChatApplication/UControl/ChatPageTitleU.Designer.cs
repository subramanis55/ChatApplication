namespace ChatApplication
{
    partial class ChatPageTitleU
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contactStatusLabel = new System.Windows.Forms.Label();
            this.nameLB = new System.Windows.Forms.Label();
            this.addToArchivedBtn = new ChatApplication.EllipseButton();
            this.addGroupMemberBtn = new ChatApplication.EllipseButton();
            this.contactDpPicturePB = new ChatApplication.CustomPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactDpPicturePB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addToArchivedBtn);
            this.panel1.Controls.Add(this.addGroupMemberBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(64, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 4, 4, 4);
            this.panel1.Size = new System.Drawing.Size(513, 58);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.contactStatusLabel);
            this.panel2.Controls.Add(this.nameLB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.panel2.Size = new System.Drawing.Size(401, 50);
            this.panel2.TabIndex = 6;
            this.panel2.Click += new System.EventHandler(this.ChatPageTitleUClick);
            // 
            // contactStatusLabel
            // 
            this.contactStatusLabel.AutoSize = true;
            this.contactStatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contactStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.contactStatusLabel.Location = new System.Drawing.Point(3, 32);
            this.contactStatusLabel.Name = "contactStatusLabel";
            this.contactStatusLabel.Size = new System.Drawing.Size(48, 15);
            this.contactStatusLabel.TabIndex = 5;
            this.contactStatusLabel.Text = " Group ";
            this.contactStatusLabel.Click += new System.EventHandler(this.ChatPageTitleUClick);
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLB.ForeColor = System.Drawing.Color.Black;
            this.nameLB.Location = new System.Drawing.Point(3, 1);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(51, 20);
            this.nameLB.TabIndex = 4;
            this.nameLB.Text = "label1";
            this.nameLB.Click += new System.EventHandler(this.ChatPageTitleUClick);
            this.nameLB.MouseEnter += new System.EventHandler(this.nameLBEnter);
            this.nameLB.MouseLeave += new System.EventHandler(this.nameLBLeave);
            // 
            // addToArchivedBtn
            // 
            this.addToArchivedBtn.BackColor = System.Drawing.Color.Transparent;
            this.addToArchivedBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.addToArchivedBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addToArchivedBtn.BorderRadius1 = 10;
            this.addToArchivedBtn.BorderSize1 = 0;
            this.addToArchivedBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addToArchivedBtn.EllipseColor = System.Drawing.Color.White;
            this.addToArchivedBtn.FlatAppearance.BorderSize = 0;
            this.addToArchivedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToArchivedBtn.ForeColor = System.Drawing.Color.White;
            this.addToArchivedBtn.Image = global::ChatApplication.Properties.Resources.AddToArchivedIcon1;
            this.addToArchivedBtn.Location = new System.Drawing.Point(421, 4);
            this.addToArchivedBtn.Name = "addToArchivedBtn";
            this.addToArchivedBtn.Size = new System.Drawing.Size(46, 50);
            this.addToArchivedBtn.SlowMotionInterval = 5;
            this.addToArchivedBtn.TabIndex = 8;
            this.addToArchivedBtn.TextColor = System.Drawing.Color.White;
            this.addToArchivedBtn.UseVisualStyleBackColor = false;
            // 
            // addGroupMemberBtn
            // 
            this.addGroupMemberBtn.BackColor = System.Drawing.Color.Transparent;
            this.addGroupMemberBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.addGroupMemberBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addGroupMemberBtn.BorderRadius1 = 10;
            this.addGroupMemberBtn.BorderSize1 = 0;
            this.addGroupMemberBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addGroupMemberBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.addGroupMemberBtn.FlatAppearance.BorderSize = 0;
            this.addGroupMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGroupMemberBtn.ForeColor = System.Drawing.Color.White;
            this.addGroupMemberBtn.Image = global::ChatApplication.Properties.Resources.icons8_add_male_user_group_30;
            this.addGroupMemberBtn.Location = new System.Drawing.Point(467, 4);
            this.addGroupMemberBtn.Name = "addGroupMemberBtn";
            this.addGroupMemberBtn.Size = new System.Drawing.Size(42, 50);
            this.addGroupMemberBtn.SlowMotionInterval = 5;
            this.addGroupMemberBtn.TabIndex = 3;
            this.addGroupMemberBtn.TextColor = System.Drawing.Color.White;
            this.addGroupMemberBtn.UseVisualStyleBackColor = false;
            this.addGroupMemberBtn.Visible = false;
            // 
            // contactDpPicturePB
            // 
            this.contactDpPicturePB.BackColor = System.Drawing.Color.LightGray;
            this.contactDpPicturePB.Dock = System.Windows.Forms.DockStyle.Left;
            this.contactDpPicturePB.Location = new System.Drawing.Point(6, 6);
            this.contactDpPicturePB.Name = "contactDpPicturePB";
            this.contactDpPicturePB.Size = new System.Drawing.Size(58, 58);
            this.contactDpPicturePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contactDpPicturePB.TabIndex = 0;
            this.contactDpPicturePB.TabStop = false;
            this.contactDpPicturePB.Click += new System.EventHandler(this.ChatPageTitleUClick);
            // 
            // ChatPageTitleU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contactDpPicturePB);
            this.MinimumSize = new System.Drawing.Size(0, 70);
            this.Name = "ChatPageTitleU";
            this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Size = new System.Drawing.Size(583, 70);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactDpPicturePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPictureBox contactDpPicturePB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label contactStatusLabel;
        private System.Windows.Forms.Label nameLB;
        private EllipseButton addGroupMemberBtn;
        private EllipseButton addToArchivedBtn;
    }
}
