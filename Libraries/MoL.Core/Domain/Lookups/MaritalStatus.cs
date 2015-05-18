using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Lookups
{
    public class MaritalStatus : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        private ICollection<CandidateRequirement> _candidateRequirements { get; set; }
        public virtual ICollection<CandidateRequirement> CandidateRequirements
        {
            get { return _candidateRequirements ?? (_candidateRequirements = new List<CandidateRequirement>()); }
            protected set { _candidateRequirements = value; }
        }
        private ICollection<User> _users { get; set; }
        public virtual ICollection<User> Users
        {
            get { return _users ?? (_users = new List<User>()); }
            protected set { _users = value; }
        }
    }
}
