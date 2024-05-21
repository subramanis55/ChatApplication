using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatApplication.Manager;
using ChatApplication.UForms;

namespace ChatApplication
{
    public partial class LoginForm : Form
    {
        private string dpPicturePath = "";
        public LoginForm()
        {
            InitializeComponent();
            //Theme Setup
            loginTopP.BackColor = SettingManager.PrimaryThemeColor;
            nextBtn.BackColor = SettingManager.PrimaryThemeColor;
            Resize += LoginFormResize;
            LoginFormResize(this, EventArgs.Empty);
            dpPictureU.OnClickDpPicturePathGet += ImagePathGet;
            nextBtn.Click += NextBtnClick;
            Load += LoginFormLoad;
            firstNameTB.TextChangedInvoke += FirstNameTBTextChanged;
            lastNameTB.TextChangedInvoke += LastNameTBTextChanged;
        }

        private void LastNameTBTextChanged(object sender, EventArgs e)
        {
            if (lastNameTB.TextBoxtext.Length > 16)
            {
                lastnameErrorLB.Visible = true;
                lastnameErrorLB.Text = "Lastname should be\n less  than 16 character";
            }
            else if (lastNameTB.TextBoxtext.Length == 0)
            {
                lastnameErrorLB.Visible = true;
                lastnameErrorLB.Text = "Enter the lastname";
            }
            else
            {
                lastnameErrorLB.Visible = false;
            }
        }

        private void FirstNameTBTextChanged(object sender, EventArgs e)
        {
            if (firstNameTB.TextBoxtext.Length > 16)
            {
                firstnameErrorLB.Visible = true;
                firstnameErrorLB.Text = "Firstname should be\n less than  16 character";
            }
            else if (firstNameTB.TextBoxtext.Length == 0)
            {
                firstnameErrorLB.Visible = true;
                firstnameErrorLB.Text = "Enter the firstname";
            }
            else
            {
                firstnameErrorLB.Visible = false;
            }
        }

        private void LoginFormLoad(object sender, EventArgs e)
        {
            ipAddressLB.Text += NetworkManager.PcHostName + " : " + NetworkManager.PcIpAddress;
            LoginFormResize(this, EventArgs.Empty);
        }
        private void ImagePathGet(object sender, string imagePath)
        {
            dpPicturePath = imagePath;
        }
      
        private void NextBtnClick(object sender, EventArgs e)
        {
            // contact create
            if (lastnameErrorLB.Visible == false && firstnameErrorLB.Visible == false && firstNameTB.TextBoxtext.Length > 0 && lastNameTB.TextBoxtext.Length > 0)
            {
                if (DatabaseManager.ChatApplicationServerConnection())
                {
                    ContactsManager.ContactCreate(new Contact(NetworkManager.PcMacAddress, NetworkManager.PcHostName, NetworkManager.PcIpAddress, firstNameTB.TextBoxtext, lastNameTB.TextBoxtext, FilesManager.ConvertImageToBase64(dpPicturePath), DateTime.Now, 0, false));
                    DatabaseManager.DataBaseTablesUpdateFromServer();
                    DatabaseManager.ChatApplicationLocalConnection();
                    ContactsManager.ContactManagerSetup();
                    GroupsManager.GroupsManagerSetUp();
                    if (DatabaseManager.Manager.IsConnected)
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageF messageF = new MessageF("Server Not Respond");
                    DialogResult dialogResult = messageF.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            if (firstNameTB.TextBoxtext.Length == 0)
            {
                firstnameErrorLB.Visible = true;
                firstnameErrorLB.Text = "Enter the firstname";
            }
            if (lastNameTB.TextBoxtext.Length == 0)
            {
                lastnameErrorLB.Visible = true;
                lastnameErrorLB.Text = "Enter the lastname";
            }
        }
        private void LoginFormResize(object sender, EventArgs e)
        {
            centerP.Location = new Point(Width / 2 - centerP.Width / 2, Height / 2 - centerP.Height / 2);
            firstNameTB.Location = new Point(centerP.Width / 2 - firstNameTB.Width / 2, firstNameTB.Location.Y);
            lastNameTB.Location = new Point(centerP.Width / 2 - lastNameTB.Width / 2, lastNameTB.Location.Y);
            ipAddressLB.Location = new Point(centerP.Width / 2 - ipAddressLB.Width / 2, ipAddressLB.Location.Y);
            dpPictureU.Location = new Point(centerP.Width / 2 - dpPictureU.Width / 2, dpPictureU.Location.Y);
            nextBtn.Location = new Point(centerP.Width / 2 - nextBtn.Width / 2, nextBtn.Location.Y);
            centerP.BringToFront();
        }
    }
}
