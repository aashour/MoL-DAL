using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;

namespace MoL.Core.Mapping.Establishments
{
    public partial class EstablishmentMap : EntityTypeConfiguration<Establishment>
    {
        public EstablishmentMap()
        {
            ToTable("MOL_Establishment", "dbo");
            HasKey(est => est.Id);
            Property(est => est.Id).HasColumnName("PK_EstablishmentId");
            Ignore(unf => unf.Deleted);
            Ignore(unf => unf.CreatedOnUtc);

            HasMany(est => est.EstablishmentAgents).
                WithOptional(estAgent => estAgent.Establishment).
                HasForeignKey(estAgent => estAgent.FK_EstablishmentId);

            HasMany(est => est.EstablishmentCommissioners).
                WithOptional(estComm => estComm.Establishment).
                HasForeignKey(estComm => estComm.FK_EstablishmentId);

            HasMany(est => est.EstablishmentNotes).
                WithOptional(estNote => estNote.Establishment).
                HasForeignKey(estNote => estNote.FK_EstablishmentId);

            HasMany(est => est.EstablishmentStatements).
                WithOptional(estStmnt => estStmnt.Establishment).
                HasForeignKey(estStmnt => estStmnt.FK_EstablishmentId);

            HasMany(est => est.Laborers).
                WithOptional(lab => lab.Establishment).
                HasForeignKey(lab => lab.FK_EstablishmentId);

            HasMany(est => est.OracleTransactionLogs).
                WithOptional(log => log.Establishment).
                HasForeignKey(log => log.FK_EstablishmentId);

            HasMany(est => est.Srv_Transactions).
                WithOptional(trns => trns.Establishment).
                HasForeignKey(trns => trns.FK_EstablishmentId);
        }
    }
}
