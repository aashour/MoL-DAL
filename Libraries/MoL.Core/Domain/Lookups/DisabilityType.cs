using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Lookups
{
    public class DisabilityType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CandidateRequirement> _candidateRequirements { get; set; }
        public virtual ICollection<CandidateRequirement> CandidateRequirements
        {
            get { return _candidateRequirements ?? (_candidateRequirements = new List<CandidateRequirement>()); }
            protected set { _candidateRequirements = value; }
        }
        public virtual ICollection<CandidateRequirement> _candidateRequirement1s { get; set; }
        public virtual ICollection<CandidateRequirement> CandidateRequirement1s
        {
            get { return _candidateRequirement1s ?? (_candidateRequirement1s = new List<CandidateRequirement>()); }
            protected set { _candidateRequirement1s = value; }
        }
        public virtual ICollection<CandidateRequirement> _candidateRequirement2s { get; set; }
        public virtual ICollection<CandidateRequirement> CandidateRequirement2s
        {
            get { return _candidateRequirement2s ?? (_candidateRequirement2s = new List<CandidateRequirement>()); }
            protected set { _candidateRequirement2s = value; }
        }
        public virtual ICollection<Individual> _individuals { get; set; }
        public virtual ICollection<Individual> Individuals
        {
            get { return _individuals ?? (_individuals = new List<Individual>()); }
            protected set { _individuals = value; }
        }
        public virtual ICollection<Individual> _individual1s { get; set; }
        public virtual ICollection<Individual> Individual1s
        {
            get { return _individual1s ?? (_individual1s = new List<Individual>()); }
            protected set { _individual1s = value; }
        }
        public virtual ICollection<Individual> _individual2s { get; set; }
        public virtual ICollection<Individual> Individual2s
        {
            get { return _individual2s ?? (_individual2s = new List<Individual>()); }
            protected set { _individual2s = value; }
        }
    }
}
