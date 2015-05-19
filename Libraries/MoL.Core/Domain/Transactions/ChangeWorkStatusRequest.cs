using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Laborers.Enums;
using MoL.Core.Domain.Log;

namespace MoL.Core.Domain.Transactions
{
    public class ChangeWorkStatusRequest:BaseEntity
    {
        public long FK_laborId { get; set; }
        public long FK_SrvTransactionId { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public int FK_LaborerStatusServiceEndReasonId { get; set; }
        public int FK_CurrentLaborerStatusId { get; set; }
        public int FK_NewLaborerStatusId { get; set; }
        public System.DateTime CurrentLaborerStatusUpdateDate { get; set; }

        public virtual LaborerStatus CurrentLaborerStatus
        {
            get
            {
                return (LaborerStatus)this.FK_CurrentLaborerStatusId;
            }
            set
            {
                this.FK_CurrentLaborerStatusId = (int)value;
            }
        }
        public virtual LaborerStatus NewLaborerStatus
        {
            get
            {
                return (LaborerStatus)this.FK_NewLaborerStatusId;
            }
            set
            {
                this.FK_NewLaborerStatusId = (int)value;
            }
        }
        public virtual Laborer Laborer { get; set; }
        public virtual LaborerStatusServiceEndReason LaborerStatusServiceEndReason { get; set; }
        public virtual Srv_Transaction Srv_Transaction { get; set; }
        private ICollection<CWSCommentsTracking> _cWSCommentsTrackings { get; set; }
        public virtual ICollection<CWSCommentsTracking> CWSCommentsTrackings
        {
            get { return _cWSCommentsTrackings ?? (_cWSCommentsTrackings = new List<CWSCommentsTracking>()); }
            protected set { _cWSCommentsTrackings = value; }
        }
    }
}
