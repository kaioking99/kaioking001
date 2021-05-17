using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using Opc.Ua;
using Opc.Ua.Server;
using Opc.Ua.Configuration;
using System.IO;


namespace Opc.Ua.Server.Controls
{
    public partial class ServerForm_Next : Form
    {
        #region Private Field
        private Button CurrentButton;
        private ApplicationInstance m_application;
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        #endregion
        #region Constructor
        public ServerForm_Next()
        {
            InitializeComponent();            
        }
        public ServerForm_Next(StandardServer server, ApplicationConfiguration configuration)
        {
            InitializeComponent();
            timer1.Enabled = true;
            m_server = server;
            m_configuration = configuration;
            this.statusCtrl1.Initialize(m_server, m_configuration);
            this.endpointCtrl1.Initialize(m_server, m_configuration, m_application);
            this.sessionCtrl1.Initialize(m_server, m_configuration);
            this.addressSpaceCtrl1.Initialize(m_server, m_configuration);
            this.usersCtrl1.Initialize(m_server, m_configuration);
            //    TrayIcon.Text = this.Text = m_configuration.ApplicationName;
            //    this.Icon = TrayIcon.Icon = ServerUtils.GetAppIcon();
        }


        /// <summary>
        /// Creates a form which displays the status for a UA server.
        /// </summary>
        public ServerForm_Next(ApplicationInstance application)
        {
            InitializeComponent();
            timer1.Enabled = true;
            m_application = application;
            m_server = application.Server as StandardServer;
            m_configuration = application.ApplicationConfiguration;
            this.statusCtrl1.Initialize(m_server, m_configuration);
           this.endpointCtrl1.Initialize(m_server, m_configuration, m_application);
            this.sessionCtrl1.Initialize(m_server, m_configuration);
            this.addressSpaceCtrl1.Initialize(m_server, m_configuration);
            this.usersCtrl1.Initialize(m_server, m_configuration);
            //    TrayIcon.Text = this.Text = m_configuration.ApplicationName;
            //    this.Icon = TrayIcon.Icon = ServerUtils.GetAppIcon();
        }
        #endregion
        #region Private Method
        private void ActiveButton(object BtnSender)
        {
            if (BtnSender != null)
            {
                if (CurrentButton != (Button)BtnSender)
                {
                    DisableButton();
                    CurrentButton = (Button)BtnSender;
                    CurrentButton.BackColor = Color.SteelBlue;
                    CurrentButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        #endregion

        #region Events Handler
        #endregion

        private void StatusBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            statusCtrl1.BringToFront();
        }

        private void EndpointsBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            endpointCtrl1.BringToFront();
        }

        private void SessionBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            sessionCtrl1.BringToFront();
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            usersCtrl1.BringToFront();
        }

        private void CertificateBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void AddressSpaceBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            addressSpaceCtrl1.BringToFront();
        }

        private void MonitorSimulateBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void ConnectionLogBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void ConfigurationBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void ServerForm_Next_Load(object sender, EventArgs e)
        {
            statusCtrl1.BringToFront();
            endpointCtrl1.SendToBack();
            sessionCtrl1.SendToBack();
            addressSpaceCtrl1.SendToBack();
            usersCtrl1.SendToBack();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ServerStt.Text = m_server.CurrentInstance.CurrentState.ToString();
                TimeStt.Text = String.Format("{0:HH:mm:ss}", DateTime.Now);
                IList<Session> sessions = m_server.CurrentInstance.SessionManager.GetSessions();
                IList<Subscription> subscriptions = m_server.CurrentInstance.SubscriptionManager.GetSubscriptions();
                
                SessionStt.Text = Convert.ToString(sessions.Count);
                SubcriptionStt.Text = subscriptions.Count.ToString();

            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }

        private void usersCtrl1_Load(object sender, EventArgs e)
        {

        }
    }
}
