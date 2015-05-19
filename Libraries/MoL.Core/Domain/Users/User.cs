using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Log;
using MoL.Core.Domain.Lookups;
using MoL.Core.Domain.Security;
using MoL.Core.Domain.Transactions;
using MoL.Core.Domain.Users.Enums;

namespace MoL.Core.Domain.Users
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string First_Name { get; set; }
        public string Second_Name { get; set; }
        public string Third_Name { get; set; }
        public string Fourth_Name { get; set; }
        public short? NationalityId { get; set; }
        public DateTime? Birth_Date { get; set; }
        public int? User_Type_Id { get; set; }
        public int? UserId { get; set; }
        public string Email { get; set; }
        public DateTime? LastLoggedIn { get; set; }
        public int? FK_LaborOfficeId { get; set; }
        public int? GenderID { get; set; }
        public int? MaritalStatusID { get; set; }
        public long? Id_Number { get; set; }
        public DateTime? Id_ExpiryDate { get; set; }
        public long? Iqama_Number { get; set; }
        public DateTime? Iqama_ExpiryDate { get; set; }
        public int? EmailLangID { get; set; }
        public bool? IsUserDeleted { get; set; }
        public string PlaceofBirth { get; set; }
        public bool? IsActivated { get; set; }
        public string MobileNumber { get; set; }
        public bool IsSystem { get; set; }
        public string TwitterAccount { get; set; }
        public string POBox { get; set; }
        public string ZipCode { get; set; }
        public string Fax { get; set; }
        public DateTime? Created { get; set; }
        public bool? FromHafiz { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? CreatedBy { get; set; }
        public bool IsEmailVerified { get; set; }
        public short EmailVerificationCount { get; set; }
        public DateTime? EmailLastVerificationDate { get; set; }
        public bool IsMobileVerified { get; set; }
        public short MobileVerificationCount { get; set; }
        public DateTime? MobileLastVerificationDate { get; set; }
        public bool IsDataVerified { get; set; }

        public virtual MaritalStatus MaritalStatus { get; set; }
        public virtual Nationality Nationality { get; set; }
        public virtual EmployeeUser EmployeeUser { get; set; }
        public virtual LaborOffice LaborOffice { get; set; }
        //public virtual User User1 { get; set; }
        //public virtual User User2 { get; set; }

        public virtual EmailLanguage EstablishmentStatus
        {
            get
            {
                return (EmailLanguage)this.EmailLangID;
            }
            set
            {
                this.EmailLangID = (int)value;
            }
        }

        public virtual Gender Gender
        {
            get
            {
                return (Gender)this.GenderID;
            }
            set
            {
                this.GenderID = (int)value;
            }
        }
        public virtual UserType UserType
        {
            get
            {
                return (UserType)this.User_Type_Id;
            }
            set
            {
                this.User_Type_Id = (int)value;
            }
        }

        private ICollection<AuditTrailInfo> _auditTrailInfos { get; set; }
        public virtual ICollection<AuditTrailInfo> AuditTrailInfos
        {
            get { return _auditTrailInfos ?? (_auditTrailInfos = new List<AuditTrailInfo>()); }
            protected set { _auditTrailInfos = value; }
        }
        private ICollection<CancelVisaRequest> _cancelVisaRequests { get; set; }
        public virtual ICollection<CancelVisaRequest> CancelVisaRequests
        {
            get { return _cancelVisaRequests ?? (_cancelVisaRequests = new List<CancelVisaRequest>()); }
            protected set { _cancelVisaRequests = value; }
        }

        private ICollection<CWSCommentsTracking> _cWSCommentsTrackings { get; set; }
        public virtual ICollection<CWSCommentsTracking> CWSCommentsTrackings
        {
            get { return _cWSCommentsTrackings ?? (_cWSCommentsTrackings = new List<CWSCommentsTracking>()); }
            protected set { _cWSCommentsTrackings = value; }
        }

        private ICollection<Employee> _employees { get; set; }
        public virtual ICollection<Employee> Employees
        {
            get { return _employees ?? (_employees = new List<Employee>()); }
            protected set { _employees = value; }
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

        private ICollection<Laborer> _laborers { get; set; }
        public virtual ICollection<Laborer> Laborers
        {
            get { return _laborers ?? (_laborers = new List<Laborer>()); }
            protected set { _laborers = value; }
        }

        private ICollection<OracleTransactionLog> _oracleTransactionLogs { get; set; }
        public virtual ICollection<OracleTransactionLog> OracleTransactionLogs
        {
            get { return _oracleTransactionLogs ?? (_oracleTransactionLogs = new List<OracleTransactionLog>()); }
            protected set { _oracleTransactionLogs = value; }
        }

        private ICollection<SponsorTransfer> _sponsorTransfers { get; set; }
        public virtual ICollection<SponsorTransfer> SponsorTransfers
        {
            get { return _sponsorTransfers ?? (_sponsorTransfers = new List<SponsorTransfer>()); }
            protected set { _sponsorTransfers = value; }
        }

        private ICollection<Srv_Transaction> _srv_Transactions { get; set; }
        public virtual ICollection<Srv_Transaction> Srv_Transactions
        {
            get { return _srv_Transactions ?? (_srv_Transactions = new List<Srv_Transaction>()); }
            protected set { _srv_Transactions = value; }
        }

        private ICollection<STTempLaborer> _sTTempLaborers { get; set; }
        public virtual ICollection<STTempLaborer> STTempLaborers
        {
            get { return _sTTempLaborers ?? (_sTTempLaborers = new List<STTempLaborer>()); }
            protected set { _sTTempLaborers = value; }
        }

        private ICollection<WorkPermit> _workPermits { get; set; }
        public virtual ICollection<WorkPermit> WorkPermits
        {
            get { return _workPermits ?? (_workPermits = new List<WorkPermit>()); }
            protected set { _workPermits = value; }
        }

        private ICollection<Sec_Privilege> _sec_Privileges { get; set; }
        public virtual ICollection<Sec_Privilege> Sec_Privileges
        {
            get { return _sec_Privileges ?? (_sec_Privileges = new List<Sec_Privilege>()); }
            protected set { _sec_Privileges = value; }
        }

        private ICollection<Sec_UserEntityPrivilege> _sec_UserEntityPrivileges { get; set; }
        public virtual ICollection<Sec_UserEntityPrivilege> Sec_UserEntityPrivileges
        {
            get { return _sec_UserEntityPrivileges ?? (_sec_UserEntityPrivileges = new List<Sec_UserEntityPrivilege>()); }
            protected set { _sec_UserEntityPrivileges = value; }
        }

        private ICollection<Sec_UserRole> _sec_UserRoles { get; set; }
        public virtual ICollection<Sec_UserRole> Sec_UserRoles
        {
            get { return _sec_UserRoles ?? (_sec_UserRoles = new List<Sec_UserRole>()); }
            protected set { _sec_UserRoles = value; }
        }
    }
}
