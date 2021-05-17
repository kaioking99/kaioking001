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
using Opc.Ua.Security;

namespace Opc.Ua.Server.Controls.Function_Form
{
    public partial class UsersCtrl : UserControl
    {
        #region Constructor
        public UsersCtrl()
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
            User_PasswordLV.Enabled = true;
            User_PasswordLV.FullRowSelect = true;
            CertificateKeyLV.Enabled = true;
            CertificateKeyLV.FullRowSelect = true;
            AnonymousCkB.Checked = false;
            UserPassCkB.Checked = false;
            CertificateCkb.Checked = false;
            foreach (UserTokenPolicy userToken in m_configuration.ServerConfiguration.UserTokenPolicies)
            {
                if (userToken.TokenType == UserTokenType.Anonymous) AnonymousCkB.Checked = true;
                if (userToken.TokenType == UserTokenType.UserName) UserPassCkB.Checked = true;
                if (userToken.TokenType == UserTokenType.Certificate) CertificateCkb.Checked = true;
            }
        }
        #endregion

        #region Private Methods

        private void ActiveTokenPolicy()
        {
            if (AnonymousCkB.Checked) AddTokenPolicy(0);
            else DeleteTokenPolicy(0);
            if (UserPassCkB.Checked) AddTokenPolicy(1);
            else DeleteTokenPolicy(1);
            if (CertificateCkb.Checked) AddTokenPolicy(2);
            else DeleteTokenPolicy(2);
        }
        
        private void AddTokenPolicy(int number)
        {
            UserTokenPolicy userTokenPolicy = new UserTokenPolicy();
            switch (number)
            {
                case 0:
                    userTokenPolicy.TokenType = UserTokenType.Anonymous;                                                                  
                    break;
                case 1:
                    userTokenPolicy.TokenType = UserTokenType.UserName;
                    break;
                case 2:
                    userTokenPolicy.TokenType = UserTokenType.Certificate;
                    break;
                default:
                    userTokenPolicy.TokenType = UserTokenType.Anonymous;
                    break;
            }
            userTokenPolicy.PolicyId = userTokenPolicy.TokenType.ToString();
            int i = 0;
            foreach (UserTokenPolicy userToken in m_configuration.ServerConfiguration.UserTokenPolicies)
            {
                if (userTokenPolicy.TokenType == userToken.TokenType)
                    i++;
            }
            if (i == 0) m_configuration.ServerConfiguration.UserTokenPolicies.Add(userTokenPolicy);
        }
        private void DeleteTokenPolicy(int number)
        {
            UserTokenPolicy userTokenPolicy = new UserTokenPolicy();
            switch (number)
            {
                case 0:
                    userTokenPolicy.TokenType = UserTokenType.Anonymous;
                    break;
                case 1:
                    userTokenPolicy.TokenType = UserTokenType.UserName;
                    break;
                case 2:
                    userTokenPolicy.TokenType = UserTokenType.Certificate;
                    break;
                default:
                    userTokenPolicy.TokenType = UserTokenType.Anonymous;
                    break;
            }
            foreach (UserTokenPolicy userToken in m_configuration.ServerConfiguration.UserTokenPolicies)
            {
                if (userTokenPolicy.TokenType == userToken.TokenType)
                    m_configuration.ServerConfiguration.UserTokenPolicies.Remove(userToken);
                break;
            }
        }
            
        private void AddUser(string name, string password)
        {
            UserNameIdentityToken user = new UserNameIdentityToken();
            user.UserName = name;
            user.DecryptedPassword = password;            
         //   m_server.CurrentInstance
        }

        #endregion

        #region Events Handler
        
        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            ActiveTokenPolicy();
        }
        #endregion
    }
}
