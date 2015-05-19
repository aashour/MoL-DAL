using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Mapping.Lookups
{
    public partial class EconomicActivityMap : EntityTypeConfiguration<EconomicActivity>
    {
        public EconomicActivityMap()
        {
            ToTable("Lookup_EconomicActivity", "dbo");
            HasKey(actvty => actvty.Id);
            Property(actvty => actvty.Id).HasColumnName("PK_EconomicActivityId");
            Ignore(actvty => actvty.Deleted);
            Ignore(actvty => actvty.CreatedOnUtc);

            HasMany(actvty => actvty.EconomicActivities).
                WithOptional(act => act.MainEconomicActivity).
                HasForeignKey(act => act.FK_MainEconomicActivityId);

            HasMany(actvty => actvty.Establishments).
                WithOptional(est => est.MainEconomicActivity).
                HasForeignKey(est => est.FK_MainEconomicActivityId);

            HasMany(actvty => actvty.Establishments).
                WithOptional(est => est.SubEconomicActivity).
                HasForeignKey(est => est.FK_SubEconomicActivityId);
        }
    }
}
