using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Establishments.Enums;

namespace MoL.Core.Domain.Representitives
{
    public class EstablishmentCommissionerService : BaseEntity
    {
        public long FK_EstablishmentCommissionerId { get; set; }
        public int FK_ServiceId { get; set; }

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
        public virtual EstablishmentCommissioner EstablishmentCommissioner { get; set; }
    }
}
