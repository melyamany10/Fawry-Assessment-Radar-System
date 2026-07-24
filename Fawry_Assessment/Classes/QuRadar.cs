using Fawry_Assessment.Classes;

public class QuRadar
{
    public List<TrafficRules> TrafficRules;

    public Dictionary<string, List<Violations>> Vehicle_History; //must save the details of each car violations for reporting

    public Dictionary<string, int> Violations_Count;

    public QuRadar(List<TrafficRules> trafficRules)
    {
        TrafficRules = trafficRules;
        Vehicle_History = new Dictionary<string, List<Violations>>();
        Violations_Count = new Dictionary<string, int>();
    }

    public void ProcessObservation(Physical_Radar_Info radarInfo)
    {
        List<Violations> currentViolations = new List<Violations>();
        int currentTotalFine = 0;

        foreach (var rule in TrafficRules)
        {
            Violations v = rule.Evaluate(radarInfo);
            if (v != null)
            {
                currentViolations.Add(v);
                currentTotalFine += v.Fine_Value;

                if (Violations_Count.ContainsKey(v.Violations_Description))
                    Violations_Count[v.Violations_Description]++;
                else
                    Violations_Count[v.Violations_Description] = 1;
            }
        }

        if (currentViolations.Count > 0)
        {
            if (!Vehicle_History.ContainsKey(radarInfo.Plate_Number))
            {
                Vehicle_History[radarInfo.Plate_Number] = new List<Violations>();
            }
            Vehicle_History[radarInfo.Plate_Number].AddRange(currentViolations);

            Console.WriteLine($"Traffic for car {radarInfo.Plate_Number}");
            Console.WriteLine($"Total amount: {currentTotalFine} EGP");
            Console.WriteLine("Violations:");
            foreach (var v in currentViolations)
            {
                Console.WriteLine($"- {v.Violations_Description} : {v.Fine_Value} EGP");
            }
            Console.WriteLine();
        }
    }

    public void getAllPossibleFines() 
    {
        Console.WriteLine("--- every singe associated fine for specific viechle ---");
        foreach (var record in Vehicle_History)
        {
            string plate = record.Key;
            List<Violations> history = record.Value;

            int totalFineForCar = 0;
            foreach (var v in history)
            {
                totalFineForCar += v.Fine_Value;
            }

            Console.WriteLine($"Plate: {plate} | Total Fines: {totalFineForCar} EGP");
        }
    }
}