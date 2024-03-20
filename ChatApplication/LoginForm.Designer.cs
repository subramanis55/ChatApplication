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
            this.panel1 = new System.Windows.Forms.Panel();
            this.centerP = new ChatApplication.CustomPanel();
            this.ipAddressLB = new System.Windows.Forms.Label();
            this.dpPictureU = new ChatApplication.DpPictureU();
            this.nextBtn = new ChatApplication.EllipseButton();
            this.lastNameTB = new ChatApplication.TextBoxU();
            this.firstNameTB = new ChatApplication.TextBoxU();
            this.customPanel1 = new ChatApplication.CustomPanel();
            this.ellipseControl1 = new ChatApplication.EllipseControl();
            this.panel1.SuspendLayout();
            this.centerP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.centerP);
            this.panel1.Controls.Add(this.customPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 646);
            this.panel1.TabIndex = 1;
            // 
            // centerP
            // 
            this.centerP.AllBorderRadius = 25;
            this.centerP.BackColor = System.Drawing.Color.White;
            this.centerP.BorderColor = System.Drawing.Color.Transparent;
            this.centerP.BorderMarginSize = 1;
            this.centerP.BottomLeftRadius = 25;
            this.centerP.BottomRight = 25;
            this.centerP.Controls.Add(this.ipAddressLB);
            this.centerP.Controls.Add(this.dpPictureU);
            this.centerP.Controls.Add(this.nextBtn);
            this.centerP.Controls.Add(this.lastNameTB);
            this.centerP.Controls.Add(this.firstNameTB);
            this.centerP.Location = new System.Drawing.Point(120, 61);
            this.centerP.Name = "centerP";
            this.centerP.Size = new System.Drawing.Size(747, 539);
            this.centerP.TabIndex = 7;
            this.centerP.TopLeftRadius = 25;
            this.centerP.TopRightRadius = 25;
            // 
            // ipAddressLB
            // 
            this.ipAddressLB.AutoSize = true;
            this.ipAddressLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddressLB.ForeColor = System.Drawing.Color.Black;
            this.ipAddressLB.Location = new System.Drawing.Point(202, 359);
            this.ipAddressLB.Name = "ipAddressLB";
            this.ipAddressLB.Size = new System.Drawing.Size(105, 22);
            this.ipAddressLB.TabIndex = 10;
            this.ipAddressLB.Text = "IpAddress : ";
            // 
            // dpPictureU
            // 
            this.dpPictureU.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dpPictureU.DpPicturPath = "";
            this.dpPictureU.Location = new System.Drawing.Point(283, 24);
            this.dpPictureU.Name = "dpPictureU";
            this.dpPictureU.Size = new System.Drawing.Size(141, 113);
            this.dpPictureU.TabIndex = 9;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(179)))), ((int)(((byte)(148)))));
            this.nextBtn.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(179)))), ((int)(((byte)(148)))));
            this.nextBtn.BorderColor = System.Drawing.Color.White;
            this.nextBtn.BorderRadius1 = 10;
            this.nextBtn.BorderSize1 = 0;
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(283, 421);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(159, 52);
            this.nextBtn.TabIndex = 8;
            this.nextBtn.Text = "Next";
            this.nextBtn.TextColor = System.Drawing.Color.White;
            this.nextBtn.UseVisualStyleBackColor = false;
            // 
            // lastNameTB
            // 
            this.lastNameTB.BackColor = System.Drawing.Color.White;
            this.lastNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTB.Location = new System.Drawing.Point(196, 265);
            this.lastNameTB.Multiline = true;
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Padding = new System.Windows.Forms.Padding(18, 20, 8, 8);
            this.lastNameTB.PasswordChar = '\0';
            this.lastNameTB.PlaceholderLabelAtCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lastNameTB.PlaceholderLabelAtTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.lastNameTB.PlaceholderText = "Lastname";
            this.lastNameTB.Size = new System.Drawing.Size(346, 67);
            this.lastNameTB.TabIndex = 6;
            this.lastNameTB.TextBoxDock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameTB.TextBoxtext = "";
            this.lastNameTB.UseSystemPasswordChar = false;
            // 
            // firstNameTB
            // 
            this.firstNameTB.BackColor = System.Drawing.Color.White;
            this.firstNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTB.Location = new System.Drawing.Point(196, 177);
            this.firstNameTB.Multiline = true;
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Padding = new System.Windows.Forms.Padding(18, 20, 8, 8);
            this.firstNameTB.PasswordChar = '\0';
            this.firstNameTB.PlaceholderLabelAtCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.firstNameTB.PlaceholderLabelAtTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.firstNameTB.PlaceholderText = "Firstname";
            this.firstNameTB.Size = new System.Drawing.Size(346, 67);
            this.firstNameTB.TabIndex = 5;
            this.firstNameTB.TextBoxDock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameTB.TextBoxtext = "";
            this.firstNameTB.UseSystemPasswordChar = false;
            // 
            // customPanel1
            // 
            this.customPanel1.AllBorderRadius = 1;
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(179)))), ((int)(((byte)(148)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderMarginSize = 0;
            this.customPanel1.BottomLeftRadius = 1;
            this.customPanel1.BottomRight = 1;
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1004, 100);
            this.customPanel1.TabIndex = 6;
            this.customPanel1.TopLeftRadius = 1;
            this.customPanel1.TopRightRadius = 1;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 20;
            this.ellipseControl1.TargetControl = this.dpPictureU;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 646);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private TextBoxU firstNameTB;
        private CustomPanel customPanel1;
        private CustomPanel centerP;
        private EllipseButton nextBtn;
        private TextBoxU lastNameTB;
        private EllipseControl ellipseControl1;
        private DpPictureU dpPictureU;
        private System.Windows.Forms.Label ipAddressLB;
    }
}