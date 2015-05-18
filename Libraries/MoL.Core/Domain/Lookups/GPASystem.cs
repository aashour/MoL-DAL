using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoL.Core.Domain.Lookups
{
    public class GPASystem : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        private ICollection<IndividualEducationalInfo> _individualEducationalInfos { get; set; }
        public virtual ICollection<IndividualEducationalInfo> IndividualEducationalInfos
        {
            get { return _individualEducationalInfos ?? (_individualEducationalInfos = new List<IndividualEducationalInfo>()); }
            protected set { _individualEducationalInfos = value; }
        }

    }
}
