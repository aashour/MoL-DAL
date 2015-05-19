using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;

namespace MoL.Core.Mapping.Establishments
{
    public partial class EstablishmentStatementMap : EntityTypeConfiguration<EstablishmentStatement>
    {
        public EstablishmentStatementMap()
        {
            ToTable("MOL_EstablishmentStatement", "dbo");
            HasKey(estStmt => estStmt.Id);
            Property(estStmt => estStmt.Id).HasColumnName("PK_EstablishmentStatementId");
            Ignore(estStmt => estStmt.Deleted);
            Ignore(estStmt => estStmt.CreatedOnUtc);
        }
    }
}
