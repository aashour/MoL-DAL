using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Lookups
{
    public class Nationality:BaseEntity
    {
        public string Name { get; set; }
        public string Name_EN { get; set; }
        public bool? IsIncludedForEWV { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsBanForFollowerTransfer { get; set; }

        private ICollection<Origin> _origins { get; set; }
        public virtual ICollection<Origin> Origins
        {
            get { return _origins ?? (_origins = new List<Origin>()); }
            protected set { _origins = value; }
        }
        private ICollection<Laborer> _laborers { get; set; }
        public virtual ICollection<Laborer> Laborers
        {
            get { return _laborers ?? (_laborers = new List<Laborer>()); }
            protected set { _laborers = value; }
        }
        private ICollection<Owner> _owners { get; set; }
        public virtual ICollection<Owner> Owners
        {
            get { return _owners ?? (_owners = new List<Owner>()); }
            protected set { _owners = value; }
        }
        private ICollection<UnifiedNumber> _unifiedNumbers { get; set; }
        public virtual ICollection<UnifiedNumber> UnifiedNumbers
        {
            get { return _unifiedNumbers ?? (_unifiedNumbers = new List<UnifiedNumber>()); }
            protected set { _unifiedNumbers = value; }
        }
        private ICollection<User> _users { get; set; }
        public virtual ICollection<User> Users
        {
            get { return _users ?? (_users = new List<User>()); }
            protected set { _users = value; }
        }
    }
}
