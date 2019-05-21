using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BLLWcfServiceLibrary1.Contracts
{
    [ServiceContract]
    interface IAutorizationContract
    {
        [OperationContract]
        bool Register();
        [OperationContract]
        bool Login();
    }
}
