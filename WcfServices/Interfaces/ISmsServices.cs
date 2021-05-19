using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApp.WcfServices
{
    [ServiceContract]
    public interface ISmsServices
    {
        [OperationContract]
        string DoWork(string name);
    }
}
