using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Transactions
{
    public class WorkPermit : BaseEntity
    {
        public long FK_Service_TransactionId { get; set; }
        public long FK_LaborId { get; set; }
        public int FK_Servcie_ServiceRequestTypeId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public string FK_WP_ReasonId { get; set; }
        public int Period { get; set; }
        public DateTime? LastPrintingDate { get; set; }
        public long? FK_PrintedBy { get; set; }
        public bool? IsSynchronized { get; set; }
        public int? NOT_ISSUED_WP { get; set; }
        public int? ExtraFees { get; set; }
        public int? PenalityExtraFees { get; set; }

        public virtual Laborer Laborer { get; set; }
        public virtual Laborer Laborer1 { get; set; }
        public virtual Srv_ServicesRequestType Srv_ServicesRequestType { get; set; }
        public virtual Srv_Transaction Srv_Transaction { get; set; }
        public virtual Srv_Transaction Srv_Transaction1 { get; set; }
        public virtual User User { get; set; }
    }
}
