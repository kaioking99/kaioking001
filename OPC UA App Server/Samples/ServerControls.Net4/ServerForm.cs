using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using Opc.Ua;
using Opc.Ua.Configuration;
using System.IO;

namespace Opc.Ua.Server.Controls
{    
    public partial class ServerForm : Form
    {
        #region Constructors
        
        public ServerForm()
        {
            InitializeComponent();
        }        
        
        public ServerForm(StandardServer server, ApplicationConfiguration configuration)
        {
            InitializeComponent();

            m_server = server;
            m_configuration = configuration;
            this.ServerDiagnosticsCTRL.Initialize(m_server, m_configuration);
            TrayIcon.Text = this.Text = m_configuration.ApplicationName;
     
        }
       
        public ServerForm(ApplicationInstance application)
        {
            InitializeComponent();

            m_application = application;
            m_server = application.Server as StandardServer;
            m_configuration = application.ApplicationConfiguration;
            this.ServerDiagnosticsCTRL.Initialize(m_server, m_configuration);

            TrayIcon.Text = this.Text = m_configuration.ApplicationName; 
        }
        #endregion

        #region Private Fields
        private ApplicationInstance m_application;
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        #endregion

        #region Event Handlers
        private void ServerForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Server_ExitMI_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                m_server.Stop();
            }
            catch (Exception exception)
            {
                Utils.Trace(exception, "Error stopping server.");
            }
        }

        private void TrayIcon_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                TrayIcon.Text = String.Format(
                    "{0} [{1} {2:HH:mm:ss}]",
                    m_configuration.ApplicationName,
                    m_server.CurrentInstance.CurrentState,
                    DateTime.Now);
            }
            catch (Exception exception)
            {
                Utils.Trace(exception, "Error getting server status.");
            }
        }
        #endregion

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quit the application", "OPC UA", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start( Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + "WebHelp" + Path.DirectorySeparatorChar + "index.htm");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to launch help documentation. Error: " + ex.Message);
            }

        }
    }
}
