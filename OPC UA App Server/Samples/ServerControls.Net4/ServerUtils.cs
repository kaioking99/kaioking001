
using System;
using System.Drawing;

namespace Opc.Ua.Server.Controls
{
   
    public partial class ServerUtils
    {
       
        public static void HandleException(string caption, Exception e)
        {
            ExceptionDlg.Show(caption, e);
        }
      
        public static System.Drawing.Icon GetAppIcon()
       {
           try
           {
               return new Icon("App.ico");
           }
           catch (Exception)
           {
               return null;
           }
       }
    }
}
