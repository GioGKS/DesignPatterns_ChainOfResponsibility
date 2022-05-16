using System;
using System.Collections.Generic;

namespace HMW_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Garage Excercise - Chain Responsibility
            Console.WriteLine("* * * * * * * * GARAGE EXCERCISE * * * * * * * *");
            Console.WriteLine();
            FirstCheck firstCheck = new FirstCheck();
            MechanicCheking CheckByMechanic = new MechanicCheking();
            ElectronicChecking Electric = new ElectronicChecking();
            DiagnosticChecking Diagnostic = new DiagnosticChecking();

            firstCheck.NextCheck(CheckByMechanic);
            CheckByMechanic.NextCheck(Electric);
            Electric.NextCheck(Diagnostic);
            Diagnostic.NextCheck(null);

            Car Car1 = new Car("BMW", "Green", false);
            Car Car2 = new Car("OPEL", "BLUE", true);
            Car Car3 = new Car("TOYOTA", "RED", true);
            Car Car4 = new Car("AUDI", "BLACK", false);
            Car Car5 = new Car("SEAT", "WHITE", true);

            firstCheck.HandleCar(Car1);
            firstCheck.HandleCar(Car2);
            firstCheck.HandleCar(Car3);
            firstCheck.HandleCar(Car4);
            firstCheck.HandleCar(Car5);

            //Clock Excercise - Singleton
            Console.WriteLine("\n");
            Console.WriteLine("* * * * * * * * CLOCK EXCERCISE * * * * * * * *");
            Console.WriteLine();
            var LuxuryClock = Clock.GetClock();
            LuxuryClock.GetTime();





        }
    }
}
