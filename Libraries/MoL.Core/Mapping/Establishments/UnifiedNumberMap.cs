using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;

namespace MoL.Core.Mapping.Establishments
{
    public partial class UnifiedNumberMap : EntityTypeConfiguration<UnifiedNumber>
    {
        public UnifiedNumberMap()
        {
            ToTable("MOL_UnifiedNumber", "dbo");
            HasKey(unf => unf.Id);
            Property(unf => unf.Id).HasColumnName("PK_UnifiedNumberId");
            //Property(unf => unf.Deleted).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Ignore(unf => unf.Deleted);
            //Property(unf => unf.CreatedOnUtc).HasColumnName("CreatedOn");
            Ignore(unf => unf.CreatedOnUtc);

            HasMany(unf => unf.Establishments).
                WithOptional(est => est.UnifiedNumber).
                HasForeignKey(est => est.FK_UnifiedNumberId);

        }

    }
}
