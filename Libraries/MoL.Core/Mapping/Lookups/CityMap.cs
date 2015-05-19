using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Mapping.Lookups
{
    public partial class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            ToTable("Lookup_City", "dbo");
            HasKey(cty => cty.Id);
            Property(cty => cty.Id).HasColumnName("Id");
            Ignore(cty => cty.Deleted);
            Ignore(cty => cty.CreatedOnUtc);

            HasMany(cty => cty.LaborOffices).
                WithOptional(lab => lab.City).
                HasForeignKey(lab => lab.FK_CityId);

            HasMany(cty => cty.Agents).
                WithOptional(agnt => agnt.City).
                HasForeignKey(agnt => agnt.FK_CityId);

            HasMany(cty => cty.EstablishmentProfiles).
                WithOptional(estProf => estProf.City).
                HasForeignKey(estProf => estProf.FK_CityId);

            HasMany(cty => cty.Individuals).
                WithOptional(indv => indv.City).
                HasForeignKey(indv => indv.FK_CityId);

            HasMany(cty => cty.JobVacancies).
                WithOptional(job => job.City).
                HasForeignKey(job => job.FK_JobCityId);

            HasMany(cty => cty.Owners).
                WithOptional(own => own.City).
                HasForeignKey(own => own.FK_CityId);
        }
    }
}
