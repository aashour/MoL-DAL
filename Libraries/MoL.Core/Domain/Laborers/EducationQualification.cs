using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Laborers.Enums;

namespace MoL.Core.Domain.Laborers
{
   public  class EducationQualification:BaseEntity
    {
        public int? Qualification_Id { get; set; }

        public virtual EducationalStatus EducationalStatus { get; set; }
        public virtual Qualification Qualification { get; set; }
    }
}
