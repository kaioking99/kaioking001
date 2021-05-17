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
using Opc.Ua.Security;
using Opc.Ua.Configuration;

namespace Opc.Ua.Server.Controls.Function_Form
{
    public partial class EndpointCtrl : UserControl
    {
        #region Private Field
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        private ApplicationInstance m_application;

        public ServerSecurityPolicy Policy { get; private set; }
        #endregion
        #region Constructor
        public EndpointCtrl()
        {
            InitializeComponent();
        }
        #endregion

        #region Public Interface       
        public void Initialize(StandardServer server, ApplicationConfiguration configuration, ApplicationInstance application)
        {
            m_server = server;
            m_configuration = configuration;
            m_application = application;
            ComboBox adlist = new ComboBox();
            foreach (EndpointDescription endpoint in m_server.GetEndpoints())
            {
                if (adlist.FindStringExact(endpoint.EndpointUrl) == -1)
                {
                    adlist.Items.Add(endpoint.EndpointUrl);
                }
            }
            TCP_Adresss_Label.Text = "(" + adlist.Items[0].ToString() + ")";
         //   if (adlist.Items[1] != null)
        //    {
        //        HTTPS_Address_Label.Text = "(" + adlist.Items[1].ToString() + ")";
        //        HTTPS_AddressTB.Text = adlist.Items[1].ToString();
        //    }
            UA_AddressTB.Text = adlist.Items[0].ToString();
            
            CheckPolicies(m_configuration);
//           m_configuration.ServerConfiguration.BaseAddresses.
        }
        #endregion

        #region Methods
        private void CheckPolicies(ApplicationConfiguration configuration)
        {
            try
            {
                foreach (ServerSecurityPolicy policy in configuration.ServerConfiguration.SecurityPolicies)
                {
                    if (policy.SecurityMode == MessageSecurityMode.None) UA_SM_NoneCB.Checked = true;
                    if (policy.SecurityMode == MessageSecurityMode.Sign) UA_SM_SignCB.Checked = true;
                    if (policy.SecurityMode == MessageSecurityMode.SignAndEncrypt) UA_SM_Sign_EnCB.Checked = true;
                    if (policy.SecurityPolicyUri == SecurityPolicies.Basic128Rsa15) Basic128Rsa15_CB.Checked = true;
                    if (policy.SecurityPolicyUri == SecurityPolicies.Basic256) Basic256_CB.Checked = true;
                    if (policy.SecurityPolicyUri == SecurityPolicies.Basic256Sha256) Basic256Sha256_CB.Checked = true;
                }
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }
        private void CheckSecurity()
        {
            try
            {

                ServerSecurityPolicy policy = new ServerSecurityPolicy();
                if (UA_SM_NoneCB.Checked)
                {
                    policy = CreateSecurityPolicy(0, 0);
                    Addpolicies(m_configuration, policy);
                }
                else
                {
                    policy = CreateSecurityPolicy(0, 0);
                    DeletePolicies(m_configuration, policy);
                };
                if ((UA_SM_SignCB.Checked)&&(Basic128Rsa15_CB.Checked))
                {
                    policy = CreateSecurityPolicy(1, 1);
                    Addpolicies(m_configuration, policy);
                }
                else
                {
                    policy = CreateSecurityPolicy(1, 1);
                    DeletePolicies(m_configuration, policy);
                }
                if ((UA_SM_Sign_EnCB.Checked)&&(Basic256Sha256_CB.Checked))
                {
                    policy = CreateSecurityPolicy(2, 3);
                    Addpolicies(m_configuration, policy);
                }
                else
                {
                    policy = CreateSecurityPolicy(2, 3);
                    DeletePolicies(m_configuration, policy);
                }                
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }
        private void Addpolicies(ApplicationConfiguration configuration, ServerSecurityPolicy polici)
        {
            try
            {
                int i = 0;
                foreach (ServerSecurityPolicy policy in configuration.ServerConfiguration.SecurityPolicies)
                {
                    if (polici == policy) i++;
                }
                if (i == 0) configuration.ServerConfiguration.SecurityPolicies.Add(polici);
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }
        private void DeletePolicies(ApplicationConfiguration configuration, ServerSecurityPolicy polici)
        {
            try
            {
                int i = 0;
                foreach (ServerSecurityPolicy policy in configuration.ServerConfiguration.SecurityPolicies)
                {
                    if (polici == policy) configuration.ServerConfiguration.SecurityPolicies.Add(policy);
                    break;
                }
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }

        private ServerSecurityPolicy CreateSecurityPolicy(byte MessageMode, byte PolicyNumber)
        {
            try
            {
                ServerSecurityPolicy Policy = new ServerSecurityPolicy();
                switch (MessageMode)
                {
                    case 0:
                        Policy.SecurityMode = MessageSecurityMode.None;
                        break;
                    case 1:
                        Policy.SecurityMode = MessageSecurityMode.Sign;
                        break;
                    case 2:
                        Policy.SecurityMode = MessageSecurityMode.SignAndEncrypt;
                        break;
                    default:
                        Policy.SecurityMode = MessageSecurityMode.Invalid;
                        break;
                }
                switch (PolicyNumber)
                {
                    case 0:
                        Policy.SecurityPolicyUri = SecurityPolicies.None;
                        break;
                    case 1:
                        Policy.SecurityPolicyUri = SecurityPolicies.Basic128Rsa15;
                        break;
                    case 2:
                        Policy.SecurityPolicyUri = SecurityPolicies.Basic256;
                        break;
                    case 3:
                        Policy.SecurityPolicyUri = SecurityPolicies.Basic256Sha256;
                        break;
                }                
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
            return Policy;
        }

        #endregion

        #region Event Hanlder

        #endregion

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CheckSecurity(); 
              //  m_configuration.SaveToFile(m_application.ConfigSectionName + ".Config.xml");
              //  m_application.LoadApplicationConfiguration(false);
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }
    }
}
