using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Mapping.Lookups
{
    public partial class MaritalStatusMap : EntityTypeConfiguration<MaritalStatus>
    {
        public MaritalStatusMap()
        {

        }
    }
}
