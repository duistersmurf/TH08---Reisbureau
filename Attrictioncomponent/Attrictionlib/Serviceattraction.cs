using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Attrictionlib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Serviceattraction" in both code and config file together.
    public class Serviceattraction : IServiceattraction
    {
        public void GetAvailableAttractions()
        {
        }
        public void GetTickets()
        {
        }
        public bool IsTicketAvailable()
        {
            return true;
        }
        public void BookAttraction()
        {
        }
    }
}
