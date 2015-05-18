using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Lookups;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Transactions
{
    public class STTempLaborer : BaseEntity
    {
        public int? FK_LaborOfficeId { get; set; }
        public int? FK_SaudiFlagId { get; set; }
        public long? SequenceNumber { get; set; }
        public DateTime? InsertDate { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string FourthName { get; set; }
        public int? FK_AccomodationStatusId { get; set; }
        public string IdNo { get; set; }
        public string IdSource { get; set; }
        public DateTime? IdReleaseDate { get; set; }
        public int? FK_STTempLaborerTypeId { get; set; }
        public short FK_NationalityId { get; set; }
        public short FK_ReligionId { get; set; }
        public string PassportNo { get; set; }
        public string PassportSource { get; set; }
        public DateTime? PassportReleaseDate { get; set; }
        public DateTime? VisaExpiryDate { get; set; }
        public int FK_GenderId { get; set; }
        public int YearOfBirth { get; set; }
        public int FK_JobId { get; set; }
        public int FK_EducationalStatusId { get; set; }
        public int? FK_QualificationId { get; set; }
        public DateTime? KingdomEntryDate { get; set; }
        public float? Salary { get; set; }
        public DateTime? ServiceStartDate { get; set; }
        public int? FK_STTempLaborerStatusId { get; set; }
        public DateTime? ServiceEndDate { get; set; }
        public int? FK_ServiceEndReasonId { get; set; }
        public int? FK_CurrentLaborOfficeId { get; set; }
        public bool? ModifiedByMOI { get; set; }
        public string BorderNo { get; set; }
        public long? FK_BatchUserId { get; set; }
        public long? BatchTransactionNumber { get; set; }
        public long? FK_EstablishmentId { get; set; }
        public string CurrentEmployerIdNo { get; set; }

        public virtual AccomodationStatus AccomodationStatus
        {
            get
            {
                return (AccomodationStatus)this.FK_AccomodationStatusId;
            }
            set
            {
                this.FK_AccomodationStatusId = (int)value;
            }
        }
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
        public virtual SaudiFlag SaudiFlag
        {
            get
            {
                return (SaudiFlag)this.FK_SaudiFlagId;
            }
            set
            {
                this.FK_SaudiFlagId = (int)value;
            }
        }
        public virtual EducationalStatus EducationalStatus { get; set; }
        public virtual Job Job { get; set; }
        public virtual Nationality Nationality { get; set; }
        public virtual Qualification Qualification { get; set; }
        public virtual Religion Religion { get; set; }
        public virtual ServiceEndReason Lookup_ServiceEndReason { get; set; }
        public virtual Establishment Establishment { get; set; }
        public virtual LaborOffice LaborOffice { get; set; }
        public virtual LaborOffice LaborOffice1 { get; set; }
        public virtual User User { get; set; }
    }
}
