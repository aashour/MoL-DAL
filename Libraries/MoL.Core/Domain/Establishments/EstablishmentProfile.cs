using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Lookups;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Establishments
{
    public class EstablishmentProfile : BaseEntity
    {
        public long FK_EstablishmentId { get; set; }
        public string Description { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int FK_CityId { get; set; }
        public string Website { get; set; }
        public System.DateTime LastModified { get; set; }
        public long FK_LastModifiedUser { get; set; }
        public System.DateTime Created { get; set; }
        public long FK_CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public string ActivationStatusChangeReason { get; set; }

        public virtual City City { get; set; }
        public virtual Establishment Establishment { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        private ICollection<JobVacancy> _jobVacancies { get; set; }
        public virtual ICollection<JobVacancy> JobVacancies
        {
            get { return _jobVacancies ?? (_jobVacancies = new List<JobVacancy>()); }
            protected set { _jobVacancies = value; }
        }
    }
}
