using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_parking_Project
{
    internal class Truck : Vehicle
    {

        public Truck() : base(15,7)
        {
            
        }

        public override void PrintReceipt(double hours, double fees)
        {
            Console.WriteLine($"Truck Receipt - ID: {Id} - Hours: {hours} - Total: {fees}$");
        }
    }
}
