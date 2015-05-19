using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Laborers;

namespace MoL.Core.Mapping.Laborers
{
    public partial class LaborerMap : EntityTypeConfiguration<Laborer>
    {
        public LaborerMap()
        {
            ToTable("MOL_Laborer", "dbo");
            HasKey(lab => lab.Id);
            Property(lab => lab.Id).HasColumnName("PK_LaborerId");
            Ignore(lab => lab.Deleted);
            Ignore(lab => lab.CreatedOnUtc);

            HasMany(lab => lab.CommissionerSOLaborers).
                WithOptional(comm => comm.Laborer).
                HasForeignKey(comm => comm.FK_LaborerId);

            HasMany(lab => lab.EstablishmentCommissioners).
                WithOptional(comm => comm.Laborer).
                HasForeignKey(comm => comm.FK_LaborerId);

            HasMany(lab => lab.WorkPermits).
                WithOptional(wp => wp.Laborer).
                HasForeignKey(wp => wp.FK_LaborId);

            HasMany(lab => lab.LastWorkPermits).
                WithOptional(wp => wp.Laborer).
                HasForeignKey(wp => wp.FK_LaborId);
        }
    }
}
