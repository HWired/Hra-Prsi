﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Client.Networking;

namespace Client
{
    public partial class Form1 : Form
    {
        SessionManager sessionManager;

        public Form1()
        {
            InitializeComponent();

            sessionManager = new SessionManager();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            sessionManager.CreateSession();
            SessionCodeInput.Text = SessionManager.sessionName;
        }

        private void JoinGameBtn_Click(object sender, EventArgs e)
        {
            string sessionName = SessionCodeInput.Text;
            sessionManager.JoinSession(sessionName);
        }

        private void GetStateBtn_Click(object sender, EventArgs e)
        {
            sessionManager.LoadState();
        }

        private void UpdateStateBtn_Click(object sender, EventArgs e)
        {
            sessionManager.SaveState();
        }
    }
}
