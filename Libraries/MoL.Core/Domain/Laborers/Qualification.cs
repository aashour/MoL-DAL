using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Transactions;

namespace MoL.Core.Domain.Laborers
{
    public class Qualification:BaseEntity
    {
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        private ICollection<EducationQualification> _educationQualifications { get; set; }
        public virtual ICollection<EducationQualification> EducationQualifications
        {
            get { return _educationQualifications ?? (_educationQualifications = new List<EducationQualification>()); }
            protected set { _educationQualifications = value; }
        }
        private ICollection<CandidateRequirement> _candidateRequirements { get; set; }
        public virtual ICollection<CandidateRequirement> CandidateRequirements
        {
            get { return _candidateRequirements ?? (_candidateRequirements = new List<CandidateRequirement>()); }
            protected set { _candidateRequirements = value; }
        }
        private ICollection<ChangeJobDescriptionRequest> _changeJobDescriptionRequests { get; set; }
        public virtual ICollection<ChangeJobDescriptionRequest> ChangeJobDescriptionRequests
        {
            get { return _changeJobDescriptionRequests ?? (_changeJobDescriptionRequests = new List<ChangeJobDescriptionRequest>()); }
            protected set { _changeJobDescriptionRequests = value; }
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
