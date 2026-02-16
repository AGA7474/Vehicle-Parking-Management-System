using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_parking_Project;

namespace Vehicle_parking_Project
{
    
    internal class ParkingManager
    {
        int cnt = 0;
       const int TotalArea = 100;
        List<int> ParkingSlots = new List<int>();
        Dictionary<int, Vehicle> vehiclesById = new Dictionary<int, Vehicle>();
        static private ParkingManager Manager = new ParkingManager();
        private ParkingManager()
        {
            for (int i = 0; i < TotalArea; i++)
            {
                ParkingSlots.Add(0);
            }

        }

        public static ParkingManager GetObject()
        {
            return Manager;
        }

        private int CheckSpace(int size)
        {
             cnt = 0;
           
            for(int i = 0; i < ParkingSlots.Count; i++)
            {
                if (ParkingSlots[i] == 0)
                {
                    cnt++;
                }
                else
                {
                    cnt = 0;
                }
                if (cnt == size)
                {
                    return i - size + 1; //the start of area for book 

                }
            }
           
            return -1;
        }
        public void AddVehicle<T>() where T: Vehicle, new() 
        {

            T vehicle = new T();
            int startIndex = CheckSpace(vehicle.Length);
            if (startIndex == -1)
            {
                    
                    Console.WriteLine("No space available for this vehicle.");
                Vehicle.RollbackId();
                    ShowParkingStatus();
                   
                    return;

            }
               
               
               
                for (int i = startIndex; i < startIndex + vehicle.Length; i++)
                {
                    ParkingSlots[i] = vehicle.Id; 
                }

                vehiclesById[vehicle.Id] = vehicle;
                Console.WriteLine("Vehicle added successfully.");

                Console.WriteLine($"your Vehicle's ID is : {vehicle.Id} ");

               
                Console.WriteLine($"Your Vehicle take slots from {startIndex+1} to {startIndex+vehicle.Length}");
            
           
        }

        public void RemoveVehicle(int id)
        {

            
            if (!vehiclesById.ContainsKey(id))
            {
                Console.WriteLine("This vehicle is not in the parking lot.");
                return;
            }
            else
            {


                for (int i = 0; i < ParkingSlots.Count; i++)
                {
                    if (ParkingSlots[i] == id)
                    {
                        ParkingSlots[i] = 0;
                      
                    }
                }
                Vehicle vehicle = vehiclesById[id];
                Console.WriteLine("How long was your vehicle parked? Please enter the number of hours");
                double.TryParse(Console.ReadLine(), out double NumOfHours);
                vehicle.PrintReceipt(NumOfHours, vehicle.CalcMoney(NumOfHours));
                vehiclesById.Remove(id);
                Console.WriteLine("Vehicle removed successfully.");
            }
        }

        public void ShowParkingStatus()
        {
            int totalfreeSlots = ParkingSlots.Count(slot => slot == 0);
            Console.WriteLine($"Total occupied area : {ParkingSlots.Count-totalfreeSlots}");
            

            int firstFreeIndex = ParkingSlots.FindIndex(slot => slot == 0);
           
            if (firstFreeIndex != -1)
            {
                Console.WriteLine($"Total free slots: {totalfreeSlots}");
                int counter = 0;
                int st = firstFreeIndex;
               
                for (int i = firstFreeIndex; i < ParkingSlots.Count; i++)
                {
                    if (ParkingSlots[i] == 0)
                    {
                        if (counter == 0)
                        {
                            st = i;
                        }
                        counter++;
                       
                    }
                    else
                    {
                        if (st != -1 )
                        {
                            Console.WriteLine($"{st+1}-->{st+counter} : {counter} m ,");
                            counter = 0;
                            st  = -1;
                        }
                    }
                }
                if (counter > 0)
                    Console.WriteLine($"{st+1}-->{st+counter} : {counter} m ");
            }
            else
            {
                Console.WriteLine("No free slots available.\n");
            }

        }


    }
}
