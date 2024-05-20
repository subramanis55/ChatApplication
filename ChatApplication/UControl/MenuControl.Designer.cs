﻿using System.Drawing;
using System.Windows.Forms;

namespace ChatApplication
{
    partial class MenuControl
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
            this.StatusBtn = new ChatApplication.HoverButton();
            this.CallsBtn = new ChatApplication.HoverButton();
            this.StarBtn = new ChatApplication.HoverButton();
            this.ArchivedBtn = new ChatApplication.HoverButton();
            this.ChatsBtn = new ChatApplication.HoverButton();
            this.profilePictureBox = new ChatApplication.CustomPictureBox();
            this.DpPB = new ChatApplication.CustomPictureBox();
            this.SettingBtn = new ChatApplication.EllipseButton();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DpPB)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusBtn
            // 
            this.StatusBtn.BackColor = System.Drawing.Color.Transparent;
            this.StatusBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.StatusBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.StatusBtn.BorderRadius1 = 10;
            this.StatusBtn.BorderSize1 = 0;
            this.StatusBtn.ButtonSideHoverlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.StatusBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.StatusBtn.EndPoint = -3;
            this.StatusBtn.FlatAppearance.BorderSize = 0;
            this.StatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusBtn.ForeColor = System.Drawing.Color.White;
            this.StatusBtn.Image = global::ChatApplication.Properties.Resources.icons8_connection_status_on_22;
            this.StatusBtn.IsFormUp = false;
            this.StatusBtn.IsSelected = false;
            this.StatusBtn.Location = new System.Drawing.Point(4, 103);
            this.StatusBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StatusBtn.Name = "StatusBtn";
            this.StatusBtn.Size = new System.Drawing.Size(64, 50);
            this.StatusBtn.SlowMotionInterval = 12;
            this.StatusBtn.TabIndex = 2;
            this.StatusBtn.TabStop = false;
            this.StatusBtn.TextColor = System.Drawing.Color.White;
            this.StatusBtn.UseVisualStyleBackColor = false;
            // 
            // CallsBtn
            // 
            this.CallsBtn.BackColor = System.Drawing.Color.Transparent;
            this.CallsBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.CallsBtn.BorderColor = System.Drawing.Color.Transparent;
            this.CallsBtn.BorderRadius1 = 10;
            this.CallsBtn.BorderSize1 = 0;
            this.CallsBtn.ButtonSideHoverlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.CallsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CallsBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.CallsBtn.EndPoint = -3;
            this.CallsBtn.FlatAppearance.BorderSize = 0;
            this.CallsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CallsBtn.ForeColor = System.Drawing.Color.White;
            this.CallsBtn.Image = global::ChatApplication.Properties.Resources.icons8_phone_22__1_;
            this.CallsBtn.IsFormUp = false;
            this.CallsBtn.IsSelected = false;
            this.CallsBtn.Location = new System.Drawing.Point(4, 53);
            this.CallsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CallsBtn.Name = "CallsBtn";
            this.CallsBtn.Size = new System.Drawing.Size(64, 50);
            this.CallsBtn.SlowMotionInterval = 12;
            this.CallsBtn.TabIndex = 8;
            this.CallsBtn.TextColor = System.Drawing.Color.White;
            this.CallsBtn.UseVisualStyleBackColor = false;
            // 
            // StarBtn
            // 
            this.StarBtn.BackColor = System.Drawing.Color.Transparent;
            this.StarBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.StarBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.StarBtn.BorderRadius1 = 10;
            this.StarBtn.BorderSize1 = 0;
            this.StarBtn.ButtonSideHoverlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.StarBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StarBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.StarBtn.EndPoint = -3;
            this.StarBtn.FlatAppearance.BorderSize = 0;
            this.StarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StarBtn.ForeColor = System.Drawing.Color.White;
            this.StarBtn.Image = global::ChatApplication.Properties.Resources.icons8_star_22;
            this.StarBtn.IsFormUp = false;
            this.StarBtn.IsSelected = false;
            this.StarBtn.Location = new System.Drawing.Point(4, 305);
            this.StarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StarBtn.Name = "StarBtn";
            this.StarBtn.Size = new System.Drawing.Size(64, 50);
            this.StarBtn.SlowMotionInterval = 12;
            this.StarBtn.TabIndex = 5;
            this.StarBtn.TabStop = false;
            this.StarBtn.TextColor = System.Drawing.Color.White;
            this.StarBtn.UseVisualStyleBackColor = false;
            // 
            // ArchivedBtn
            // 
            this.ArchivedBtn.BackColor = System.Drawing.Color.Transparent;
            this.ArchivedBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.ArchivedBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ArchivedBtn.BorderRadius1 = 10;
            this.ArchivedBtn.BorderSize1 = 0;
            this.ArchivedBtn.ButtonSideHoverlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.ArchivedBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ArchivedBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ArchivedBtn.EndPoint = -3;
            this.ArchivedBtn.FlatAppearance.BorderSize = 0;
            this.ArchivedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArchivedBtn.ForeColor = System.Drawing.Color.White;
            this.ArchivedBtn.Image = global::ChatApplication.Properties.Resources.icons8_box_22;
            this.ArchivedBtn.IsFormUp = false;
            this.ArchivedBtn.IsSelected = false;
            this.ArchivedBtn.Location = new System.Drawing.Point(4, 355);
            this.ArchivedBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ArchivedBtn.Name = "ArchivedBtn";
            this.ArchivedBtn.Size = new System.Drawing.Size(64, 50);
            this.ArchivedBtn.SlowMotionInterval = 12;
            this.ArchivedBtn.TabIndex = 4;
            this.ArchivedBtn.TabStop = false;
            this.ArchivedBtn.TextColor = System.Drawing.Color.White;
            this.ArchivedBtn.UseVisualStyleBackColor = false;
            // 
            // ChatsBtn
            // 
            this.ChatsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ChatsBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.ChatsBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ChatsBtn.BorderRadius1 = 10;
            this.ChatsBtn.BorderSize1 = 0;
            this.ChatsBtn.ButtonSideHoverlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.ChatsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatsBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ChatsBtn.EndPoint = 30;
            this.ChatsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ChatsBtn.FlatAppearance.BorderSize = 0;
            this.ChatsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChatsBtn.ForeColor = System.Drawing.Color.White;
            this.ChatsBtn.Image = global::ChatApplication.Properties.Resources.icons8_chat_22;
            this.ChatsBtn.IsFormUp = false;
            this.ChatsBtn.IsSelected = true;
            this.ChatsBtn.Location = new System.Drawing.Point(4, 3);
            this.ChatsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ChatsBtn.Name = "ChatsBtn";
            this.ChatsBtn.Size = new System.Drawing.Size(64, 50);
            this.ChatsBtn.SlowMotionInterval = 12;
            this.ChatsBtn.TabIndex = 0;
            this.ChatsBtn.TextColor = System.Drawing.Color.White;
            this.ChatsBtn.UseVisualStyleBackColor = false;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.profilePictureBox.Location = new System.Drawing.Point(4, 457);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(64, 40);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 9;
            this.profilePictureBox.TabStop = false;
            // 
            // DpPB
            // 
            this.DpPB.BackColor = System.Drawing.Color.Green;
            this.DpPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DpPB.Location = new System.Drawing.Point(5, 5);
            this.DpPB.Name = "DpPB";
            this.DpPB.Size = new System.Drawing.Size(54, 54);
            this.DpPB.TabIndex = 6;
            this.DpPB.TabStop = false;
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.SettingBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SettingBtn.BorderRadius1 = 10;
            this.SettingBtn.BorderSize1 = 0;
            this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.Image = global::ChatApplication.Properties.Resources.icons8_setting_22;
            this.SettingBtn.Location = new System.Drawing.Point(4, 405);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(64, 52);
            this.SettingBtn.SlowMotionInterval = 12;
            this.SettingBtn.TabIndex = 10;
            this.SettingBtn.TabStop = false;
            this.SettingBtn.TextColor = System.Drawing.Color.White;
            this.SettingBtn.UseVisualStyleBackColor = false;
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.StarBtn);
            this.Controls.Add(this.ArchivedBtn);
            this.Controls.Add(this.SettingBtn);
            this.Controls.Add(this.StatusBtn);
            this.Controls.Add(this.CallsBtn);
            this.Controls.Add(this.ChatsBtn);
            this.Controls.Add(this.profilePictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuControl";
            this.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Size = new System.Drawing.Size(72, 500);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DpPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion




        private HoverButton ChatsBtn;

        private HoverButton StatusBtn;
        private HoverButton ArchivedBtn;
        private HoverButton StarBtn;
        private CustomPictureBox DpPB;
       // private CustomPanel PhotoPanel;
        private HoverButton CallsBtn;
        private CustomPictureBox profilePictureBox;
        private EllipseButton SettingBtn;
    }
}
