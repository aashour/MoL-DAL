using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Log
{
    public class OracleTransactionLog : BaseEntity
    {
        public long FK_Online_Requests { get; set; }
        public int FK_ServiceId { get; set; }
        public long? FK_UserId { get; set; }
        public int Lab_Off { get; set; }
        public int Ser_YY { get; set; }
        public int Seq_No { get; set; }
        public long FK_EstablishmentId { get; set; }
        public string RepresentativeIdNo { get; set; }
        public int? TransactionStatus { get; set; }
        public string OracleResult { get; set; }
        public string Error { get; set; }
        public bool? isManPower { get; set; }
        public DateTime? TimeStamp { get; set; }

        public virtual Service Service
        {
            get
            {
                return (Service)this.FK_ServiceId;
            }
            set
            {
                this.FK_ServiceId = (int)value;
            }
        }
        public virtual Establishment Establishment { get; set; }
        public virtual User User { get; set; }
    }
}
