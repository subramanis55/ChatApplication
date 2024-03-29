﻿using System.Drawing;
using System.Windows.Forms;

namespace ChatApplication
{
    partial class ChatU
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
            this.messageLB = new System.Windows.Forms.Label();
            this.ChatUBottomP = new System.Windows.Forms.Panel();
            this.timingLB = new System.Windows.Forms.Label();
            this.MessageSendIconPB = new System.Windows.Forms.PictureBox();
            this.ChatUBottomP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageSendIconPB)).BeginInit();
            this.SuspendLayout();
            // 
            // messageLB
            // 
            this.messageLB.AutoSize = true;
            this.messageLB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLB.Location = new System.Drawing.Point(8, 3);
            this.messageLB.Margin = new System.Windows.Forms.Padding(0);
            this.messageLB.Name = "messageLB";
            this.messageLB.Size = new System.Drawing.Size(22, 19);
            this.messageLB.TabIndex = 0;
            this.messageLB.Text = "Hi";
            // 
            // ChatUBottomP
            // 
            this.ChatUBottomP.Controls.Add(this.timingLB);
            this.ChatUBottomP.Controls.Add(this.MessageSendIconPB);
            this.ChatUBottomP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChatUBottomP.Location = new System.Drawing.Point(8, 20);
            this.ChatUBottomP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChatUBottomP.MinimumSize = new System.Drawing.Size(0, 12);
            this.ChatUBottomP.Name = "ChatUBottomP";
            this.ChatUBottomP.Padding = new System.Windows.Forms.Padding(0, 1, 11, 1);
            this.ChatUBottomP.Size = new System.Drawing.Size(82, 12);
            this.ChatUBottomP.TabIndex = 1;
            // 
            // timingLB
            // 
            this.timingLB.AutoSize = true;
            this.timingLB.Dock = System.Windows.Forms.DockStyle.Right;
            this.timingLB.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timingLB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.timingLB.Location = new System.Drawing.Point(20, 1);
            this.timingLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timingLB.Name = "timingLB";
            this.timingLB.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.timingLB.Size = new System.Drawing.Size(36, 15);
            this.timingLB.TabIndex = 0;
            this.timingLB.Text = "12:00";
            this.timingLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MessageSendIconPB
            // 
            this.MessageSendIconPB.Dock = System.Windows.Forms.DockStyle.Right;
            this.MessageSendIconPB.Image = global::ChatApplication.Properties.Resources.icons8_done_14__1_;
            this.MessageSendIconPB.Location = new System.Drawing.Point(56, 1);
            this.MessageSendIconPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MessageSendIconPB.Name = "MessageSendIconPB";
            this.MessageSendIconPB.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MessageSendIconPB.Size = new System.Drawing.Size(15, 10);
            this.MessageSendIconPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MessageSendIconPB.TabIndex = 1;
            this.MessageSendIconPB.TabStop = false;
            // 
            // ChatU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(210)))));
            this.Controls.Add(this.messageLB);
            this.Controls.Add(this.ChatUBottomP);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(90, 32);
            this.Name = "ChatU";
            this.Padding = new System.Windows.Forms.Padding(8, 3, 0, 0);
            this.Size = new System.Drawing.Size(90, 32);
            this.ChatUBottomP.ResumeLayout(false);
            this.ChatUBottomP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageSendIconPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label messageLB;
        private Panel ChatUBottomP;
        private Label timingLB;
        private PictureBox MessageSendIconPB;
    }
}
