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
    public partial class StatusCtrl : UserControl
    {
        #region Constructor
        public StatusCtrl()
        {
            InitializeComponent();
        }
        #endregion
        #region Private Field
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        #endregion
        #region Public Interface
        /// <summary>
        /// Creates a form which displays the status for a UA server.
        /// </summary>
        /// <param name="server">The server displayed in the form.</param>
        /// <param name="configuration">The configuration used to initialize the server.</param>
        public void Initialize(StandardServer server, ApplicationConfiguration configuration)
        {
            m_server = server;
            m_configuration = configuration;
            UpdateTimerCtrl.Enabled = true;
            ComboBox adlist = new ComboBox();
            foreach (EndpointDescription endpoint in m_server.GetEndpoints())
            {
                if (adlist.FindStringExact(endpoint.EndpointUrl) == -1)
                {
                    adlist.Items.Add(endpoint.EndpointUrl);
                }
            }
            TCP_Adresss_Label.Text = adlist.Items[0].ToString();
         //   if (adlist.Items[1] != null) HTTPS_Address_Label.Text = adlist.Items[1].ToString();
            StartingTimeLabel.Text = String.Format("{0:HH:mm:ss dd/MM/yyyy}", DateTime.Now);
        }
        #endregion

        #region Private Method

        #endregion

        #region Event Handlers

        private void UpdateTimerCtrl_Tick(object sender, EventArgs e)
        {
            StatusLabel.Text = m_server.CurrentInstance.CurrentState.ToString();
            CurrentTimeLabel.Text = String.Format("{0:HH:mm:ss dd/MM/yyyy}", DateTime.Now);
        }
        #endregion

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
