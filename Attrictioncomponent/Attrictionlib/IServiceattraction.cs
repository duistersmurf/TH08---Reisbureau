using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Attrictionlib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceattraction" in both code and config file together.
    [ServiceContract]
    public interface IServiceattraction
    {
        [OperationContract]
        void GetAvailableAttractions();
        [OperationContract]
        void GetTickets();
        [OperationContract]
        bool IsTicketAvailable();
        [OperationContract]
        void BookAttraction();
    }
}
