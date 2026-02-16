# 🚗 Vehicle Parking System (Console App)

A robust, enterprise-level C# Console Application designed to manage a vehicle parking facility with high efficiency. This project showcases advanced **Object-Oriented Programming (OOP)** implementation and clean code principles.

## 🌟 Key Technical Highlights
This project isn't just a simple manager; it implements complex architectural patterns:
* **Singleton Pattern**: Ensures a single, centralized `ParkingManager` instance throughout the application using a private constructor and a `GetObject()` method.
* **Generics & Constraints**: Implements a type-safe `AddVehicle<T>` method using generic constraints (`where T : Vehicle, new()`) to handle object creation within the manager.
* **Interfaces**: Uses the `IPrintable` interface to decouple printing logic, ensuring every vehicle knows how to print its own receipt.
* **Advanced Logic**: Features dynamic slot allocation with range-based free space tracking.

## 🛠️ Features
* **Vehicle Registration**: Support for multiple vehicle types (Car, Bus, Motorcycle, Truck).
* **Smart Allocation**: Automated starting slot calculation based on vehicle length to optimize parking space.
* **Encapsulated ID Management**: Private static ID generation in `Vehicle` class with a `RollbackId` capability to maintain ID integrity during failed operations.
* **Stability**: Robust user input handling using `int.TryParse` and `double.TryParse` to prevent runtime crashes.
* **Dynamic Status Dashboard**: Visual representation of occupied vs. free parking segments with specific ranges.

## 💻 Technologies Used
* **Language**: C# 
* **Framework**: .NET Framework 4.7.2
* **Architecture**: Object-Oriented Programming (OOP)
* **Tools**: Visual Studio

## 📂 Project Structure
* `Vehicle.cs`: The abstract base class implementing `IPrintable` and providing the blueprint for all vehicles.
* `ParkingManager.cs`: The core engine managing the Singleton instance, dictionaries for O(1) lookups, and slot lists.
* `IPrintable.cs`: The contract for ticket generation logic.
* `Program.cs`: The UI layer that interacts with the user and dynamically generates menus based on object types.

## 🚀 How to Run
1. Clone the repository to your local machine.
2. Open the `Vehicle parking Project.sln` file in **Visual Studio**.
3. Build the project to restore dependencies.
4. Press **F5** or click **Start** to run the application.

---
**Developed with ❤️ by a passionate C# Developer.**
