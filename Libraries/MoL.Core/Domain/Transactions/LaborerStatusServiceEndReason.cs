using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Domain.Transactions
{
    public class LaborerStatusServiceEndReason:BaseEntity
    {
        public int FK_LaborerStatusId { get; set; }
        public int FK_ServiceEndReasonId { get; set; }

        public virtual LaborerStatus LaborerStatus
        {
            get
            {
                return (LaborerStatus)this.FK_LaborerStatusId;
            }
            set
            {
                this.FK_LaborerStatusId = (int)value;
            }
        }
        public virtual ServiceEndReason ServiceEndReason { get; set; }
        private ICollection<ChangeWorkStatusRequest> _changeWorkStatusRequests { get; set; }
        public virtual ICollection<ChangeWorkStatusRequest> ChangeWorkStatusRequests
        {
            get { return _changeWorkStatusRequests ?? (_changeWorkStatusRequests = new List<ChangeWorkStatusRequest>()); }
            protected set { _changeWorkStatusRequests = value; }
        }

    }
}
