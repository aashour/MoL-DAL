using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Domain.Representitives
{
    public class Agent : BaseEntity
    {
        public string AgentName { get; set; }
        public string IdNo { get; set; }
        public string IdSource { get; set; }
        public System.DateTime IdReleaseDate { get; set; }
        public int FK_CityId { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string ZipCode { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Fax { get; set; }
        public int? FK_CurrentLaborOffice { get; set; }
        public Nullable<long> SequenceNumber { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual City City { get; set; }
        public virtual LaborOffice LaborOffice { get; set; }
        private ICollection<EstablishmentAgent> _establishmentAgents { get; set; }

        public virtual ICollection<EstablishmentAgent> EstablishmentAgents
        {
            get { return _establishmentAgents ?? (_establishmentAgents = new List<EstablishmentAgent>()); }
            protected set { _establishmentAgents = value; }
        }
    }
}
