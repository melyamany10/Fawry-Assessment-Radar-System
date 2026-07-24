using System;
using System.Collections.Generic;
using System.Text;

namespace Fawry_Assessment.Classes
{
    class Seat_Belt_Rule : TrafficRules
    {
        private const int Seat_Belt_Violation_Fine = 100; 

        public Violations Evaluate(Physical_Radar_Info radarInfo)
        {
            if(radarInfo.Seat_Belt == false)
            {
                Violations Seat_Belt_Violation = new Violations("Seat Belt Violation", Seat_Belt_Violation_Fine);
                return Seat_Belt_Violation;
            } 
            else
            {
                return null;
            }
        }
    }
}
