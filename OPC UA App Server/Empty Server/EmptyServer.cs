using System;
using System.Collections.Generic;
using System.Text;
using Opc.Ua;
using Opc.Ua.Server;


namespace Empty_Server
 {  //khai bao server 
    public partial class EmptyServer : StandardServer
    {
        #region Overridden Methods       
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating the Node Managers.");
            List<INodeManager> nodeManagers = new List<INodeManager>();
            //tao node theo danh sach
            nodeManagers.Add(new EmptyNodeManager(server, configuration));
            //tao cac node chay rieng boi server
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }
        //cung cap mot so thong tin cua server
        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties();

            properties.ManufacturerName = "OPC Foundation";
            properties.ProductName = "Empty Server";
            properties.ProductUri = "http://opcfoundation.org/EmptyServer/v1.0";
            properties.SoftwareVersion = Utils.GetAssemblySoftwareVersion();
            properties.BuildNumber = Utils.GetAssemblyBuildNumber();
            properties.BuildDate = Utils.GetAssemblyTimestamp();         

            return properties;
        }
        #endregion
    }
}
