using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Lookups;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Laborers
{
    public class IndividualExperience : BaseEntity
    {
        public long FK_IndividualId { get; set; }
        public string PlaceOfWork { get; set; }
        public string JobDescription { get; set; }
        public short FK_CountryId { get; set; }
        public System.DateTime StartWorkingDate { get; set; }
        public DateTime? EndWorkingDate { get; set; }
        public double? LastSalary { get; set; }
        public string Description { get; set; }
        public string WorkTitle { get; set; }
        public string ContactPerson { get; set; }
        public bool IsCurrentWork { get; set; }
        public System.DateTime LastModified { get; set; }
        public long FK_LastModifiedUser { get; set; }
        public System.DateTime Created { get; set; }
        public long FK_CreatedBy { get; set; }

        public virtual Country Country { get; set; }
        public virtual Individual Individual { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
