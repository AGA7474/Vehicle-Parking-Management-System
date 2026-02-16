using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_parking_Project
{
    internal class Motocycle : Vehicle
    {
        public Motocycle() : base( 5, 2)
        {
        }

        public override void PrintReceipt(double hours, double fees)
        {
            Console.WriteLine($"Motorcycle Receipt - ID: {Id} - Hours: {hours} - Total: {fees}$");
        }
    }
  
}
