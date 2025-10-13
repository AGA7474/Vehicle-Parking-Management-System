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
        Dictionary<int, bool> vehicleInParking = new Dictionary<int, bool>();
        Dictionary<int, Vehicle> vehiclesById = new Dictionary<int, Vehicle>();
        public ParkingManager()
        {
            for (int i = 0; i < TotalArea; i++)
            {
                ParkingSlots.Add(0);
            }

            for (int i = 0; i < 100; i++)
            {
              
               vehicleInParking[i] = false;
            }
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
        public void AddVehicle( Vehicle obj)
        {
            if (obj is Vehicle vehicle)
            {
                Console.WriteLine(vehicle.Length); 
                Console.WriteLine($"count = {ParkingSlots.Count}");
             
                if (CheckSpace(vehicle.Length)==-1)
                {
                    Vehicle.ID--;
                    Console.WriteLine("No space available for this vehicle.");
                    Console.WriteLine($"Only free space is {cnt} m\n");
                   
                    return;

                }
               
                int startIndex = CheckSpace(vehicle.Length);
                Console.WriteLine(startIndex);
                for (int i = startIndex; i < startIndex + vehicle.Length; i++)
                {
                    ParkingSlots[i] = Vehicle.ID; 
                }

                vehicleInParking[Vehicle.ID] = true;
                vehiclesById[Vehicle.ID] = vehicle;
                Console.WriteLine("Vehicle added successfully.");
                Console.WriteLine($"your Vehicle's ID is : {Vehicle.ID} \n");
            }
            else
            {
                Console.WriteLine("Invalid vehicle type.");
            }
        }

        public void RemoveVehicle(int id)
        {

            
            if ( id<=0 || vehicleInParking[id] == false)
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
                vehicleInParking[id] = false;
                Console.WriteLine("How long was your vehicle parked? Please enter the number of hours");
                double NumOfHours = int.Parse(Console.ReadLine());
                Console.WriteLine("Vehicle removed successfully.");
                Console.WriteLine($"The total parking fee is : {vehiclesById[id].calcMoney(NumOfHours)}");

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
                            Console.WriteLine($"{st}-->{st+counter-1} : {counter} m ,");
                            counter = 0;
                            st  = -1;
                        }
                    }
                }
                if (counter > 0)
                    Console.WriteLine($"{st}-->{st+counter - 1} : {counter} m ");
            }
            else
            {
                Console.WriteLine("No free slots available.\n");
            }

        }


    }
}
