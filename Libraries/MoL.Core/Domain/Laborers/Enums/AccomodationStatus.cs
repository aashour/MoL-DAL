using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoL.Core.Domain.Laborers.Enums
{
    public enum AccomodationStatus
    {
        /// <summary> 
        /// صدر للعامل اقامة
        /// </summary>
        ResidencePermitIssued = 1,

        /// <summary> 
        /// لم يصدر له اقامة
        /// </summary>
        ResidencePermitNotIssued = 2,

        /// <summary> 
        /// غير مقدر
        /// </summary>
        ResidencePermitNotSpecified = 3,

        /// <summary> 
        /// ليس له اقامة
        /// </summary>
        NoResidencePermit = 4

    }
}
