using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoL.Core.Domain.Laborers
{
    public enum JobAvailability
    {
        /// <summary> 
        /// اي وقت
        /// </summary>
        Anytime = 1,

        /// <summary> 
        /// خلال الشهر القادم
        /// </summary>
        DuringNextMonth = 2,

        /// <summary> 
        /// خلال الثلاثة أشهر القادمة
        /// </summary>
        DuringNextThreeMonth = 3,

        /// <summary> 
        /// بعد الثلاثة أشهر القادمة
        /// </summary>
        MoreThanThreeMonth = 4,

        /// <summary> 
        /// غير محدد
        /// </summary>
        NotYetDefined = 5

    }
}
