using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Transactions.Enums;

namespace MoL.Core.Domain.Transactions
{
    public partial class Srv_TransactionOwner : BaseEntity
    {
        public long FK_Service_TransactionId { get; set; }
        public long FK_MOL_UserId { get; set; }
        public int FK_Service_ServiceStatusId { get; set; }
        public System.DateTime CreationDate { get; set; }

        public virtual Srv_ServiceStatus ServiceStatus
        {
            get
            {
                return (Srv_ServiceStatus)this.FK_Service_ServiceStatusId;
            }
            set
            {
                this.FK_Service_ServiceStatusId = (int)value;
            }
        }

        public virtual Srv_Transaction Srv_Transaction { get; set; }
    }
}
