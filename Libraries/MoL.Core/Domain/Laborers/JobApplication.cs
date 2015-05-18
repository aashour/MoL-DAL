using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Laborers
{
    public class JobApplication:BaseEntity
    {
        public long FK_JobVacancyId { get; set; }
        public long FK_IndividualId { get; set; }
        public int? FK_ApplicaitonStatusId { get; set; }
        public string ApplicationStatusChangeReason { get; set; }
        public DateTime? DateApplied { get; set; }
        public int? FK_RejectionReasonId { get; set; }
        public string OtherRejectionReason { get; set; }
        public string NotesOnApplicant { get; set; }
        public DateTime? StartingDate { get; set; }
        public double? Salary { get; set; }
        public int FK_RequesterTypeId { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime LastModified { get; set; }
        public long FK_LastModifiedUser { get; set; }
        public System.DateTime Created { get; set; }
        public long FK_CreatedBy { get; set; }
        public bool? IsAutoMatched { get; set; }

        public virtual JobApplicationRequesterType JobApplicationRequesterType {
            get
            {
                return (JobApplicationRequesterType)this.FK_RequesterTypeId;
            }
            set
            {
                this.FK_RequesterTypeId = (int)value;
            }
        }
        public virtual JobApplicationStatus JobApplicationStatus {
            get
            {
                return (JobApplicationStatus)this.FK_ApplicaitonStatusId;
            }
            set
            {
                this.FK_ApplicaitonStatusId = (int)value;
            }
        }
        public virtual RejectionReason RejectionReason
        {
            get
            {
                return (RejectionReason)this.FK_RejectionReasonId;
            }
            set
            {
                this.FK_RejectionReasonId = (int)value;
            }
        }
        public virtual Individual Individual { get; set; }
        public virtual JobVacancy JobVacancy { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
