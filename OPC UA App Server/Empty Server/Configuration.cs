using System;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Opc.Ua.Server;

namespace Empty_Server
{   
    [DataContract(Namespace = Namespaces.Empty)]
    public class EmptyServerConfiguration
    {
        #region Constructors
        
        public EmptyServerConfiguration()
        {
            Initialize();
            
        }

        
        [OnDeserializing()]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

       
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region Private Members
        #endregion
    }
}
