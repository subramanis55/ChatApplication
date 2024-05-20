using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication.UControl
{
    public partial class EditSheet : Form
    {
        public EventHandler<string> MessageSelected;
        public bool IsSelectedFile{
        set{
                OpenPanel.Visible = value;
                if (value)
                    Height += OpenPanel.Height;
                else
                    Height -= OpenPanel.Height;
        }
        get{
                return OpenPanel.Visible;
                
        }
        }
        public EditSheet()
        {
            InitializeComponent();
            LostFocus += EditSheetLostFocus;
            CopyPanel.MouseEnter += MouseEnterForPanels;
            DeletePanel.MouseEnter += MouseEnterForPanels;
            OpenPanel.MouseEnter += MouseEnterForPanels;
            OpenFile.MouseEnter += MouseEnterForPanels;
            CopyLabel.MouseEnter += MouseEnterForPanels;
            DeleteLabel.MouseEnter += MouseEnterForPanels;
            DeleteAllPanel.MouseEnter += MouseEnterForPanels;
            DeleteAllLabel.MouseEnter += MouseEnterForPanels;
            selectBtnPictureBox .MouseEnter+= MouseEnterForPanels;
            selectBtnLabel.MouseEnter+= MouseEnterForPanels;
            selectPanel.MouseEnter += MouseEnterForPanels;

            selectBtnPictureBox.MouseLeave += MouseLeaveForPanels;
            selectBtnLabel.MouseLeave += MouseLeaveForPanels;
            selectPanel.MouseLeave += MouseLeaveForPanels;

            CopyPanel.MouseLeave += MouseLeaveForPanels;
            DeletePanel.MouseLeave += MouseLeaveForPanels;
            CopyLabel.MouseLeave += MouseLeaveForPanels;
            DeleteLabel.MouseLeave += MouseLeaveForPanels;
            OpenPanel.MouseLeave += MouseLeaveForPanels;
            OpenFile.MouseLeave += MouseLeaveForPanels;
            DeleteAllPanel.MouseLeave += MouseLeaveForPanels;
            DeleteAllLabel.MouseLeave += MouseLeaveForPanels;

            


            CopyPanel.Click += CopyClicked;
            OpenPanel.Click += OpenClicked;
            DeletePanel.Click += DeleteClicked;
            DeleteAllPanel.Click += DeleteAllClicked;


            CopyLabel.Click += CopyClicked;
            DeleteLabel.Click += DeleteClicked;
            OpenFile.Click += OpenClicked;
            DeletePanel.Click += DeleteClicked;
            DeleteAllLabel.Click += DeleteAllClicked;

            CopyPicBox.Click += CopyClicked;
            DeletePicBox.Click += DeleteClicked;
            OpenFilePicBox.Click += OpenClicked;
            DeleteAllPicBox.Click += DeleteAllClicked;
        }

        private void SelectPanel_MouseEnter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditSheetLostFocus(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void OpenClicked(object sender, EventArgs e)
        {
            MessageSelected?.Invoke(sender, "Open");
        }

        private void CopyClicked(object sender, EventArgs e)
        {
            MessageSelected?.Invoke(sender, "Copy");
        }

        private void DeleteClicked(object sender, EventArgs e)
        {
            MessageSelected?.Invoke(sender, "Delete");
        }

        private void DeleteAllClicked(object sender, EventArgs e)
        {
            MessageSelected?.Invoke(sender, "DeleteAll");
        }
        private void MouseLeaveForPanels(object sender, EventArgs e)
        {
            try
            {
                Panel P = (Panel)sender;
                P.BackColor = Color.Empty;
            }
            catch { }
            try
            {
                Label L = (Label)sender;
                L.Parent.BackColor = Color.Empty;
            }
            catch { }
        }

        private void MouseEnterForPanels(object sender, EventArgs e)
        {
            try
            {
                Panel P = (Panel)sender;
                P.BackColor = Color.FromArgb(200, 200, 200);
            }
            catch { }
            try
            {
                Label L = (Label)sender;
                L.Parent.BackColor = Color.FromArgb(200, 200, 200);
            }
            catch { }
        }

      

        private void selectBtnClicked(object sender, EventArgs e)
        {
            MessageSelected?.Invoke(sender, "Select");
        }


    }
}
