using ChatApplication.Manager;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication.UForms
{
    public partial class SettingF : Form
    {
        public TransparentForm transparentFormObj;
        public event EventHandler<Color> OnHoverChatPageColorChange;
        public event EventHandler OnLeaveChatPageColorChange;
        public event EventHandler OnClickChatPageColorSelect;
        public event EventHandler OnClickDeleteAllTheMessage;
        public Contact Contact
        {
            set
            {
                firstNameTB.Text = value.FirstName;
                lastNameTB.Text = value.LastName;
                ProfileImagePath = value.DpPicture;
            }
        }
        public string ProfileImagePath
        {
            set
            {
                if (dpPictureU.Image != null)
                    dpPictureU.Image.Dispose();
                try
                {
                    if (value != "File Not Found")
                    {

                        dpPictureU.Image = Image.FromFile(value);
                    }
                    else
                        dpPictureU.Image = Properties.Resources.profile_user;
                }
                catch
                {
                    dpPictureU.Image = Properties.Resources.profile_user;
                }
            }

        }
        public bool IsProfilePageSelected
        {
            set
            {
                settingMenuControl.IsProfileBtnSelected = value;
            }
        }
        public SettingF()
        {
            InitializeComponent();
            dpPictureU.EditBtnVisible = true;
            KeyPreview = true;
            KeyDown += FormKeyDown;
            Disposed += SettingFDisposed;
            toggleButton1.Value = SettingManager.IsMuteTheMessageNotification;
            toggleButton1.ToggleOrNot += OnClickMuteMessageNotificationBtn;
            firstNameTB.BorderColor = SettingManager.PrimaryThemeColor;
            lastNameTB.BorderColor = SettingManager.PrimaryThemeColor;
            SettingManager.ThemeSetUpInvoke += ThemeSetUpe;
            themeCB.SelectionLength = 0;
            themeCB.DataSource = SettingManager.ThemesNameList;
            themeCB.SelectedIndex = SettingManager.ThemeNumber;
            themeCB.SelectedIndexChanged += themeCBSelectedIndexChanged;
            settingMainTabControl.ItemSize = new Size(0, 1);
            this.Contact = ContactsManager.PCContact;
            Load += SettingFLoad;
            settingMenuControl.OnClickAboutBtn += SettingMenuControlOnClickAboutBtn;
            settingMenuControl.OnClickAccountBtn += SettingMenuControlOnClickAccountBtn;
            settingMenuControl.OnClickPersonalizationBtn += SettingMenuControlOnClickPersonalizationBtn;
            settingMenuControl.OnClickProfileBtn += SettingMenuControlOnClickProfileBtn;
            settingMenuControl.OnClickThemeBtn += SettingMenuControlOnClickThemeBtn;
            firstNameTBEditBtn.Click += FirstNameTBEditBtnClick;
            lastNameTBEditBtn.Click += LastNameTBEditBtnClick;
            deleteAllMessagesBtn.Click += DeleteAllMessagesBtnClick;
            firstNameTB.KeyPressDown += FirstNameTBKeyDown;
            lastNameTB.KeyPressDown += LastNameTBKeyDown;
            dpPictureU.OnClickDpPicturePathGet += dpPictureUOnClickDpPicturePathGet;
            FeaturesMethods.AltTabFormShowStop(this.Handle);
            firstNameTB.Textchanged += FirstNameTB_Textchanged;
            lastNameTB.Textchanged += LastNameTB_Textchanged;
        }

        private void LastNameTB_Textchanged(object sender, EventArgs e)
        {
            if (lastNameTB.Text.Length > 16)
            {
                lastnameErrorLB.Visible = true;
                lastnameErrorLB.Text = "Lastname should be\nless  than 16 character";
            }
            else if (lastNameTB.Text.Length == 0)
            {
                lastnameErrorLB.Visible = true;
                lastnameErrorLB.Text = "Enter the lastname";
            }
            else
            {
                lastnameErrorLB.Visible = false;
            }
        }

        private void FirstNameTB_Textchanged(object sender, EventArgs e)
        {
            if (firstNameTB.Text.Length > 16)
            {
                firstnameErrorLB.Visible = true;
                firstnameErrorLB.Text = "Firstname should be\nless than  16 character";
            }
            else if (firstNameTB.Text.Length == 0)
            {
                firstnameErrorLB.Visible = true;
                firstnameErrorLB.Text = "Enter the firstname";
            }
            else
            {
                firstnameErrorLB.Visible = false;
            }
        }

        private void SettingFDisposed(object sender, EventArgs e)
        {
            if (dpPictureU.Image != null)
                dpPictureU.Image.Dispose();
        }

        private void ThemeSetUpe(object sender, EventArgs e)
        {
            firstNameTB.BorderColor = SettingManager.PrimaryThemeColor;
            lastNameTB.BorderColor = SettingManager.PrimaryThemeColor;
        }
        private void OnClickMuteMessageNotificationBtn(object sender,bool e)
        {
            SettingManager.ChangeMuteMessageNotification(e);
        }

        private void dpPictureUOnClickDpPicturePathGet(object sender, string dpPicturePath)
        {
            try
            {
             
                if (DatabaseManager.ChatApplicationServerConnection())
                {
                    string imageStringFormat = FilesManager.ConvertImageToBase64(dpPicturePath);
                    ContactsManager.ChangeContactDppicture(ContactsManager.PCContact.HostName, imageStringFormat);
                    DatabaseManager.ChatApplicationLocalConnection();
                    ContactsManager.ChangeContactDppicture(ContactsManager.PCContact.HostName, imageStringFormat);
                }
                else
                    SettingManager.notificationThrowManager.CreateNotification("Server not respond", NotificationType.Information);
            }
            catch
            {
                SettingManager.notificationThrowManager.CreateNotification("Server not respond", NotificationType.Information);
            }
        }

        private void LastNameTBEditBtnClick(object sender, EventArgs e)
        {
            lastNameTB.Enabled = true;
            lastNameTBEditBtn.Visible = false;
        }

        private void FirstNameTBEditBtnClick(object sender, EventArgs e)
        {
            firstNameTB.Enabled = true;
            firstNameTBEditBtn.Visible = false;

        }

        private void SettingFLoad(object sender, EventArgs e)
        {
            label8.Focus();
            chatWallPaperColorChangeU.OnHoverChatPageColorGet += OnHoverChatPageColorChange;
            chatWallPaperColorChangeU.OnLeaveChatPageColorChange += OnLeaveChatPageColorChange;
            chatWallPaperColorChangeU.OnClickChatPageColorGetSelect += ChatWallPaperColorChangeUOnClickChatPageColorGetSelect;
        }

        private void ChatWallPaperColorChangeUOnClickChatPageColorGetSelect(object sender, Color Color)
        {
            SettingManager.ChangeChatPageBackGroundColor(Color);
            OnClickChatPageColorSelect?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteAllMessagesBtnClick(object sender, EventArgs e)
        {
            TransparentForm transparentForm = new TransparentForm();
            MessageConfirmForm messageConfirmForm = new MessageConfirmForm("Do you want Delete All the messages from storage?");
            transparentForm.Show();
            transparentForm.Opacity = 0.1;

            messageConfirmForm.StartPosition = FormStartPosition.CenterScreen;
            if (messageConfirmForm.ShowDialog() == DialogResult.Yes)
            {
                MessagesManager.DeleteAllMessagesInDataBase();
            }
            messageConfirmForm.Dispose();
            transparentForm.Hide();
            OnClickDeleteAllTheMessage?.Invoke(this, EventArgs.Empty);
        }

        private void SettingMenuControlOnClickPersonalizationBtn(object sender, EventArgs e)
        {
            settingMainTabControl.SelectedTab = personalizationPage;
        }
        private void SettingMenuControlOnClickProfileBtn(object sender, EventArgs e)
        {
            settingMainTabControl.SelectedTab = profilePage;
        }
        private void SettingMenuControlOnClickAccountBtn(object sender, EventArgs e)
        {
            settingMainTabControl.SelectedTab = accountPage;
        }

        private void SettingMenuControlOnClickAboutBtn(object sender, EventArgs e)
        {
            settingMainTabControl.SelectedTab = aboutPage;
        }
        private void SettingMenuControlOnClickThemeBtn(object sender, EventArgs e)
        {
            settingMainTabControl.SelectedTab = ThemePage;
        }
        private void FirstNameTBKeyDown(object sender, KeyEventArgs e)
        {
            if (firstNameTB.Enabled == true && e.KeyCode == Keys.Enter&& firstnameErrorLB.Visible == false && firstNameTB.Text.Length > 0)
            {
                firstNameTBEditBtn.Visible = true;
                firstNameTB.Enabled = false;
                if (DatabaseManager.ChatApplicationServerConnection())
                {
                    ContactsManager.ChangeContactFirstName(NetworkManager.PcHostName, firstNameTB.Text);
                    DatabaseManager.ChatApplicationLocalConnection();
                    ContactsManager.ChangeContactFirstName(NetworkManager.PcHostName, firstNameTB.Text);
                    ContactsManager.ContactManagerSetup();
                }
                else
                {
                    SettingManager.notificationThrowManager.CreateNotification("Server not respond", NotificationType.Information);
                }
            }
        }


        private void LastNameTBKeyDown(object sender, KeyEventArgs e)
        {
            if (lastNameTB.Enabled == true && e.KeyCode == Keys.Enter&& lastnameErrorLB.Visible == false && lastNameTB.Text.Length > 0)
            {
                lastNameTBEditBtn.Visible = true;
                lastNameTB.Enabled = false;
                if (DatabaseManager.ChatApplicationServerConnection())
                {
                    ContactsManager.ChangeContactLastName(NetworkManager.PcHostName, lastNameTB.Text);
                    DatabaseManager.ChatApplicationLocalConnection();
                    ContactsManager.ChangeContactLastName(NetworkManager.PcHostName, lastNameTB.Text);
                    ContactsManager.ContactManagerSetup();
                }
                else
                {
                    SettingManager.notificationThrowManager.CreateNotification("Server not respond", NotificationType.Information);
                  
                }
            }
        }

        private void personalizationPage_Click(object sender, EventArgs e)
        {

        }

        private void themeCBSelectedIndexChanged(object sender, EventArgs e)
        {
            if (themeCB.SelectedIndex > -1 && themeCB.SelectedIndex != SettingManager.ThemeNumber)
            {
                SettingManager.ChangeTheme(themeCB.SelectedIndex);
                SettingManager.ThemeSetUP();
            }
            label8.Focus();

        }
        private void themeCBDropDownStyleChanged(object sender, EventArgs e)
        {
            label8.Focus();
            themeCB.Select(0, 0);
        }
        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers & Keys.Alt) == Keys.Alt)
            {
                if (transparentFormObj != null)
                    transparentFormObj.Dispose();
            }
        }
    }
}
