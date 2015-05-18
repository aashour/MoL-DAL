using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoL.Core.Domain.Lookups
{
    public class Origin:BaseEntity
    {
        public string Name { get; set; }
        public bool? IsIncludedForEWV { get; set; }
        public short? FK_NationalityId { get; set; }

        public virtual Nationality Nationality { get; set; }
    }
}
