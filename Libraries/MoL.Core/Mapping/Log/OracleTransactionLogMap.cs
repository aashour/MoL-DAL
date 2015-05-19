using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Log;

namespace MoL.Core.Mapping.Log
{
    public partial class OracleTransactionLogMap : EntityTypeConfiguration<OracleTransactionLog>
    {
        public OracleTransactionLogMap()
        {
            ToTable("MOL_OracleTransactionLog", "dbo");
            HasKey(log => log.Id);
            Property(log => log.Id).HasColumnName("Id");
            Ignore(log => log.Deleted);
            Ignore(log => log.CreatedOnUtc);
        }
    }
}
