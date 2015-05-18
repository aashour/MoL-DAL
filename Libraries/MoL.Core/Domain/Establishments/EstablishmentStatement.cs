using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Domain.Establishments
{
    public class EstablishmentStatement : BaseEntity
    {
        public long FK_EstablishmentId { get; set; }
        public short FK_StatementTypeId { get; set; }
        public string StatementNumber { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Source { get; set; }
        public string CancellationNo { get; set; }
        public DateTime? CancellationDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }

        public virtual StatementsType StatementsType { get; set; }
        public virtual Establishment Establishment { get; set; }
    }
}
