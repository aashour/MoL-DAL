using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoL.Core.Domain.Laborers
{
    public enum WorkingHoursPreference
    {
        /// <summary> 
        /// عمل صباحي
        /// </summary>
        MorningShift = 1,

        /// <summary> 
        /// عمل مسائي
        /// </summary>
        AfterNoonShift = 2,

        /// <summary> 
        /// فترتين
        /// </summary>
        BothShifts = 3,

        /// <summary> 
        /// غير محدد
        /// </summary>
        NotYetDefined = 4,

        /// <summary> 
        /// لا أهتم
        /// </summary>
        Anytime = 5

    }
}
