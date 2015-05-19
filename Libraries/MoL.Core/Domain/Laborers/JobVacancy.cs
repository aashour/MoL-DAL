using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Laborers.Enums;
using MoL.Core.Domain.Lookups;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Laborers
{
    public class JobVacancy : BaseEntity
    {
        public long FK_EstablishmentProfileId { get; set; }
        public int? FK_JobId { get; set; }
        public int FK_LaborerTypeId { get; set; }
        public string JobDescription { get; set; }
        public short NoOfAvailableVacancies { get; set; }
        public int FK_JobCityId { get; set; }
        public System.DateTime CreationDate { get; set; }
        public DateTime? StartDate { get; set; }
        public int? FK_SalaryRangeId { get; set; }
        public int? FK_WorkingHoursPreferenceId { get; set; }
        public string RefNo { get; set; }
        public string ActivationStatusChangeReason { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public string JobName { get; set; }
        public int? FK_GenderId { get; set; }
        public string Skills { get; set; }
        public bool IsActive { get; set; }
        public int? FK_JobAvailability { get; set; }
        public System.DateTime LastModified { get; set; }
        public long FK_LastModifiedUser { get; set; }
        public System.DateTime Created { get; set; }
        public long FK_CreatedBy { get; set; }
        public int? FK_JobVacancyStatusId { get; set; }
        public int FK_EducationalStatus { get; set; }
        public int? Fk_FslId { get; set; }

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
        public virtual JobAvailability JobAvailability
        {
            get
            {
                return (JobAvailability)this.FK_JobAvailability;
            }
            set
            {
                this.FK_JobAvailability = (int)value;
            }
        }
        public virtual JobVacancyStatus JobVacancyStatus
        {
            get
            {
                return (JobVacancyStatus)this.FK_JobVacancyStatusId;
            }
            set
            {
                this.FK_JobVacancyStatusId = (int)value;
            }
        }
        public virtual LaborerType LaborerType
        {
            get
            {
                return (LaborerType)this.FK_LaborerTypeId;
            }
            set
            {
                this.FK_LaborerTypeId = (int)value;
            }
        }
        public virtual WorkingHoursPreference WorkingHoursPreference
        {
            get
            {
                return (WorkingHoursPreference)this.FK_WorkingHoursPreferenceId;
            }
            set
            {
                this.FK_WorkingHoursPreferenceId = (int)value;
            }
        }
        public virtual City City { get; set; }
        public virtual EducationalStatus EducationalStatus { get; set; }
        public virtual Job Job { get; set; }
        public virtual SalaryRange SalaryRange { get; set; }
        public virtual EstablishmentProfile EstablishmentProfile { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }

        private ICollection<JobApplication> _jobApplications { get; set; }
        public virtual ICollection<JobApplication> JobApplications
        {
            get { return _jobApplications ?? (_jobApplications = new List<JobApplication>()); }
            protected set { _jobApplications = value; }
        }
        private ICollection<CandidateRequirement> _candidateRequirements { get; set; }
        public virtual ICollection<CandidateRequirement> CandidateRequirements
        {
            get { return _candidateRequirements ?? (_candidateRequirements = new List<CandidateRequirement>()); }
            protected set { _candidateRequirements = value; }
        }
    }
}
