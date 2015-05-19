using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;

namespace MoL.Core.Mapping.Establishments
{
    public partial class LaborOfficeMap : EntityTypeConfiguration<LaborOffice>
    {
        public LaborOfficeMap()
        {
            ToTable("MOL_LaborOffice", "dbo");
            HasKey(labOff => labOff.Id);
            Property(labOff => labOff.Id).HasColumnName("PK_LaborOfficeId");
            Ignore(unf => unf.Deleted);
            Ignore(unf => unf.CreatedOnUtc);

            HasMany(labOff => labOff.Municipalities).
                WithOptional(mun => mun.LaborOffice).
                HasForeignKey(mun => mun.FK_LaborOfficeId);

            HasMany(labOff => labOff.Agents).
                WithOptional(agent => agent.LaborOffice).
                HasForeignKey(agent => agent.FK_CurrentLaborOffice);

            HasMany(labOff => labOff.EmployeeUsers).
                WithOptional(empUser => empUser.LaborOffice).
                HasForeignKey(empUser => empUser.LaborOfficeId);

            HasMany(labOff => labOff.Laborers).
                WithOptional(lab => lab.LaborOffice).
                HasForeignKey(lab => lab.FK_LaborOfficeId);

            HasMany(labOff => labOff.Owners).
                WithOptional(own => own.LaborOffice).
                HasForeignKey(own => own.FK_CurrentLaborOfficeId);

            HasMany(labOff => labOff.Srv_Transactions).
                WithOptional(trans => trans.LaborOffice).
                HasForeignKey(trans => trans.FK_LaborOfficeId);

            HasMany(labOff => labOff.UnifiedNumbers).
                WithOptional(unf => unf.LaborOffice).
                HasForeignKey(unf => unf.FK_LaborOfficeId);

            HasMany(labOff => labOff.Users).
                WithOptional(usr => usr.LaborOffice).
                HasForeignKey(usr => usr.FK_LaborOfficeId);
        }
    }
}
