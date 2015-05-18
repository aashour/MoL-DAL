using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Laborers;

namespace MoL.Core.Domain.Lookups
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string Local_Name { get; set; }
        public short? Code { get; set; }
        public string Nationality { get; set; }
        public string Local_Nationality { get; set; }

        private ICollection<IndividualEducationalInfo> _individualEducationalInfos { get; set; }
        public virtual ICollection<IndividualEducationalInfo> IndividualEducationalInfos
        {
            get { return _individualEducationalInfos ?? (_individualEducationalInfos = new List<IndividualEducationalInfo>()); }
            protected set { _individualEducationalInfos = value; }
        }
        private ICollection<IndividualExperience> _individualExperiences { get; set; }
        public virtual ICollection<IndividualExperience> IndividualExperiences
        {
            get { return _individualExperiences ?? (_individualExperiences = new List<IndividualExperience>()); }
            protected set { _individualExperiences = value; }
        }
  
    }
}
