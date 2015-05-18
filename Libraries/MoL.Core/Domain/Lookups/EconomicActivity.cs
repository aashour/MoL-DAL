using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;

namespace MoL.Core.Domain.Lookups
{
    public class EconomicActivity : BaseEntity
    {
        public string ActivityName { get; set; }
        public Nullable<int> FK_MainEconomicActivityId { get; set; }
        public float SaudizationPercentage { get; set; }
        public bool IsSocialInsuranceLicenseFree { get; set; }
        public bool IsZakatLicenseFree { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual EconomicActivity ParentEconomicActivity { get; set; }

        private ICollection<EconomicActivity> _economicActivities { get; set; }
        public virtual ICollection<EconomicActivity> EconomicActivities
        {
            get { return _economicActivities ?? (_economicActivities = new List<EconomicActivity>()); }
            protected set { _economicActivities = value; }
        }
        private ICollection<Establishment> _establishments { get; set; }
        public virtual ICollection<Establishment> Establishments
        {
            get { return _establishments ?? (_establishments = new List<Establishment>()); }
            protected set { _establishments = value; }
        }
    }
}
