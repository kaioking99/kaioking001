using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Server;
using Opc.Ua.Configuration;

namespace Opc.Ua.Server.Controls.Function_Form
{
    public partial class SessionCtrl : UserControl
    {
        #region Constructor
        public SessionCtrl()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Fields
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        #endregion

        #region Public Interface
        public void Initialize(StandardServer server, ApplicationConfiguration configuration)
        {
            m_server = server;
            m_configuration = configuration;
            UpdateSessions();
            UpdateTimerCtrl.Enabled = true;
            SessionsLV.Enabled = true;

            
        }
        #endregion

        #region Private Method
        private void UpdateSessions()
        {
            SessionsLV.Items.Clear();

            IList<Session> sessions = m_server.CurrentInstance.SessionManager.GetSessions();

            for (int ii = 0; ii < sessions.Count; ii++)
            {
                Session session = sessions[ii];
                
                lock (session.DiagnosticsLock)
                {
                    ListViewItem item = new ListViewItem(session.SessionDiagnostics.SessionName);

                    if (session.Identity != null)
                    {
                        item.SubItems.Add(session.Identity.DisplayName);
                    }
                    else
                    {
                        item.SubItems.Add(String.Empty);
                    }

                    item.SubItems.Add(String.Format("{0}", session.Id));
                    item.SubItems.Add(session.SessionDiagnostics.ActualSessionTimeout.ToString());
                    item.SubItems.Add(String.Format("{0:HH:mm:ss}", session.SessionDiagnostics.ClientLastContactTime.ToLocalTime()));
                    item.SubItems.Add(session.Activated.ToString());
                    SessionsLV.Items.Add(item);
                }
            }

            // adjust 
            for (int ii = 0; ii < SessionsLV.Columns.Count; ii++)
            {
                SessionsLV.Columns[ii].Width = -2;
            }
        }

        #endregion

        #region Event Handlers

        private void UpdateTimerCtrl_Tick(object sender, EventArgs e)
        {
            try
            {
                UpdateSessions();
                SessionCountLB.Text = Convert.ToString(SessionsLV.Items.Count);

            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }

        }

        #endregion

        
    }
}
