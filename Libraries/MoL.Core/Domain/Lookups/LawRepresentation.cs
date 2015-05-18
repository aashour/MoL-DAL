using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;

namespace MoL.Core.Domain.Lookups
{
    public class LawRepresentation : BaseEntity
    {
        public string Name { get; set; }

        private  ICollection<UnifiedNumber> _unifiedNumbers { get; set; }
        public virtual ICollection<UnifiedNumber> UnifiedNumbers
        {
            get { return _unifiedNumbers ?? (_unifiedNumbers = new List<UnifiedNumber>()); }
            protected set { _unifiedNumbers = value; }
        }
        private  ICollection<UnifiedNumber> _unifiedNumber_temps { get; set; }
        public virtual ICollection<UnifiedNumber> UnifiedNumber_temps
        {
            get { return _unifiedNumber_temps ?? (_unifiedNumber_temps = new List<UnifiedNumber>()); }
            protected set { _unifiedNumber_temps = value; }
        }
    }
}
