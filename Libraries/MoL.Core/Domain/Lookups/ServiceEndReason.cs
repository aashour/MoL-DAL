using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Transactions;

namespace MoL.Core.Domain.Lookups
{
    public class ServiceEndReason:BaseEntity
    {
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<Laborer> _laborer_temp_2s { get; set; }
        public virtual ICollection<Laborer> Laborer_temp_2s
        {
            get { return _laborer_temp_2s ?? (_laborer_temp_2s = new List<Laborer>()); }
            protected set { _laborer_temp_2s = value; }
        }
        public virtual ICollection<Laborer> _laborers { get; set; }
        public virtual ICollection<Laborer> Laborers
        {
            get { return _laborers ?? (_laborers = new List<Laborer>()); }
            protected set { _laborers = value; }
        }
        public virtual ICollection<Laborer> _laborer_temps { get; set; }
        public virtual ICollection<Laborer> Laborer_temps
        {
            get { return _laborer_temps ?? (_laborer_temps = new List<Laborer>()); }
            protected set { _laborer_temps = value; }
        }
        public virtual ICollection<LaborerStatusServiceEndReason> _laborerStatusServiceEndReasons { get; set; }
        public virtual ICollection<STTempLaborer> _sTTempLaborer { get; set; }
    }
}
