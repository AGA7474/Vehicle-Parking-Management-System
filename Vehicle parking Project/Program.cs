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
            ParkingManager manager = ParkingManager.GetObject();
            List<Type> VehiclesTypes = new List<Type>
                    {

                        typeof(Car),
                        typeof(Bus),
                        typeof(Motocycle),
                        typeof(Truck),

                    };
            int operation = 0;
              
            while (operation != 4)
            {
                Console.WriteLine("Please select the operation you want to in the park:\n");

                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. Remove Vehicle");
                Console.WriteLine("3. Show Parking Status");
                Console.WriteLine("4. Exit\n");
                  int.TryParse(Console.ReadLine(),out operation);

                if (operation == 1) {
                    
                    Console.WriteLine("Please select the type of vehicle you want to add:\n");

                  for(int i=0;i< VehiclesTypes.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {VehiclesTypes[i].Name} ");
                    }

                     int.TryParse(Console.ReadLine(),out int vehicleType);


                    
                    switch (vehicleType)
                    {
                        case 1:
                            manager.AddVehicle<Car>();
                            break;
                        case 2:
                            manager.AddVehicle<Bus>();
                            break;
                        case 3:
                            manager.AddVehicle< Motocycle>();
                            break;
                        case 4:
                            manager.AddVehicle<Truck>();
                            break;
                       
                        default:
                            Console.WriteLine("Invalid vehicle type.");
                            break;
                    }
                   
                   

                }
                else if (operation == 2)
                {
                    Console.WriteLine("Please enter the ID of the vehicle to remove:");
                    int.TryParse(Console.ReadLine(), out int id );
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
