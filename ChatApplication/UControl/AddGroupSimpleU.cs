using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class AddGroupSimpleU : UserControl
    {
        public event EventHandler OnClickAddGroupSimpleU;
        public string LabelText
        {
            get
            {
                return newGroupLB.Text;
            }
            set
            {
                newGroupLB.Text = value;
            }
        }
        public AddGroupSimpleU()
        {
            InitializeComponent();
            Resize += AddGroupSimpleUResize;
            AddGroupSimpleUResize(this, EventArgs.Empty);
            Paint += AddGroupSimpleUPaint;
        }

        private void AddGroupSimpleUPaint(object sender, PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //e.Graphics.DrawLine(new Pen(Color.LightGray, 2), new Point(1, Height - 3), new Point(Width - 1, Height - 3));
        }

        private void AddGroupSimpleUResize(object sender, EventArgs e)
        {
            newGroupLB.Location = new Point(Width / 2 - newGroupLB.Width / 2, Height / 2 - newGroupLB.Height / 2);
        }

        private void AddGroupUMouseEnter(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#ECEAE9");
        }
        private void AddGroupUMouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }

        private void AddGroupUClick(object sender, EventArgs e)
        {
            OnClickAddGroupSimpleU?.Invoke(this, e);
        }
    }
}
