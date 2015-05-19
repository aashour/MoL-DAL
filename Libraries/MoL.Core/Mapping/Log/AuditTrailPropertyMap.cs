using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Log;

namespace MoL.Core.Mapping.Log
{
    public partial class AuditTrailPropertyMap : EntityTypeConfiguration<AuditTrailProperty>
    {
        public AuditTrailPropertyMap()
        {
            ToTable("MOL_AuditTrailProperty", "dbo");
            HasKey(prop => prop.Id);
            Property(prop => prop.Id).HasColumnName("Id");
            Ignore(prop => prop.Deleted);
            Ignore(prop => prop.CreatedOnUtc);

            HasMany(prop => prop.AuditTrailInfos).
                WithOptional(audit => audit.AuditTrailProperty).
                HasForeignKey(audit => audit.Property_Id);
        }
    }
}
