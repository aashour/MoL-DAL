using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Mapping.Lookups
{
    public partial class BankMap : EntityTypeConfiguration<Bank>
    {
        public BankMap()
        {
            ToTable("Lookup_Bank", "dbo");
            HasKey(bnk => bnk.Id);
            Property(bnk => bnk.Id).HasColumnName("Id");
            Ignore(bnk => bnk.Deleted);
            Ignore(bnk => bnk.CreatedOnUtc);

            HasMany(bnk => bnk.LaborOffices).
                WithOptional(lab => lab.Bank).
                HasForeignKey(lab => lab.FK_BankId);

            HasMany(bnk => bnk.ServiceOffices).
                WithOptional(srvLab => srvLab.Bank).
                HasForeignKey(srvLab => srvLab.FK_BankId);
        }
    }
}
