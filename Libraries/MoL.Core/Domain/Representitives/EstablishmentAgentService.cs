using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Establishments.Enums;

namespace MoL.Core.Domain.Representitives
{
    public class EstablishmentAgentService : BaseEntity
    {
        public long FK_EstablishmentAgentId { get; set; }
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
        private EstablishmentAgent _establishmentAgent { get; set; }

        public virtual ICollection<EstablishmentAgent> _establishmentAgents
        {
            get { return _establishmentAgents ?? (_establishmentAgents = new List<EstablishmentAgent>()); }
            protected set { _establishmentAgents = value; }
        }
    }
}
