﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            chatSenter2.initialLocation = chatSenter2.Location;
        }

        private void ChatPage_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           // ChatApplicationDatabaseManager c = new ChatApplicationDatabaseManager();
            ChatApplicationDatabaseManager.DatabaseConnection();
        }
    }
}
