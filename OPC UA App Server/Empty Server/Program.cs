using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using Opc.Ua;
using Opc.Ua.Server;
using Opc.Ua.Configuration;
using Opc.Ua.Server.Controls;

namespace Empty_Server
{
    static class Program
    {        
        [STAThread]
        static void Main()
        {
            // Initialize the user interface.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationInstance.MessageDlg = new ApplicationMessageDlg();
            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "EmptyServer";           
            try
            {
                // process and command line arguments.
                if (application.ProcessCommandLine())
                {
                    return;
                }

                // check if running as a service.
                if (!Environment.UserInteractive)
                {
                    application.StartAsService(new EmptyServer());
                    return;
                }
                // load the application configuration.
                application.LoadApplicationConfiguration(false).Wait();

                // check the application certificate.
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // start the server.
                application.Start(new EmptyServer()).Wait();

                // run the application interactively.
                Application.Run(new ServerForm_Next(application));
            }
            catch (Exception e)
            {
                ExceptionDlg.Show(application.ApplicationName, e);
                return;
            }
        }
    }    
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class NamespaceDoc
    {
    }
}
