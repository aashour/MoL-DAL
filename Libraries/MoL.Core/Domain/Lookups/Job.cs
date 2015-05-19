using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Transactions;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Lookups
{
    public class Job : BaseEntity
    {
        public string Name { get; set; }
        public bool IsForSaudiOnly { get; set; }
        public string JobCode { get; set; }
        public bool? IsIncludedForEWV { get; set; }
        public string QsimCode { get; set; }
        public string JzaCode { get; set; }
        public string BabCode { get; set; }
        public string FslCode { get; set; }
        public string MhnCode { get; set; }
        public string MstCode { get; set; }
        public bool? CanChangeOnline { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsValidWPJob { get; set; }
        public bool isGovSupportEWV { get; set; }
        public bool? IsEngineeringJob { get; set; }
        public bool IsValid1_5ForIstiqdam { get; set; }

        private ICollection<Laborer> _laborer_temp_2s { get; set; }
        public virtual ICollection<Laborer> Laborer_temp_2s
        {
            get { return _laborer_temp_2s ?? (_laborer_temp_2s = new List<Laborer>()); }
            protected set { _laborer_temp_2s = value; }
        }
        private ICollection<ChangeJobDescriptionRequest> _changeJobDescriptionRequests { get; set; }
        public virtual ICollection<ChangeJobDescriptionRequest> ChangeJobDescriptionRequests
        {
            get { return _changeJobDescriptionRequests ?? (_changeJobDescriptionRequests = new List<ChangeJobDescriptionRequest>()); }
            protected set { _changeJobDescriptionRequests = value; }
        }
        private ICollection<EmployeeUser> _employeeUsers { get; set; }
        public virtual ICollection<EmployeeUser> EmployeeUsers
        {
            get { return _employeeUsers ?? (_employeeUsers = new List<EmployeeUser>()); }
            protected set { _employeeUsers = value; }
        }

        //private ICollection<EstablishmentRecruitmentContact> _establishmentRecruitmentContacts { get; set; }
        //public virtual ICollection<EstablishmentRecruitmentContact> EstablishmentRecruitmentContacts
        //{
        //    get { return _establishmentRecruitmentContacts ?? (_establishmentRecruitmentContacts = new List<EstablishmentRecruitmentContact>()); }
        //    protected set { _establishmentRecruitmentContacts = value; }
        //}
        //private ICollection<EstablishmentVisaCreditJobs> EstablishmentVisaCreditJobs { get; set; }
        //private ICollection<EstablishmentVisaCreditJobsHistory> EstablishmentVisaCreditJobsHistory { get; set; }
        //private ICollection<GC_AssentJobs> GC_AssentJobs { get; set; }
        //private ICollection<GC_ContractEstablishmentJobs> GC_ContractEstablishmentJobs { get; set; }
        //private ICollection<GC_VisaCreditAllowedJobs> GC_VisaCreditAllowedJobs { get; set; }
        //private ICollection<IndividualDesiredJob> _individualDesiredJobs { get; set; }
        //public virtual ICollection<IndividualDesiredJob> IndividualDesiredJobs
        //{
        //    get { return _individualDesiredJobs ?? (_individualDesiredJobs = new List<IndividualDesiredJob>()); }
        //    protected set { _individualDesiredJobs   = value; }
        //}

        private ICollection<JobVacancy> _jobVacancies { get; set; }
        public virtual ICollection<JobVacancy> JobVacancies
        {
            get { return _jobVacancies ?? (_jobVacancies = new List<JobVacancy>()); }
            protected set { _jobVacancies = value; }
        }
        private ICollection<Laborer> _laborers { get; set; }
        public virtual ICollection<Laborer> Laborers
        {
            get { return _laborers ?? (_laborers = new List<Laborer>()); }
            protected set { _laborers = value; }
        }
        private ICollection<Laborer> _laborer_temps { get; set; }
        public virtual ICollection<Laborer> Laborer_temps
        {
            get { return _laborer_temps ?? (_laborer_temps = new List<Laborer>()); }
            protected set { _laborer_temps = value; }
        }
        private ICollection<STTempLaborer> _sTTempLaborers { get; set; }
        public virtual ICollection<STTempLaborer> STTempLaborers
        {
            get { return _sTTempLaborers ?? (_sTTempLaborers = new List<STTempLaborer>()); }
            protected set { _sTTempLaborers = value; }
        }
    }
}
