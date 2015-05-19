using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Laborers.Enums;
using MoL.Core.Domain.Lookups;
using MoL.Core.Domain.Representitives;
using MoL.Core.Domain.Transactions;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Laborers
{
    public class Laborer : BaseEntity
    {
        public int FK_LaborOfficeId { get; set; }
        public int FK_SaudiFlagId { get; set; }
        public long SequenceNumber { get; set; }
        public DateTime? InsertDate { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string FourthName { get; set; }
        public int FK_AccomodationStatusId { get; set; }
        public string IdNo { get; set; }
        public string IdSource { get; set; }
        public DateTime? IdReleaseDate { get; set; }
        public int? FK_LaborerTypeId { get; set; }
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
        public long FK_EstablishmentId { get; set; }
        public float? Salary { get; set; }
        public System.DateTime ServiceStartDate { get; set; }
        public int? FK_LaborerStatusId { get; set; }
        public DateTime? ServiceEndDate { get; set; }
        public int? FK_ServiceEndReasonId { get; set; }
        public int FK_CurrentLaborOfficeId { get; set; }
        public string BorderNo { get; set; }
        public int? FK_Service_LastServiceStatusId { get; set; }
        public long? FK_WPId { get; set; }
        public long? FK_LastWPId { get; set; }
        public long? EstablishmentSequenceNumber { get; set; }
        public string EstablishmentName { get; set; }
        public int? EstablishmentStatusId { get; set; }
        public DateTime? LastWPStartDate { get; set; }
        public DateTime? LastWPExpirationDate { get; set; }
        public int UpdateStatus { get; set; }
        public DateTime? LaborerStatusModificationDate { get; set; }
        public bool? ModifiedByMOI { get; set; }
        public long? FK_BatchUserId { get; set; }
        public long? BatchTransactionNumber { get; set; }
        public long? FK_Service_TransactionId { get; set; }
        public DateTime? StatusLastModificationDate { get; set; }
        public bool? isUpdatedToOracle { get; set; }
        public bool? isSpecialExpatriate { get; set; }
        public int? FK_SpecialExpatriateTypeId { get; set; }
        public int? CameByCompensationVISA { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Mobile { get; set; }
        public DateTime? ComplaintDate { get; set; }
        public int? fk_GC_ContractEstablishmentsId { get; set; }
        public long? CreditID { get; set; }
        public int? CreditType { get; set; }

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
        public virtual LaborerStatus LaborerStatus
        {
            get
            {
                return (LaborerStatus)this.FK_LaborerStatusId;
            }
            set
            {
                this.FK_LaborerStatusId = (int)value;
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
        public virtual ServiceEndReason ServiceEndReason { get; set; }
        public virtual Establishment Establishment { get; set; }
        public virtual LaborOffice LaborOffice { get; set; }
        public virtual LaborOffice LaborOffice1 { get; set; }
        public virtual User User { get; set; }

        //private ICollection<ChangeJobDescriptionRequest> _changeJobDescriptionRequests { get; set; }
        //public virtual ICollection<ChangeJobDescriptionRequest> ChangeJobDescriptionRequests
        //{
        //    get { return _changeJobDescriptionRequests ?? (_changeJobDescriptionRequests = new List<ChangeJobDescriptionRequest>()); }
        //    protected set { _changeJobDescriptionRequests = value; }
        //}
        //private ICollection<ChangeWorkStatusRequest> _changeWorkStatusRequests { get; set; }
        //public virtual ICollection<ChangeWorkStatusRequest> ChangeWorkStatusRequests
        //{
        //    get { return _changeWorkStatusRequests ?? (_changeWorkStatusRequests = new List<ChangeWorkStatusRequest>()); }
        //    protected set { _changeWorkStatusRequests = value; }
        //}
        private ICollection<CommissionerSOLaborer> _commissionerSOLaborers { get; set; }
        public virtual ICollection<CommissionerSOLaborer> CommissionerSOLaborers
        {
            get { return _commissionerSOLaborers ?? (_commissionerSOLaborers = new List<CommissionerSOLaborer>()); }
            protected set { _commissionerSOLaborers = value; }
        }
        private ICollection<EstablishmentCommissioner> _establishmentCommissioners { get; set; }
        public virtual ICollection<EstablishmentCommissioner> EstablishmentCommissioners
        {
            get { return _establishmentCommissioners ?? (_establishmentCommissioners = new List<EstablishmentCommissioner>()); }
            protected set { _establishmentCommissioners = value; }
        }
        //private ICollection<SponsorTransfer> _sponsorTransfers { get; set; }
        //public virtual ICollection<SponsorTransfer> SponsorTransfers
        //{
        //    get { return _sponsorTransfers ?? (_sponsorTransfers = new List<SponsorTransfer>()); }
        //    protected set { _sponsorTransfers = value; }
        //}
        //private ICollection<TransferRequest> _transferRequests { get; set; }
        //public virtual ICollection<TransferRequest> TransferRequests
        //{
        //    get { return _transferRequests ?? (_transferRequests = new List<TransferRequest>()); }
        //    protected set { _transferRequests = value; }
        //}
        private ICollection<WorkPermit> _workPermits { get; set; }
        public virtual ICollection<WorkPermit> WorkPermits
        {
            get { return _workPermits ?? (_workPermits = new List<WorkPermit>()); }
            protected set { _workPermits = value; }
        }
        private ICollection<WorkPermit> _workPermit1s { get; set; }
        public virtual ICollection<WorkPermit> LastWorkPermits
        {
            get { return _workPermit1s ?? (_workPermit1s = new List<WorkPermit>()); }
            protected set { _workPermit1s = value; }
        }
    }
}
