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
    public partial class ChatPageTitleBar : UserControl
    {
        public event EventHandler OnProfilePictureClick;

        public ChatPageTitleBar()
        {
            InitializeComponent();
        }

        private void ProfilePictureClick(object sender, EventArgs e)
        {
            OnProfilePictureClick?.Invoke(this, EventArgs.Empty);
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            Point loc = new Point(Cursor.Position.X, Cursor.Position.Y);
        }
    }
}
