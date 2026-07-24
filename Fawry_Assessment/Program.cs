using Fawry_Assessment.Classes;

class Program
{
    static void Main(string[] args)
    {

        List<TrafficRules> activeRules = new List<TrafficRules>
        {
            new Seat_Belt_Rule(),
            new Speed_Limit_Rule()
        };

        QuRadar radar = new QuRadar(activeRules);
        bool systemRunning = true;

        Console.WriteLine("========================================");
        Console.WriteLine("    QURADAR SYSTEM INITIALIZED          ");
        Console.WriteLine("========================================");

        while (systemRunning)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Process Car info");
            Console.WriteLine("2. Fetch all posible fines");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Car Type (Private_Car/Truck/Bus): ");
                    string Viechle_Type = Console.ReadLine();

                    Console.Write("Enter Plate Number: ");
                    string Plate_Number = Console.ReadLine();

                    Console.Write("Enter Speed: ");
                    int Speed = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Seatbelt Fastened? (y/n): ");
                    bool Seat_Belt = Console.Read() == 'y' ? true : false;


                    Physical_Radar_Info radarInfo = new Physical_Radar_Info(Viechle_Type, Plate_Number, Speed, Seat_Belt);

                    radar.ProcessObservation(radarInfo);
                    Console.WriteLine("Car processed.");
                    break;

                case "2":
                    radar.getAllPossibleFines();
                    break;

                case "3":
                    systemRunning = false;
                    Console.WriteLine("Shutting down QuRadar...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}