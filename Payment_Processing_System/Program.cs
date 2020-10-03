using System;

namespace Payment_Processing_System
{
    class Program
    {
        /// <summary>
        /// Main method - start point
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            //Display rule for PhysicalProduct.
            BusinessRulesEngineService businessRulesEngine = new BusinessRulesEngineService(new PhysicalProduct());
            string rule = businessRulesEngine.HandleOrder();
            Console.WriteLine("Rule for Physical Product is " + rule);

            //Display rule for Book.
            businessRulesEngine = new BusinessRulesEngineService(new Book());
            rule = businessRulesEngine.HandleOrder();
            Console.WriteLine("Rule for Book is " + rule);

            //Display rule for MemberShip.
            businessRulesEngine = new BusinessRulesEngineService(new MemberShip());
            rule = businessRulesEngine.HandleOrder();
            Console.WriteLine("Rule for MemberShip is " + rule);

            //Display rule for Upgrade to a MemberShip.
            businessRulesEngine = new BusinessRulesEngineService(new UpgradeMemberShip());
            rule = businessRulesEngine.HandleOrder();
            Console.WriteLine("Rule for UpgradeMemberShip is " + rule);

            //Display rule for  video “Learning to Ski”.
            businessRulesEngine = new BusinessRulesEngineService(new VideoLearningtoSki());
            rule = businessRulesEngine.HandleOrder();
            Console.WriteLine("Rule for Video \"Learning to Ski\" is " + rule);
            Console.ReadKey();
        }
    }
}
