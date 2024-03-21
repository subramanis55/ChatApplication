using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace ChatApplication
{
    public partial class ChatFilter : UserControl
    {
        private Color FiltersBackColor;
        private int borderRadius = 4;

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }


        public ChatFilter()
        {
            InitializeComponent();

            FiltersBackColor = Color.FromArgb(234, 232, 230);
            BackColor =panel1.BackColor= Color.Empty;
        }

      
    

        

        private GraphicsPath CreateRoundRectPath(Rectangle rect, int radius)
        {
           // radius *= 2;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectSurface = this.ClientRectangle;
            GraphicsPath pathouter = CreateRoundRectPath(rectSurface, BorderRadius);

            using (Pen p = new Pen(Color.Black, 4))
            {
                using (Brush brush1 = new SolidBrush(FiltersBackColor))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

                    //  this.Region = new Region(pathouter);


                  //  e.Graphics.DrawPath(p, pathouter);

                    e.Graphics.FillPath(brush1, pathouter);
                }
            }
        }
    }
}
