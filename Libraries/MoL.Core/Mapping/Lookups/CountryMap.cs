using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Mapping.Lookups
{
    public partial class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            ToTable("Lookup_Country", "dbo");
            HasKey(ctry => ctry.Id);
            Property(ctry => ctry.Id).HasColumnName("Id");
            Ignore(ctry => ctry.Deleted);
            Ignore(ctry => ctry.CreatedOnUtc);

            HasMany(ctry => ctry.IndividualEducationalInfos).
                WithOptional(indv => indv.Country).
                HasForeignKey(indv => indv.FK_CountryId);

            HasMany(ctry => ctry.IndividualExperiences).
                WithOptional(indv => indv.Country).
                HasForeignKey(indv => indv.FK_CountryId);
        }
    }
}
