using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Laborers;

namespace MoL.Core.Domain.Establishments
{
    public class CommissionerSOLaborer : BaseEntity
    {
        public long FK_LaborerId { get; set; }
        public string AuthorizationNumber { get; set; }
        public DateTime? AuthorizationStartDate { get; set; }
        public DateTime? AuthorizationEndDate { get; set; }
        public bool? StopFlag { get; set; }
        public string StopReason { get; set; }
        public int FK_ServiceOfficeID { get; set; }

        public virtual Laborer Laborer { get; set; }
        public virtual ServiceOffice ServiceOffice { get; set; }
    }
}
