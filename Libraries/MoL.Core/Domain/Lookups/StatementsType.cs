using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;

namespace MoL.Core.Domain.Lookups
{
    public class StatementsType : BaseEntity
    {
        public string Name { get; set; }

        private ICollection<EstablishmentStatement> _establishmentStatements { get; set; }
        public virtual ICollection<EstablishmentStatement> EstablishmentStatements
        {
            get { return _establishmentStatements ?? (_establishmentStatements = new List<EstablishmentStatement>()); }
            protected set { _establishmentStatements = value; }
        }
    }
}
