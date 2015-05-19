using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments.Enums;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Log;
using MoL.Core.Domain.Lookups;
using MoL.Core.Domain.Representitives;
using MoL.Core.Domain.Transactions;

namespace MoL.Core.Domain.Establishments
{
    /// <summary>
    /// Represents an establishment
    /// </summary>
    public class Establishment : BaseEntity
    {
        private ICollection<EstablishmentAgent> _establishmentAgents { get; set; }
        private ICollection<EstablishmentCommissioner> _establishmentCommissioners { get; set; }
        private ICollection<EstablishmentNote> _establishmentNotes { get; set; }
        private ICollection<EstablishmentStatement> _establishmentStatements { get; set; }
        private ICollection<Laborer> _laborers { get; set; }
        private ICollection<OracleTransactionLog> _oracleTransactionLogs { get; set; }
        private ICollection<Srv_Transaction> _srv_Transactions { get; set; }


        public long FK_UnifiedNumberId { get; set; }
        public int FK_LaborOfficeId { get; set; }
        public long SequenceNumber { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? InsertDate { get; set; }
        public string Name { get; set; }
        public string ZakatRegisterationNumber { get; set; }
        public int? FK_MainEconomicActivityId { get; set; }
        public int? FK_SubEconomicActivityId { get; set; }
        public string EconomicActivityText { get; set; }
        public int? RequiredLaborCount { get; set; }
        public int? FK_EstablishmentStatusId { get; set; }
        public DateTime? StatusModificationDate { get; set; }
        public string Notes { get; set; }
        public DateTime? LaborCountLastModificationDate { get; set; }
        public string CommercialRecordNumber { get; set; }
        public DateTime? CommercialRecordReleaseDate { get; set; }
        public DateTime? CommercialRecordEndDate { get; set; }
        public string CommercialRecordSource { get; set; }
        public string CommercialRecordCancellationNo { get; set; }
        public DateTime? CommercialRecordCancellationDt { get; set; }
        public string MunicipalLicenseNumber { get; set; }
        public DateTime? MunicipalLicenseReleaseDate { get; set; }
        public DateTime? MunicipalLicenseEndDate { get; set; }
        public string MunicipalLicenseSource { get; set; }
        public string MunicipalLicenseCancellationNo { get; set; }
        public DateTime? MunicipalLicenseCancellationDt { get; set; }
        public string AreaForMunicipalLicense { get; set; }
        public string SocialInsuranceRegisterationNo { get; set; }
        public DateTime? SocialInsuranceRegEndDate { get; set; }
        public string ZakatCertificateNumber { get; set; }
        public DateTime? ZakatCertificateDate { get; set; }
        public int FK_CityId { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string ZipCode { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Fax { get; set; }
        public string email { get; set; }
        public int? ConcessionsCount { get; set; }
        public int? DeparturesCount { get; set; }
        public int? RunnersCount { get; set; }
        public bool? IsMainBranch { get; set; }
        public string ManagerName { get; set; }
        public string NationalEnterpriseId { get; set; }
        public DateTime? CommercialRecordConfirmationDate { get; set; }
        public DateTime? MunicipalLicenseConfirmationDate { get; set; }
        public DateTime? SocialInsuranceConfirmationDate { get; set; }
        public DateTime? ZakatCertificateConfirmationDate { get; set; }
        public int? SaudiLaborCountAtRegistration { get; set; }
        public int? NonSaudiLaborCountAtRegistration { get; set; }
        public int? FK_MunicipalityId { get; set; }
        public int? Fk_NewEconomicActivityId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? WASELStatus { get; set; }
        public string WASELZipCode { get; set; }
        public string WASELPrimary { get; set; }
        public string WASELSecondary { get; set; }
        public string WASELUnitNo { get; set; }
        public string WASELCity { get; set; }
        public string WASELArea { get; set; }
        public string WASELStreet { get; set; }
        public DateTime? WASELExpiryDate { get; set; }
        public bool? MOCIUpdate { get; set; }
        public DateTime? MOCIUpdateTimeStamp { get; set; }
        public string SevenHundred { get; set; }
        public int? FK_CRStatusId { get; set; }
        public bool? IsGregorian { get; set; }

        public virtual EstablishmentStatus EstablishmentStatus
        {
            get
            {
                return (EstablishmentStatus)this.FK_EstablishmentStatusId;
            }
            set
            {
                this.FK_EstablishmentStatusId = (int)value;
            }
        }

        public virtual UnifiedNumber UnifiedNumber { get; set; }

        public virtual LaborOffice LaborOffice { get; set; }

        public virtual EconomicActivity MainEconomicActivity { get; set; }

        public virtual EconomicActivity SubEconomicActivity { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<EstablishmentAgent> EstablishmentAgents
        {
            get { return _establishmentAgents ?? (_establishmentAgents = new List<EstablishmentAgent>()); }
            protected set { _establishmentAgents = value; }
        }

        public virtual ICollection<EstablishmentCommissioner> EstablishmentCommissioners
        {
            get { return _establishmentCommissioners ?? (_establishmentCommissioners = new List<EstablishmentCommissioner>()); }
            protected set { _establishmentCommissioners = value; }
        }

        public virtual ICollection<EstablishmentNote> EstablishmentNotes
        {
            get { return _establishmentNotes ?? (_establishmentNotes = new List<EstablishmentNote>()); }
            protected set { _establishmentNotes = value; }
        }

        public virtual ICollection<EstablishmentStatement> EstablishmentStatements
        {
            get { return _establishmentStatements ?? (_establishmentStatements = new List<EstablishmentStatement>()); }
            protected set { _establishmentStatements = value; }
        }

        public virtual ICollection<Laborer> Laborers
        {
            get { return _laborers ?? (_laborers = new List<Laborer>()); }
            protected set { _laborers = value; }
        }

        public virtual ICollection<OracleTransactionLog> OracleTransactionLogs
        {
            get { return _oracleTransactionLogs ?? (_oracleTransactionLogs = new List<OracleTransactionLog>()); }
            protected set { _oracleTransactionLogs = value; }
        }

        public virtual ICollection<Srv_Transaction> Srv_Transactions
        {
            get { return _srv_Transactions ?? (_srv_Transactions = new List<Srv_Transaction>()); }
            protected set { _srv_Transactions = value; }
        }

    }
}
