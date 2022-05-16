using System;
namespace HMW_Design_Patterns
{
    public abstract class Garage
    {
        public static bool CarNeedRepair { get; set; }
        protected Garage Garage1;
        
        public Garage()
        {
        }

        public void NextCheck(Garage garage)
        {
            Garage1 = garage;
        }
        public abstract void HandleCar(Car car);
        
    }
}
