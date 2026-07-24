using System;
using System.Collections.Generic;
using System.Text;

namespace Fawry_Assessment.Classes
{
    public class Physical_Radar_Info
    {
        public string Viechle_Type { get; set; }
        public string Plate_Number { get; set; }
        public int Speed { get; set; }
        public bool Seat_Belt { get; set; }

        public Physical_Radar_Info(
            string Viechle_Type,
            string Plate_Number,
            int Speed,
            bool Seat_Belt
            ) 
        {
            this.Viechle_Type = Viechle_Type;
            this.Plate_Number = Plate_Number;
            this.Speed = Speed;
            this.Seat_Belt = Seat_Belt;
        }
    }
}
