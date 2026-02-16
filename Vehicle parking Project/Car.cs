using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_parking_Project
{
    internal class Car : Vehicle
    {
        public Car() : base(10, 5)
        {
        }

        public override void PrintReceipt(double hours, double fees)
        {
            Console.WriteLine($"Car Receipt - ID: {Id} - Hours: {hours} - Total: {fees}$");
        }
    }
    
}
