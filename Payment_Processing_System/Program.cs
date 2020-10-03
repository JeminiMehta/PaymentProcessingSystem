using System;

namespace Payment_Processing_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            BusinessRulesEngineService businessRulesEngine = new BusinessRulesEngineService(new PhysicalProduct());
            string rule = businessRulesEngine.HandleOrder();
            Console.WriteLine(rule);
            Console.ReadKey();
        }
    }
}
