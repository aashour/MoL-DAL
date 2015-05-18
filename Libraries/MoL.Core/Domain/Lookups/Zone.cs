using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;

namespace MoL.Core.Domain.Lookups
{
    public class Zone:BaseEntity
    {
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        private ICollection<LaborOffice> _laborOffices { get; set; }
        public virtual ICollection<LaborOffice> LaborOffices
        {
            get { return _laborOffices ?? (_laborOffices = new List<LaborOffice>()); }
            protected set { _laborOffices = value; }
        }
    }
}
