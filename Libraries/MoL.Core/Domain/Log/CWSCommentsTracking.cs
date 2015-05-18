using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Transactions;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Log
{
    public class CWSCommentsTracking:BaseEntity
    {
        public long FK_ChangeWorkerStatusRequestId { get; set; }
        public long? FK_UserId { get; set; }
        public int? Fk_ChangeWorkerStatusCommentTypeId { get; set; }
        public string Comment { get; set; }
        public DateTime? CommentDate { get; set; }

        public virtual ChangeWorkerStatusCommentType ChangeWorkerStatusCommentType
        {
            get
            {
                return (ChangeWorkerStatusCommentType)this.Fk_ChangeWorkerStatusCommentTypeId;
            }
            set
            {
                this.Fk_ChangeWorkerStatusCommentTypeId = (int)value;
            }
        }
        public virtual ChangeWorkStatusRequest ChangeWorkStatusRequest { get; set; }
        public virtual User User { get; set; }
    }
}
