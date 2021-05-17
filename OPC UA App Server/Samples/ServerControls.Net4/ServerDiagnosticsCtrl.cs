using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Opc.Ua.Server;

namespace Opc.Ua.Server.Controls
{  
    public partial class ServerDiagnosticsCtrl : UserControl
    {
        #region Constructors        
        public ServerDiagnosticsCtrl()
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
            UpdateTimerCTRL.Enabled = true;
            
            // add the urls to the drop down.
            UrlCB.Items.Clear();

            foreach (EndpointDescription endpoint in m_server.GetEndpoints())
            {
                if (UrlCB.FindStringExact(endpoint.EndpointUrl) == -1)
                {
                    UrlCB.Items.Add(endpoint.EndpointUrl);
                }
            }

            if (UrlCB.Items.Count > 0)
            {
                UrlCB.SelectedIndex = 0;
            }
        }
        #endregion

        #region Private Methods       
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
                    item.SubItems.Add(String.Format("{0:HH:mm:ss}", session.SessionDiagnostics.ClientLastContactTime.ToLocalTime()));

                    SessionsLV.Items.Add(item);
                }
            }

            // adjust 
            for (int ii = 0; ii < SessionsLV.Columns.Count; ii++)
            {
                SessionsLV.Columns[ii].Width = -2;
            }
        }
       
        private void UpdateSubscriptions()
        {
            SubscriptionsLV.Items.Clear();

            IList<Subscription> subscriptions = m_server.CurrentInstance.SubscriptionManager.GetSubscriptions();

            for (int ii = 0; ii < subscriptions.Count; ii++)
            {
                Subscription subscription = subscriptions[ii];

                ListViewItem item = new ListViewItem(subscription.Id.ToString());

                item.SubItems.Add(String.Format("{0}", (int)subscription.PublishingInterval));
                item.SubItems.Add(String.Format("{0}", subscription.MonitoredItemCount));

                lock (subscription.DiagnosticsLock)
                {
                    item.SubItems.Add(String.Format("{0}", subscription.Diagnostics.NextSequenceNumber));
                }

                SubscriptionsLV.Items.Add(item);
            }

            for (int ii = 0; ii < SubscriptionsLV.Columns.Count; ii++)
            {
                SubscriptionsLV.Columns[ii].Width = -2;
            }
        }
        #endregion

        #region Event Handlers       
        private void UpdateTimerCTRL_Tick(object sender, EventArgs e)
        {
            try
            {
                ServerStateLB.Text = m_server.CurrentInstance.CurrentState.ToString();
                ServerTimeLB.Text = String.Format("{0:HH:mm:ss}", DateTime.Now);
                UpdateSessions();
                sessionsLB.Text = Convert.ToString( SessionsLV.Items.Count );
                UpdateSubscriptions();
                subscriptionsLB.Text = Convert.ToString( SubscriptionsLV.Items.Count );
                int itemTotal = 0;
                for ( int i = 0; i < SubscriptionsLV.Items.Count; i++ )
                {
                    itemTotal += Convert.ToInt32( SubscriptionsLV.Items[i].SubItems[2].Text );
                }
                itemsLB.Text = Convert.ToString( itemTotal );
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }
        #endregion
    }
}
