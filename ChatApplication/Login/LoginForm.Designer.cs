namespace ChatApplication
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.centerP = new ChatApplication.CustomPanel();
            this.lastnameErrorLB = new System.Windows.Forms.Label();
            this.firstnameErrorLB = new System.Windows.Forms.Label();
            this.lastNameTB = new ChatApplication.TextBoxU();
            this.firstNameTB = new ChatApplication.TextBoxU();
            this.ipAddressLB = new System.Windows.Forms.Label();
            this.dpPictureU = new ChatApplication.DpPictureU();
            this.nextBtn = new ChatApplication.EllipseButton();
            this.loginTopP = new ChatApplication.CustomPanel();
            this.ellipseControl1 = new ChatApplication.EllipseControl();
            this.ellipseControl2 = new ChatApplication.EllipseControl();
            this.panel1.SuspendLayout();
            this.centerP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.centerP);
            this.panel1.Controls.Add(this.loginTopP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 524);
            this.panel1.TabIndex = 1;
            // 
            // centerP
            // 
            this.centerP.AllBorderRadius = 10;
            this.centerP.BackColor = System.Drawing.Color.White;
            this.centerP.BorderColor = System.Drawing.Color.Transparent;
            this.centerP.BorderMarginSize = 1;
            this.centerP.BottomLeftRadius = 10;
            this.centerP.BottomRight = 10;
            this.centerP.Controls.Add(this.lastnameErrorLB);
            this.centerP.Controls.Add(this.firstnameErrorLB);
            this.centerP.Controls.Add(this.lastNameTB);
            this.centerP.Controls.Add(this.firstNameTB);
            this.centerP.Controls.Add(this.ipAddressLB);
            this.centerP.Controls.Add(this.dpPictureU);
            this.centerP.Controls.Add(this.nextBtn);
            this.centerP.Location = new System.Drawing.Point(90, 50);
            this.centerP.Margin = new System.Windows.Forms.Padding(2);
            this.centerP.Name = "centerP";
            this.centerP.Size = new System.Drawing.Size(560, 438);
            this.centerP.TabIndex = 7;
            this.centerP.TopLeftRadius = 10;
            this.centerP.TopRightRadius = 10;
            // 
            // lastnameErrorLB
            // 
            this.lastnameErrorLB.AutoSize = true;
            this.lastnameErrorLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameErrorLB.ForeColor = System.Drawing.Color.Red;
            this.lastnameErrorLB.Location = new System.Drawing.Point(420, 220);
            this.lastnameErrorLB.Name = "lastnameErrorLB";
            this.lastnameErrorLB.Size = new System.Drawing.Size(38, 17);
            this.lastnameErrorLB.TabIndex = 14;
            this.lastnameErrorLB.Text = "Error";
            this.lastnameErrorLB.Visible = false;
            // 
            // firstnameErrorLB
            // 
            this.firstnameErrorLB.AutoSize = true;
            this.firstnameErrorLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameErrorLB.ForeColor = System.Drawing.Color.Red;
            this.firstnameErrorLB.Location = new System.Drawing.Point(420, 155);
            this.firstnameErrorLB.Name = "firstnameErrorLB";
            this.firstnameErrorLB.Size = new System.Drawing.Size(38, 17);
            this.firstnameErrorLB.TabIndex = 13;
            this.firstnameErrorLB.Text = "Error";
            this.firstnameErrorLB.Visible = false;
            // 
            // lastNameTB
            // 
            this.lastNameTB.BackColor = System.Drawing.Color.White;
            this.lastNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTB.Location = new System.Drawing.Point(145, 211);
            this.lastNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTB.Multiline = true;
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Padding = new System.Windows.Forms.Padding(18, 20, 8, 6);
            this.lastNameTB.PasswordChar = '\0';
            this.lastNameTB.PlaceholderFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTB.PlaceholderLabelAtCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lastNameTB.PlaceholderLabelAtTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.lastNameTB.PlaceholderText = "Lastname";
            this.lastNameTB.PlaceholderTextCenterFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lastNameTB.PlaceholderTextTopFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTB.Size = new System.Drawing.Size(260, 54);
            this.lastNameTB.TabIndex = 12;
            this.lastNameTB.TextBoxDock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameTB.TextBoxFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTB.TextBoxtext = "";
            this.lastNameTB.UseSystemPasswordChar = false;
            // 
            // firstNameTB
            // 
            this.firstNameTB.BackColor = System.Drawing.Color.White;
            this.firstNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTB.Location = new System.Drawing.Point(145, 142);
            this.firstNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTB.Multiline = true;
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Padding = new System.Windows.Forms.Padding(18, 20, 8, 6);
            this.firstNameTB.PasswordChar = '\0';
            this.firstNameTB.PlaceholderFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTB.PlaceholderLabelAtCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.firstNameTB.PlaceholderLabelAtTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.firstNameTB.PlaceholderText = "Firstname";
            this.firstNameTB.PlaceholderTextCenterFont = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTB.PlaceholderTextTopFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTB.Size = new System.Drawing.Size(260, 54);
            this.firstNameTB.TabIndex = 11;
            this.firstNameTB.TextBoxDock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameTB.TextBoxFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTB.TextBoxtext = "";
            this.firstNameTB.UseSystemPasswordChar = false;
            // 
            // ipAddressLB
            // 
            this.ipAddressLB.AutoSize = true;
            this.ipAddressLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddressLB.ForeColor = System.Drawing.Color.Black;
            this.ipAddressLB.Location = new System.Drawing.Point(152, 292);
            this.ipAddressLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipAddressLB.Name = "ipAddressLB";
            this.ipAddressLB.Size = new System.Drawing.Size(0, 18);
            this.ipAddressLB.TabIndex = 10;
            // 
            // dpPictureU
            // 
            this.dpPictureU.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dpPictureU.DpPicturPath = "";
            this.dpPictureU.EditBtnImage = ((System.Drawing.Image)(resources.GetObject("dpPictureU.EditBtnImage")));
            this.dpPictureU.Image = ((System.Drawing.Image)(resources.GetObject("dpPictureU.Image")));
            this.dpPictureU.Location = new System.Drawing.Point(212, 20);
            this.dpPictureU.Margin = new System.Windows.Forms.Padding(2);
            this.dpPictureU.Name = "dpPictureU";
            this.dpPictureU.Size = new System.Drawing.Size(106, 92);
            this.dpPictureU.TabIndex = 9;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.nextBtn.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.nextBtn.BorderColor = System.Drawing.Color.White;
            this.nextBtn.BorderRadius1 = 10;
            this.nextBtn.BorderSize1 = 0;
            this.nextBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(212, 342);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(119, 42);
            this.nextBtn.SlowMotionInterval = 5;
            this.nextBtn.TabIndex = 8;
            this.nextBtn.Text = "Next";
            this.nextBtn.TextColor = System.Drawing.Color.White;
            this.nextBtn.UseVisualStyleBackColor = false;
            // 
            // loginTopP
            // 
            this.loginTopP.AllBorderRadius = 1;
            this.loginTopP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.loginTopP.BorderColor = System.Drawing.Color.Transparent;
            this.loginTopP.BorderMarginSize = 0;
            this.loginTopP.BottomLeftRadius = 1;
            this.loginTopP.BottomRight = 1;
            this.loginTopP.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginTopP.Location = new System.Drawing.Point(0, 0);
            this.loginTopP.Margin = new System.Windows.Forms.Padding(2);
            this.loginTopP.Name = "loginTopP";
            this.loginTopP.Size = new System.Drawing.Size(742, 81);
            this.loginTopP.TabIndex = 6;
            this.loginTopP.TopLeftRadius = 1;
            this.loginTopP.TopRightRadius = 1;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 20;
            this.ellipseControl1.TargetControl = this.dpPictureU;
            // 
            // ellipseControl2
            // 
            this.ellipseControl2.CornerRadius = 5;
            this.ellipseControl2.TargetControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 524);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.centerP.ResumeLayout(false);
            this.centerP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private CustomPanel loginTopP;
        private CustomPanel centerP;
        private EllipseButton nextBtn;
        private EllipseControl ellipseControl1;
        private DpPictureU dpPictureU;
        private System.Windows.Forms.Label ipAddressLB;
        private EllipseControl ellipseControl2;
        private TextBoxU lastNameTB;
        private TextBoxU firstNameTB;
        private System.Windows.Forms.Label lastnameErrorLB;
        private System.Windows.Forms.Label firstnameErrorLB;
    }
}