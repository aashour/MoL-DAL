using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoL.Core.Domain.Establishments
{
    public class EstablishmentAgent : BaseEntity
    {

        public int FK_AgentTypeId { get; set; }
        public long? FK_EstablishmentId { get; set; }
        public long? FK_UnifiedNumberId { get; set; }
        public int FK_AgentId { get; set; }
        public string AgencyNo { get; set; }
        public string AgencySource { get; set; }
        public System.DateTime AgencyReleaseDate { get; set; }
        public DateTime? AgencyEndDate { get; set; }
        public string AgencyDescription { get; set; }
        public bool? StopAgency { get; set; }
        public DateTime? StopAgencyDate { get; set; }
        public string StopAgencyReason { get; set; }
        public bool? IsVerified { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual AgentType AgentType
        {
            get
            {
                return (AgentType)this.FK_AgentId;
            }
            set
            {
                this.FK_AgentId = (int)value;
            }
        }
        public virtual Agent Agent { get; set; }
        public virtual Establishment Establishment { get; set; }
        public virtual UnifiedNumber UnifiedNumber { get; set; }
       
        private ICollection<EstablishmentAgentService> _establishmentAgentServices { get; set; }

        public virtual ICollection<EstablishmentAgentService> EstablishmentAgentServices
        {
            get { return _establishmentAgentServices ?? (_establishmentAgentServices = new List<EstablishmentAgentService>()); }
            protected set { _establishmentAgentServices = value; }
        }
 
    }
}
