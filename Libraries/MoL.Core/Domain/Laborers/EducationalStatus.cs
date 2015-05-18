using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Lookups;
using MoL.Core.Domain.Transactions;

namespace MoL.Core.Domain.Laborers
{
    public class EducationalStatus : BaseEntity
    {
        public string Name { get; set; }

        public virtual EducationQualification _educationQualifications { get; set; }

        private ICollection<ChangeJobDescriptionRequest> _changeJobDescriptionRequests { get; set; }
        public virtual ICollection<ChangeJobDescriptionRequest> ChangeJobDescriptionRequests
        {
            get { return _changeJobDescriptionRequests ?? (_changeJobDescriptionRequests = new List<ChangeJobDescriptionRequest>()); }
            protected set { _changeJobDescriptionRequests = value; }
        }
        private ICollection<IndividualEducationalInfo> _individualEducationalInfos { get; set; }
        public virtual ICollection<IndividualEducationalInfo> IndividualEducationalInfos
        {
            get { return _individualEducationalInfos ?? (_individualEducationalInfos = new List<IndividualEducationalInfo>()); }
            protected set { _individualEducationalInfos = value; }
        }
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
        private ICollection<Laborer> _laborer_temp_2s { get; set; }
        public virtual ICollection<Laborer> Laborer_temp_2s
        {
            get { return _laborer_temp_2s ?? (_laborer_temp_2s = new List<Laborer>()); }
            protected set { _laborer_temp_2s = value; }
        }
        private ICollection<STTempLaborer> _sTTempLaborers { get; set; }
        public virtual ICollection<STTempLaborer> STTempLaborers
        {
            get { return _sTTempLaborers ?? (_sTTempLaborers = new List<STTempLaborer>()); }
            protected set { _sTTempLaborers = value; }
        }
    }
}
