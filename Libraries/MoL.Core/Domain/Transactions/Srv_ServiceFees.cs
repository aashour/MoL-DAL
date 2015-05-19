using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoL.Core.Domain.Transactions
{
    public class Srv_ServiceFees : BaseEntity
    {
        public int Period { get; set; }
        public decimal Fees { get; set; }

        public virtual Srv_ServicesRequestType Srv_ServicesRequestType { get; set; }
    }

}
