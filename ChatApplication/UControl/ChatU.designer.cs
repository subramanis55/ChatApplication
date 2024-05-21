using System.Drawing;
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
            this.nameLBP = new System.Windows.Forms.Panel();
            this.nameLB = new System.Windows.Forms.Label();
            this.bottomDetailsPanel = new System.Windows.Forms.Panel();
            this.showMorePanel = new System.Windows.Forms.Panel();
            this.showMoreLabel = new System.Windows.Forms.Label();
            this.timeAndStatusPanel = new System.Windows.Forms.Panel();
            this.timingLB = new System.Windows.Forms.Label();
            this.MessageSendIconPB = new System.Windows.Forms.PictureBox();
            this.messageLBPanel = new System.Windows.Forms.Panel();
            this.nameLBP.SuspendLayout();
            this.bottomDetailsPanel.SuspendLayout();
            this.showMorePanel.SuspendLayout();
            this.timeAndStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageSendIconPB)).BeginInit();
            this.messageLBPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLB
            // 
            this.messageLB.AllowDrop = true;
            this.messageLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLB.Location = new System.Drawing.Point(0, 0);
            this.messageLB.Margin = new System.Windows.Forms.Padding(0);
            this.messageLB.Name = "messageLB";
            this.messageLB.Size = new System.Drawing.Size(118, 30);
            this.messageLB.TabIndex = 0;
            this.messageLB.Text = "Hi";
            this.messageLB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChatU_MouseClick);
            this.messageLB.MouseEnter += new System.EventHandler(this.ChatUMouseEnter);
            this.messageLB.MouseLeave += new System.EventHandler(this.ChatUMouseLeave);
            // 
            // nameLBP
            // 
            this.nameLBP.Controls.Add(this.nameLB);
            this.nameLBP.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLBP.Location = new System.Drawing.Point(5, 3);
            this.nameLBP.Name = "nameLBP";
            this.nameLBP.Padding = new System.Windows.Forms.Padding(1);
            this.nameLBP.Size = new System.Drawing.Size(118, 15);
            this.nameLBP.TabIndex = 2;
            this.nameLBP.Visible = false;
            this.nameLBP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChatU_MouseClick);
            this.nameLBP.MouseEnter += new System.EventHandler(this.ChatUMouseEnter);
            this.nameLBP.MouseLeave += new System.EventHandler(this.ChatUMouseLeave);
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLB.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLB.Location = new System.Drawing.Point(1, 1);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(38, 15);
            this.nameLB.TabIndex = 0;
            this.nameLB.Text = "label1";
            this.nameLB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChatU_MouseClick);
            this.nameLB.MouseEnter += new System.EventHandler(this.ChatUMouseEnter);
            this.nameLB.MouseLeave += new System.EventHandler(this.ChatUMouseLeave);
            // 
            // bottomDetailsPanel
            // 
            this.bottomDetailsPanel.Controls.Add(this.showMorePanel);
            this.bottomDetailsPanel.Controls.Add(this.timeAndStatusPanel);
            this.bottomDetailsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomDetailsPanel.Location = new System.Drawing.Point(5, 48);
            this.bottomDetailsPanel.MinimumSize = new System.Drawing.Size(0, 30);
            this.bottomDetailsPanel.Name = "bottomDetailsPanel";
            this.bottomDetailsPanel.Size = new System.Drawing.Size(118, 30);
            this.bottomDetailsPanel.TabIndex = 4;
            this.bottomDetailsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChatU_MouseClick);
            this.bottomDetailsPanel.MouseEnter += new System.EventHandler(this.ChatUMouseEnter);
            this.bottomDetailsPanel.MouseLeave += new System.EventHandler(this.ChatUMouseLeave);
            // 
            // showMorePanel
            // 
            this.showMorePanel.BackColor = System.Drawing.Color.Transparent;
            this.showMorePanel.Controls.Add(this.showMoreLabel);
            this.showMorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showMorePanel.Location = new System.Drawing.Point(0, 0);
            this.showMorePanel.Name = "showMorePanel";
            this.showMorePanel.Padding = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.showMorePanel.Size = new System.Drawing.Size(118, 15);
            this.showMorePanel.TabIndex = 4;
            this.showMorePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChatU_MouseClick);
            this.showMorePanel.MouseEnter += new System.EventHandler(this.ChatUMouseEnter);
            this.showMorePanel.MouseLeave += new System.EventHandler(this.ChatUMouseLeave);
            // 
            // showMoreLabel
            // 
            this.showMoreLabel.AutoSize = true;
            this.showMoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showMoreLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMoreLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.showMoreLabel.Location = new System.Drawing.Point(1, 3);
            this.showMoreLabel.Name = "showMoreLabel";
            this.showMoreLabel.Size = new System.Drawing.Size(64, 15);
            this.showMoreLabel.TabIndex = 0;
            this.showMoreLabel.Text = "ShowMore";
            this.showMoreLabel.Click += new System.EventHandler(this.showMoreLabelClick);
            this.showMoreLabel.MouseEnter += new System.EventHandler(this.ChatUMouseEnter);
            this.showMoreLabel.MouseLeave += new System.EventHandler(this.ChatUMouseLeave);
            // 
            // timeAndStatusPanel
            // 
            this.timeAndStatusPanel.Controls.Add(this.timingLB);
            this.timeAndStatusPanel.Controls.Add(this.MessageSendIconPB);
            this.timeAndStatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeAndStatusPanel.Location = new System.Drawing.Point(0, 15);
            this.timeAndStatusPanel.Margin = new System.Windows.Forms.Padding(2);
            this.timeAndStatusPanel.MinimumSize = new System.Drawing.Size(0, 12);
            this.timeAndStatusPanel.Name = "timeAndStatusPanel";
            this.timeAndStatusPanel.Padding = new System.Windows.Forms.Padding(0, 1, 7, 2);
            this.timeAndStatusPanel.Size = new System.Drawing.Size(118, 15);
            this.timeAndStatusPanel.TabIndex = 5;
            this.timeAndStatusPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChatU_MouseClick);
            this.timeAndStatusPanel.MouseEnter += new System.EventHandler(this.ChatUMouseEnter);
            this.timeAndStatusPanel.MouseLeave += new System.EventHandler(this.ChatUMouseLeave);
            // 
            // timingLB
            // 
            this.timingLB.AutoSize = true;
            this.timingLB.Dock = System.Windows.Forms.DockStyle.Right;
            this.timingLB.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timingLB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.timingLB.Location = new System.Drawing.Point(67, 1);
            this.timingLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timingLB.Name = "timingLB";
            this.timingLB.Padding = new System.Windows.Forms.Padding(0, 0, 2, 3);
            this.timingLB.Size = new System.Drawing.Size(29, 15);
            this.timingLB.TabIndex = 0;
            this.timingLB.Text = "12:00";
            this.timingLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.timingLB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChatU_MouseClick);
            this.timingLB.MouseEnter += new System.EventHandler(this.ChatUMouseEnter);
            this.timingLB.MouseLeave += new System.EventHandler(this.ChatUMouseLeave);
            // 
            // MessageSendIconPB
            // 
            this.MessageSendIconPB.Dock = System.Windows.Forms.DockStyle.Right;
            this.MessageSendIconPB.Image = global::ChatApplication.Properties.Resources.icons8_done_14__1_;
            this.MessageSendIconPB.Location = new System.Drawing.Point(96, 1);
            this.MessageSendIconPB.Margin = new System.Windows.Forms.Padding(2);
            this.MessageSendIconPB.Name = "MessageSendIconPB";
            this.MessageSendIconPB.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MessageSendIconPB.Size = new System.Drawing.Size(15, 12);
            this.MessageSendIconPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MessageSendIconPB.TabIndex = 1;
            this.MessageSendIconPB.TabStop = false;
            this.MessageSendIconPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChatU_MouseClick);
            this.MessageSendIconPB.MouseEnter += new System.EventHandler(this.ChatUMouseEnter);
            this.MessageSendIconPB.MouseLeave += new System.EventHandler(this.ChatUMouseLeave);
            // 
            // messageLBPanel
            // 
            this.messageLBPanel.Controls.Add(this.messageLB);
            this.messageLBPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageLBPanel.Location = new System.Drawing.Point(5, 18);
            this.messageLBPanel.Name = "messageLBPanel";
            this.messageLBPanel.Size = new System.Drawing.Size(118, 30);
            this.messageLBPanel.TabIndex = 5;
            this.messageLBPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChatU_MouseClick);
            this.messageLBPanel.MouseEnter += new System.EventHandler(this.ChatUMouseEnter);
            this.messageLBPanel.MouseLeave += new System.EventHandler(this.ChatUMouseLeave);
            // 
            // ChatU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.messageLBPanel);
            this.Controls.Add(this.bottomDetailsPanel);
            this.Controls.Add(this.nameLBP);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(90, 50);
            this.Name = "ChatU";
            this.Padding = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.Size = new System.Drawing.Size(123, 80);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChatU_MouseClick);
            this.nameLBP.ResumeLayout(false);
            this.nameLBP.PerformLayout();
            this.bottomDetailsPanel.ResumeLayout(false);
            this.showMorePanel.ResumeLayout(false);
            this.showMorePanel.PerformLayout();
            this.timeAndStatusPanel.ResumeLayout(false);
            this.timeAndStatusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageSendIconPB)).EndInit();
            this.messageLBPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label messageLB;
        private Panel nameLBP;
        private Label nameLB;
        private Panel bottomDetailsPanel;
        private Panel showMorePanel;
        private Label showMoreLabel;
        private Panel timeAndStatusPanel;
        private Label timingLB;
        private PictureBox MessageSendIconPB;
        private Panel messageLBPanel;
    }
}
