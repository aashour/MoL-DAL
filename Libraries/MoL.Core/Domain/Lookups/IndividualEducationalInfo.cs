using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Lookups
{
    public class IndividualEducationalInfo:BaseEntity
    {
        public long FK_IndividualId { get; set; }
        public int FK_EducationStatusId { get; set; }
        public string Specialization { get; set; }
        public string ExactSpecialization { get; set; }
        public DateTime? GraduationDate { get; set; }
        public Nullable<short> FK_CountryId { get; set; }
        public string InstituteName { get; set; }
        public string CertificateName { get; set; }
        public float? GPA { get; set; }
        public int? FK_GPASystemId { get; set; }
        public System.DateTime LastModified { get; set; }
        public long FK_LastModifiedUser { get; set; }
        public System.DateTime Created { get; set; }
        public long FK_CreatedBy { get; set; }

        public virtual Country Country { get; set; }
        public virtual EducationalStatus EducationalStatus { get; set; }
        public virtual GPASystem GPASystem { get; set; }
        public virtual Individual Individual { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
