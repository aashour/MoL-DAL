using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Representitives;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Lookups
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        private ICollection<Agent> _agents { get; set; }
        public virtual ICollection<Agent> Agents
        {
            get { return _agents ?? (_agents = new List<Agent>()); }
            protected set { _agents = value; }
        }
        private ICollection<EstablishmentProfile> _establishmentProfiles { get; set; }
        public virtual ICollection<EstablishmentProfile> EstablishmentProfiles
        {
            get { return _establishmentProfiles ?? (_establishmentProfiles = new List<EstablishmentProfile>()); }
            protected set { _establishmentProfiles = value; }
        }
        private ICollection<Individual> _individuals { get; set; }
        public virtual ICollection<Individual> Individuals
        {
            get { return _individuals ?? (_individuals = new List<Individual>()); }
            protected set { _individuals = value; }
        }
        private ICollection<JobVacancy> _jobVacancies { get; set; }
        public virtual ICollection<JobVacancy> JobVacancies
        {
            get { return _jobVacancies ?? (_jobVacancies = new List<JobVacancy>()); }
            protected set { _jobVacancies = value; }
        }
        private ICollection<LaborOffice> _laborOffices { get; set; }
        public virtual ICollection<LaborOffice> LaborOffices
        {
            get { return _laborOffices ?? (_laborOffices = new List<LaborOffice>()); }
            protected set { _laborOffices = value; }
        }
        private ICollection<Owner> _owners { get; set; }
        public virtual ICollection<Owner> Owners
        {
            get { return _owners ?? (_owners = new List<Owner>()); }
            protected set { _owners = value; }
        }
    }
}
