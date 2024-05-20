namespace ChatApplication
{
    partial class CreateGroupPageU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGroupPageU));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dpPictureU = new ChatApplication.DpPictureU();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupNameTB = new ChatApplication.CustomSearchBox();
            this.groupCreateNextP = new System.Windows.Forms.Panel();
            this.cancelBtn = new ChatApplication.EllipseButton();
            this.CreateBtn = new ChatApplication.EllipseButton();
            this.groupnameErrorLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupCreateNextP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dpPictureU);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 132);
            this.panel1.TabIndex = 1;
            // 
            // dpPictureU
            // 
            this.dpPictureU.DpPicturPath = "";
            this.dpPictureU.EditBtnImage = ((System.Drawing.Image)(resources.GetObject("dpPictureU.EditBtnImage")));
            this.dpPictureU.Image = global::ChatApplication.Properties.Resources.camera;
            this.dpPictureU.Location = new System.Drawing.Point(87, 18);
            this.dpPictureU.Margin = new System.Windows.Forms.Padding(2);
            this.dpPictureU.Name = "dpPictureU";
            this.dpPictureU.Size = new System.Drawing.Size(117, 78);
            this.dpPictureU.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupNameTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel2.Size = new System.Drawing.Size(296, 69);
            this.panel2.TabIndex = 2;
            // 
            // groupNameTB
            // 
            this.groupNameTB.BackColor = System.Drawing.Color.White;
            this.groupNameTB.BorderSize = 4;
            this.groupNameTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupNameTB.IsSearchIconVisible = false;
            this.groupNameTB.IsUnderLine = true;
            this.groupNameTB.Location = new System.Drawing.Point(10, 26);
            this.groupNameTB.Multiline = true;
            this.groupNameTB.Name = "groupNameTB";
            this.groupNameTB.Padding = new System.Windows.Forms.Padding(15, 7, 7, 7);
            this.groupNameTB.PlaceholderText = "Group Name";
            this.groupNameTB.ReadOnly = false;
            this.groupNameTB.Size = new System.Drawing.Size(276, 43);
            this.groupNameTB.TabIndex = 2;
            // 
            // groupCreateNextP
            // 
            this.groupCreateNextP.Controls.Add(this.cancelBtn);
            this.groupCreateNextP.Controls.Add(this.CreateBtn);
            this.groupCreateNextP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupCreateNextP.Location = new System.Drawing.Point(0, 312);
            this.groupCreateNextP.Name = "groupCreateNextP";
            this.groupCreateNextP.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.groupCreateNextP.Size = new System.Drawing.Size(296, 44);
            this.groupCreateNextP.TabIndex = 5;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.BackgroudColor = System.Drawing.Color.White;
            this.cancelBtn.BorderColor = System.Drawing.Color.Black;
            this.cancelBtn.BorderRadius1 = 10;
            this.cancelBtn.BorderSize1 = 0;
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(162, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(124, 36);
            this.cancelBtn.SlowMotionInterval = 5;
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextColor = System.Drawing.Color.Black;
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.CreateBtn.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.CreateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CreateBtn.BorderRadius1 = 10;
            this.CreateBtn.BorderSize1 = 0;
            this.CreateBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.CreateBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.CreateBtn.FlatAppearance.BorderSize = 0;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBtn.Location = new System.Drawing.Point(10, 4);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(130, 36);
            this.CreateBtn.SlowMotionInterval = 5;
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.TextColor = System.Drawing.Color.White;
            this.CreateBtn.UseVisualStyleBackColor = false;
            // 
            // firstnameErrorLB
            // 
            this.groupnameErrorLB.AutoSize = true;
            this.groupnameErrorLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupnameErrorLB.ForeColor = System.Drawing.Color.Red;
            this.groupnameErrorLB.Location = new System.Drawing.Point(28, 213);
            this.groupnameErrorLB.Name = "firstnameErrorLB";
            this.groupnameErrorLB.Size = new System.Drawing.Size(38, 17);
            this.groupnameErrorLB.TabIndex = 14;
            this.groupnameErrorLB.Text = "Error";
            this.groupnameErrorLB.Visible = false;
            // 
            // CreateGroupPageU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupnameErrorLB);
            this.Controls.Add(this.groupCreateNextP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CreateGroupPageU";
            this.Size = new System.Drawing.Size(296, 356);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupCreateNextP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DpPictureU dpPictureU;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel groupCreateNextP;
        private EllipseButton cancelBtn;
        private EllipseButton CreateBtn;
        private CustomSearchBox groupNameTB;
        private System.Windows.Forms.Label groupnameErrorLB;
    }
}
