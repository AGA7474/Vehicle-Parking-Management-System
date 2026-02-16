using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_parking_Project
{
    internal  abstract class Vehicle
    {
        public static int ID = 0;
       
    public int Price { get; private set; }

        public int Length { get; private set; }

        public Vehicle( int price, int length)
        {
            ++ID;
            Price = price;
            Length = length;
        }
        public virtual double calcMoney(double NumOfHours)
        {
            return NumOfHours * Price;
        }

    }
}
