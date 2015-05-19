using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoL.Core.Domain.Establishments.Enums
{
    public enum NoteApplicability : int
    {
        /// <summary> 
        /// المنشأة
        /// </summary>
        Establishment = 1,

        /// <summary> 
        /// جميع فروع المنشأة في مكتب العمل
        /// </summary>
        AllEstablishmentUnderLaborOffirce = 2,

        /// <summary> 
        /// جميع فروع المنشأة في جميع المكاتب
        /// </summary>
        AllEstablishment = 3
    }
}
