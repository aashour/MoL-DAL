using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Log;

namespace MoL.Core.Mapping.Log
{
    public partial class CWSCommentsTrackingMap : EntityTypeConfiguration<CWSCommentsTracking>
    {
        public CWSCommentsTrackingMap()
        {
            ToTable("MOL_CWSCommentsTracking", "dbo");
            HasKey(audit => audit.Id);
            Property(audit => audit.Id).HasColumnName("PK_RequestsComments");
            Ignore(audit => audit.Deleted);
            Ignore(audit => audit.CreatedOnUtc);
        }
    }
}
