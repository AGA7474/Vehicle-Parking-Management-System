using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_parking_Project
{
    public interface IPrintable
    {
        void PrintReceipt(double hours, double fees);
    }
}
