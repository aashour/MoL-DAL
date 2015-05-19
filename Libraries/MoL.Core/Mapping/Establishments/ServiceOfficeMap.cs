using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;

namespace MoL.Core.Mapping.Establishments
{
    public partial class ServiceOfficeMap : EntityTypeConfiguration<ServiceOffice>
    {
        public ServiceOfficeMap()
        {
            ToTable("MOL_ServiceOffice", "dbo");
            HasKey(est => est.Id);
            Property(est => est.Id).HasColumnName("PK_ServiceOfficeId");
            Ignore(unf => unf.Deleted);
            Ignore(unf => unf.CreatedOnUtc);

            HasMany(srvOff => srvOff.CommissionerSOLaborers).
                WithOptional(comm => comm.ServiceOffice).
                HasForeignKey(comm => comm.FK_ServiceOfficeID);

            HasMany(srvOff => srvOff.EstablishmentCommissioners).
                WithOptional(comm => comm.ServiceOffice).
                HasForeignKey(comm => comm.FK_ServiceOfficeId);
        }

    }
}
