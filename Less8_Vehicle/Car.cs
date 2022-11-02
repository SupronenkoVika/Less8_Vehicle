namespace Less8_Vehicle
{
    abstract class Car : IVehicle
    {
        private int BenzInitial { get; set; }
        private int FuelRate { get; set; }

        public Car(int benzInitial, int fuelRate)
        {
            BenzInitial = benzInitial;
            FuelRate = fuelRate;
        }
        public void Drive(int dist)
        {
            int benzAmount = dist * FuelRate;
            if (benzAmount > BenzInitial)
            {
                Console.WriteLine("Need refueling");
                int need = benzAmount - BenzInitial;
                Console.WriteLine("Need to refuel: " + need);
            }
            else
            {
                Console.WriteLine("Drive");
            }
        }
        public bool Refuel(int benzAmount)
        {
            BenzInitial += benzAmount;
            return true;
        }
    }
}
