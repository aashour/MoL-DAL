using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Laborers;

namespace MoL.Core.Domain.Lookups
{
    public class SalaryRange : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public short? UpperLimit { get; set; }
        public short? LowerLimit { get; set; }

        public virtual ICollection<IndividualDesiredJob> _individualDesiredJobs { get; set; }
        public virtual ICollection<IndividualDesiredJob> IndividualDesiredJobs
        {
            get { return _individualDesiredJobs ?? (_individualDesiredJobs = new List<IndividualDesiredJob>()); }
            protected set { _individualDesiredJobs = value; }
        }
        public virtual ICollection<JobVacancy> _jobVacancies { get; set; }
        public virtual ICollection<JobVacancy> JobVacancies
        {
            get { return _jobVacancies ?? (_jobVacancies = new List<JobVacancy>()); }
            protected set { _jobVacancies = value; }
        }
    }
}
