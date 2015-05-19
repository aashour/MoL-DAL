using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoL.Core.Domain.Establishments.Enums
{
    public enum NoteType
    {
        /// <summary> 
        /// تنبيه
        /// </summary>
        Warning = 1,

        /// <summary> 
        /// إيقاف خدمة
        /// </summary>
        StopService = 2,

        /// <summary> 
        /// جميع فروع المنشأة في جميع المكاتب
        /// </summary>
        AllEstablishment = 3

    }
}
