using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChatApplication.UControl
{
    public partial class ChatPageColor : UserControl
    {
        public event EventHandler PageBackGroundColorClicked;
        public event EventHandler PageBackGroundColorMouseEntered;
        public event EventHandler PageBackGroundColorMouseLeaved;
        private bool IsSelected;
        private Color pageBackGroundColor = Color.LightSeaGreen;
        public Color PageBackGroundColor
        {
            get
            {
                return pageBackGroundColor;
            }

            set
            {
                pageBackGroundColor = value;
                Invalidate();
            }
        }


        public bool IsSelected1
        {
            get => IsSelected;
            set
            {
                IsSelected = value;

                if (value) BorderGreenColor = DummyBorderGreenColor;
                else BorderGreenColor = Color.Empty;
                Invalidate();
            }
        }

        private Color BorderGreenColor = Color.Empty;

        private Color DummyBorderGreenColor = Color.FromArgb(27, 135, 85);

        public ChatPageColor()
        {
            InitializeComponent();
            MouseEnter += MouseEntered;
            MouseLeave += MouseLeaved;
            this.BackColor = Color.Empty;
            // Invalidate();
        }

        private void Clicked(object sender, EventArgs e)
        {
            if (IsSelected1) IsSelected1 = false;
            else IsSelected1 = true;
            PageBackGroundColorClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void MouseLeaved(object sender, EventArgs e)
        {
            if (!IsSelected)
            {
                BorderGreenColor = Color.Empty;
                Invalidate();
            }
            PageBackGroundColorMouseLeaved?.Invoke(sender, EventArgs.Empty);
        }

        private void MouseEntered(object sender, EventArgs e)
        {
            BorderGreenColor = DummyBorderGreenColor;
            Invalidate();
            PageBackGroundColorMouseEntered?.Invoke(sender, EventArgs.Empty);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen OuterBrush = new Pen(BorderGreenColor, 3))
            {
                GraphicsPath OuterPath = CreateRoundRectPath(new Rectangle(2, 2, Width - 5, Height - 5), 4);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(OuterBrush, OuterPath);
            }

            using (Brush OuterBrush = new SolidBrush(PageBackGroundColor))
            {
                GraphicsPath OuterPath = CreateRoundRectPath(new Rectangle(3, 3, Width - 7, Height - 7), 4);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillPath(OuterBrush, OuterPath);
            }
        }

        private GraphicsPath CreateRoundRectPath(Rectangle rect, int radius)
        {
            radius *= 2;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
