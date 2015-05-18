using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;

namespace MoL.Core.Domain.Lookups
{
    public class Municipality : BaseEntity
    {
        public string Name { get; set; }
        public int FK_LaborOfficeId { get; set; }

        public virtual LaborOffice LaborOffice { get; set; }
    }
}
