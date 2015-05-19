using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoL.Core.Domain.Representitives.Enums
{
    public enum CommissionerType:int
    {
        /// <summary> 
        /// مكتب خدمات
        /// </summary>
        ServiceOffice = 1,

        /// <summary> 
        /// مكتب استقدام أهلى
        /// </summary>
        ExpetriateOffice = 2,

        /// <summary> 
        /// شخص
        /// </summary>
        Laborer = 3
    }
}
