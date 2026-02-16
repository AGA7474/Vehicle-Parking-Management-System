using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_parking_Project
{
    internal  abstract class Vehicle: IPrintable
    {
        private static int StaticID;
       
        public int Id { get; private set; }
        public int Price { get; private set; }

        public int Length { get; private set; }

        public Vehicle( int price, int length)
        {
           Id= ++StaticID;
            Price = price;
            Length = length;
        }

        public static void RollbackId()
        {
            StaticID--;
        }
        public virtual double CalcMoney(double NumOfHours)
        {
            return NumOfHours * Price;
        }

        public abstract void PrintReceipt(double hours, double fees);
        
    }
}
