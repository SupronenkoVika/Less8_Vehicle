using Less8_Vehicle;

SportCar car = new SportCar(0, 2);
Truck truck = new Truck(0, 6);

Console.WriteLine("SportCar");
car.Refuel(100);
car.Drive(30);
car.Drive(70);
car.Refuel(80);
car.Drive(20);

Console.WriteLine("\n");
Console.WriteLine("Truck");
truck.Refuel(280);
truck.Drive(40);
truck.Drive(50);
truck.Refuel(20);
truck.Drive(50);


