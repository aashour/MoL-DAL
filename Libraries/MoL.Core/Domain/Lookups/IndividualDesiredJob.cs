using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Laborers.Enums;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Lookups
{
    public class IndividualDesiredJob:BaseEntity
    {
        public long FK_IndividualId { get; set; }
        public Nullable<int> FK_JobId { get; set; }
        public int FK_LaborerTypeId { get; set; }
        public int FK_WorkingHoursPreferencesId { get; set; }
        public int FK_SalaryRangeId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime LastModified { get; set; }
        public long FK_LastModifiedUser { get; set; }
        public System.DateTime Created { get; set; }
        public long FK_CreatedBy { get; set; }
        public int? Fk_FslId { get; set; }

        public virtual LaborerType LaborerType {
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
                return (WorkingHoursPreference)this.FK_WorkingHoursPreferencesId;
            }
            set
            {
                this.FK_WorkingHoursPreferencesId = (int)value;
            }
        }
        public virtual Job Job { get; set; }
        public virtual SalaryRange SalaryRange { get; set; }
        public virtual Individual Individual { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
