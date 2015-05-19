using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Log;

namespace MoL.Core.Mapping.Log
{
    public partial class AuditTrailInfoMap : EntityTypeConfiguration<AuditTrailInfo>
    {
        public AuditTrailInfoMap()
        {
            ToTable("MOL_AuditTrailInfo", "dbo");
            HasKey(audit => audit.Id);
            Property(audit => audit.Id).HasColumnName("Id");
            Ignore(audit => audit.Deleted);
            Ignore(audit => audit.CreatedOnUtc);
        }
    }
}
