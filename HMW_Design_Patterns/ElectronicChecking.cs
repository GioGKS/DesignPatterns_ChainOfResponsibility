using System;
namespace HMW_Design_Patterns
{
    public class ElectronicChecking : Garage
    {
        public ElectronicChecking()
        {
        }

        public override void HandleCar(Car car)
        {
            int num = new Random().Next(1, 10);
            if (num >= 6)
            {
                CarNeedRepair = false;
                Console.WriteLine("Car Don'T Need Repair! You Are Ready to Go! - From Electronic Checking");
            }
            if (Garage1 != null)
            {
                Garage1.HandleCar(car);
            }
            else
            {
                Console.WriteLine("Your Car Is Fix,Without Any Problems,You can Go. - From Electronic Checking");
            }
        }
    }
}
