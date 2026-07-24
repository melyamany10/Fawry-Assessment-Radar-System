using System;
using System.Collections.Generic;
using System.Text;

namespace Fawry_Assessment.Classes
{
    public interface TrafficRules
    {
        Violations Evaluate(Physical_Radar_Info radarInfo);
    }
}
