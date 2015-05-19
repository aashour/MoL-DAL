using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Log.Enums;

namespace MoL.Core.Domain.Log
{
    public class AuditTrailProperty : BaseEntity
    {
        public string Property_Name { get; set; }
        public long Type_Id { get; set; }
        public string Property_Type { get; set; }

        private ICollection<AuditTrailInfo> _auditTrailInfos { get; set; }
        public virtual ICollection<AuditTrailInfo> AuditTrailInfos
        {
            get { return _auditTrailInfos ?? (_auditTrailInfos = new List<AuditTrailInfo>()); }
            protected set { _auditTrailInfos = value; }
        }

        public virtual AuditTrailType AuditTrailType
        {
            get
            {
                return (AuditTrailType)this.Type_Id;
            }
            set
            {
                this.Type_Id = (int)value;
            }
        }
    }
}
