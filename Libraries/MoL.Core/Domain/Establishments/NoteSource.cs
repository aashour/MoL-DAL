using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoL.Core.Domain.Establishments
{
    public enum NoteSource
    {
        /// <summary> 
        /// القوى العاملة
        /// </summary>
        ManPower = 1,

        /// <summary> 
        /// التفتيش
        /// </summary>
        Inspection = 2,

        /// <summary> 
        /// القضايا
        /// </summary>
        Cases = 3,

        /// <summary> 
        /// توظيف
        /// </summary>
        Recruitment = 4,

        /// <summary> 
        /// حاسب الي
        /// </summary>
        Computer = 5

    }
}
