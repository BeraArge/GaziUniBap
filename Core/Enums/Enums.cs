using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Enums
{
    public enum MeasurementPeriodType
    {
        FirstMeasurement = 1,
        Week4 = 2,
        Week8 = 3,
        Week12 = 4
    }
    public enum MeasurementPointType
    {
        TenCmAboveElbow = 1,
        TenCmBelowElbow = 2,
        Wrist = 3,
        MetacarpophalangealJoint = 4
    }
}
