namespace ChatApplication
{
    partial class AddGroupSimpleU
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
            this.newGroupLB = new System.Windows.Forms.Label();
            this.customPictureBox2 = new ChatApplication.CustomPictureBox();
            this.customPictureBox1 = new ChatApplication.CustomPictureBox();
            this.ellipseControl1 = new ChatApplication.EllipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newGroupLB
            // 
            this.newGroupLB.AutoSize = true;
            this.newGroupLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGroupLB.Location = new System.Drawing.Point(103, 10);
            this.newGroupLB.Name = "newGroupLB";
            this.newGroupLB.Size = new System.Drawing.Size(89, 20);
            this.newGroupLB.TabIndex = 1;
            this.newGroupLB.Text = "New Group";
            this.newGroupLB.Click += new System.EventHandler(this.AddGroupUClick);
            this.newGroupLB.MouseEnter += new System.EventHandler(this.AddGroupUMouseEnter);
            this.newGroupLB.MouseLeave += new System.EventHandler(this.AddGroupUMouseLeave);
            // 
            // customPictureBox2
            // 
            this.customPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.customPictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.customPictureBox2.Image = global::ChatApplication.Properties.Resources.plus__2_;
            this.customPictureBox2.Location = new System.Drawing.Point(198, 0);
            this.customPictureBox2.Name = "customPictureBox2";
            this.customPictureBox2.Size = new System.Drawing.Size(42, 42);
            this.customPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.customPictureBox2.TabIndex = 2;
            this.customPictureBox2.TabStop = false;
            this.customPictureBox2.Click += new System.EventHandler(this.AddGroupUClick);
            this.customPictureBox2.MouseEnter += new System.EventHandler(this.AddGroupUMouseEnter);
            this.customPictureBox2.MouseLeave += new System.EventHandler(this.AddGroupUMouseLeave);
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.customPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.customPictureBox1.Image = global::ChatApplication.Properties.Resources.people__5_;
            this.customPictureBox1.Location = new System.Drawing.Point(20, 0);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(42, 42);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.customPictureBox1.TabIndex = 0;
            this.customPictureBox1.TabStop = false;
            this.customPictureBox1.Click += new System.EventHandler(this.AddGroupUClick);
            this.customPictureBox1.MouseEnter += new System.EventHandler(this.AddGroupUMouseEnter);
            this.customPictureBox1.MouseLeave += new System.EventHandler(this.AddGroupUMouseLeave);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // AddGroupSimpleU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.customPictureBox2);
            this.Controls.Add(this.newGroupLB);
            this.Controls.Add(this.customPictureBox1);
            this.Name = "AddGroupSimpleU";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 15, 0);
            this.Size = new System.Drawing.Size(255, 42);
            this.Click += new System.EventHandler(this.AddGroupUClick);
            this.MouseEnter += new System.EventHandler(this.AddGroupUMouseEnter);
            this.MouseLeave += new System.EventHandler(this.AddGroupUMouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label newGroupLB;
        private CustomPictureBox customPictureBox1;
        private CustomPictureBox customPictureBox2;
        private EllipseControl ellipseControl1;
    }
}
