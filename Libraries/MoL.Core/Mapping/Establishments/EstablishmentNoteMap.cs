using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;

namespace MoL.Core.Mapping.Establishments
{
    public partial class EstablishmentNoteMap : EntityTypeConfiguration<EstablishmentNote>
    {
        public EstablishmentNoteMap()
        {
            ToTable("MOL_EstablishmentNote", "dbo");
            HasKey(estNote => estNote.Id);
            Property(estNote => estNote.Id).HasColumnName("PK_EstablishmentNoteId");
            Ignore(estNote => estNote.Deleted);
            Ignore(estNote => estNote.CreatedOnUtc);
        }
    }
}
