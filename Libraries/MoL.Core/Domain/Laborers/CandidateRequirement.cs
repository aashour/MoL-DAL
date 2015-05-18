using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Domain.Laborers
{
    public class CandidateRequirement : BaseEntity
    {
        public long FK_JobVacancyId { get; set; }
        public int FK_QualificationId { get; set; }
        public string NeededSkills { get; set; }
        public int FK_GenderId { get; set; }
        public int FK_MaritalStatusId { get; set; }
        public int? FK_DisabilityTypeId1 { get; set; }
        public int? FK_DisabilityTypeId2 { get; set; }
        public int? FK_DisabilityTypeId3 { get; set; }

        public virtual Gender Gender
        {
            get
            {
                return (Gender)this.FK_GenderId;
            }
            set
            {
                this.FK_GenderId = (int)value;
            }
        }
        public virtual DisabilityType DisabilityType { get; set; }
        public virtual DisabilityType DisabilityType1 { get; set; }
        public virtual DisabilityType DisabilityType2 { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public virtual Qualification Qualification { get; set; }
        public virtual JobVacancy JobVacancy { get; set; }
    }
}
