using System;
using System.Collections.Generic;
using System.Text;

namespace Fawry_Assessment.Classes
{
    public class QuRadar
    {
        public List<TrafficRules> TrafficRules;
        public Dictionary<string, int> Fines;
        public Dictionary<string, int> Violations_Count;
        public QuRadar(List<TrafficRules> trafficRules)
        {
            TrafficRules = trafficRules;
            Fines = new Dictionary<string, int>();
            Violations_Count = new Dictionary<string, int>();
        }

        public void reportAllViolationCount()
        {
            foreach (var violation_count in Violations_Count)
            {
                Console.WriteLine($"Viechle {violation_count.Key}: {violation_count.Value}");
            }
        }

        public void getAllTrafficRules()
        {
            foreach (var fine_count in Fines)
            {
                Console.WriteLine($"Viechle {fine_count.Key}: {fine_count.Value}");
                reportAllViolationCount();
            }
        }

        public void getSpecificViechleViolations(string viechleNumber)
        {
            if (Violations_Count.ContainsKey(viechleNumber))
            {
                Console.WriteLine($"Viechle {viechleNumber}: {Violations_Count[viechleNumber]}");
                foreach(var fine_count in Fines)
                {
                    if (fine_count.Key == viechleNumber)
                    {
                        Console.WriteLine($"Viechle {fine_count.Key}: {fine_count.Value}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"No violations found for viechle {viechleNumber}");
            }
        }
    }
}
