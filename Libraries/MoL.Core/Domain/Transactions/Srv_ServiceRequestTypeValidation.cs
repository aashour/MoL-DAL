using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Transactions.Enums;

namespace MoL.Core.Domain.Transactions
{
    public class Srv_ServiceRequestTypeValidation : BaseEntity
    {
        public int FK_Service_ValidationId { get; set; }
        public int FK_Servcie_ServiceRequestTypeId { get; set; }

        public virtual Srv_Validation Srv_Validation
        {
            get
            {
                return (Srv_Validation)this.FK_Service_ValidationId;
            }
            set
            {
                this.FK_Service_ValidationId = (int)value;
            }
        }
        public virtual Srv_ServicesRequestType Srv_ServicesRequestType { get; set; }
    }
}
