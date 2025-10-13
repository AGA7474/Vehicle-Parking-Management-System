using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vehicle_parking_Project
{

   
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t\t\t\tWelcome to the Vehicle Parking System!\n\n\n");
            ParkingManager manager = new ParkingManager();

               int operation = 0;
              
            while (operation != 4)
            {
                Console.WriteLine("Please select the operation you want to in the park:\n");

                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. Remove Vehicle");
                Console.WriteLine("3. Show Parking Status");
                Console.WriteLine("4. Exit\n");
                operation = int.Parse(Console.ReadLine());

                if (operation == 1) {
                    Console.WriteLine("Please select the type of vehicle you want to add:\n");
                    Console.WriteLine("1. Car");
                    Console.WriteLine("2. Bus");
                    Console.WriteLine("3. Motorcycle");
                    Console.WriteLine("4. Truck\n");

                    int vehicleType = int.Parse(Console.ReadLine());
                    
                   

                    switch (vehicleType)
                    {
                        case 1:
                            manager.AddVehicle(new Car());
                            break;
                        case 2:
                            manager.AddVehicle(new Bus());
                            break;
                        case 3:
                            manager.AddVehicle(new Motorcycle());
                            break;
                        case 4:
                            manager.AddVehicle(new Truck());
                            break;
                        default:
                            Console.WriteLine("Invalid vehicle type.");
                            break;
                    }
                   
                   

                }
                else if (operation == 2)
                {
                    Console.WriteLine("Please enter the ID of the vehicle to remove:");
                    int id = int.Parse(Console.ReadLine());
                    manager.RemoveVehicle(id);
                }
                else if (operation == 3)
                {
                    manager.ShowParkingStatus();
                }
                else if (operation == 4)
                {
                    Console.WriteLine("Exiting the system. Thank you!");
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please try again.");



                }

            }
            
            

           



        }
    }
}
