using System;
namespace HMW_Design_Patterns
{
    public class Car
    {
        public string CarBrand { get; set; }
        public string Color { get; set; }
        public bool NeedRepair;

        
        public Car(string carBrand, string color, bool needRepair)
        {
            CarBrand = carBrand;
            Color = color;
            NeedRepair = needRepair;
        }
    }
}
