using System;
using System.Collections.Generic;
using System.Text;

namespace Fawry_Assessment.Classes
{
    class Speed_Limit_Rule : TrafficRules
    {
        private const int Private_Car_Speed_Limit = 80;
        private const int Bus_Speed_Limit = 70;
        private const int Truck_Speed_Limit = 60;

        public bool Compare_Speed(int speed, int speed_limit)
        {
            if (speed > speed_limit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Violations Evaluate(Physical_Radar_Info radarInfo)
        {
            string viechle_type = radarInfo.Viechle_Type;
            bool result;
            switch(viechle_type)
            {
                case "Private_Car":
                    result = Compare_Speed(radarInfo.Speed, Private_Car_Speed_Limit);
                    break;
                case "Bus":
                    result = Compare_Speed(radarInfo.Speed, Bus_Speed_Limit);
                    break;
                case "Truck":
                    result = Compare_Speed(radarInfo.Speed, Truck_Speed_Limit);
                    break;
            }

            if(result)
            {
                Violations Speed_Limit_Violation = new Violations("Speed Limit Violation", 150);
                return Speed_Limit_Violation;
            } 
            else
            {
                return null;
            }
        }

    }
}
