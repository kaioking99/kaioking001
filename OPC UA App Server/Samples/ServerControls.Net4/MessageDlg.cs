﻿using System.Threading.Tasks;
using Opc.Ua.Configuration;
using System.Windows.Forms;

namespace Opc.Ua.Server.Controls
{
    public class ApplicationMessageDlg : IApplicationMessageDlg
    {
        private string message = string.Empty;
        private MessageBoxButtons buttons = MessageBoxButtons.OK;

        public override void Message(string text, bool ask)
        {
            message = text;

            if (ask)
            {
                buttons = MessageBoxButtons.YesNo;
            }
            else
            {
                buttons = MessageBoxButtons.OK;
            }
        }

        public override async Task<bool> ShowAsync()
        {
            DialogResult result = MessageBox.Show(message, "OPC UA", buttons);
            return await Task.FromResult((result == DialogResult.OK) || (result == DialogResult.Yes));
        }
    }
}

