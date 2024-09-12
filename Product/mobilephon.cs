// using System 

// namespace Mobileprogram

// {
//     internal class Properties
//     {
//         private string Brand= " APPLE";
//         private int storage;
//         private int ram;
//         private string FrontCamera;
//         private string BcakCamera;

//         public Properties(int ram,int storage, string FrontCamera, string BackCamera)
//         {
//             ram = Ram;
//             storage = Storage;
//             FrontCamera = FCamera;
//             BackCamera = BCamera;
//         }
//         public void ON()
//         {
//          Console.WriteLine($"{brand} {modelName} is now powered on.");
//         }
//         public void OFF()
//         {
//             Console.WriteLine($"{brand} {modelName} is now powered off.");
//         }
//         public void RESTART()
//         {
//             console.writeLine($"{brand} {modelName} is now restart.");
//         }
//         public void CheckFrontCamera()
//         {
//             console.writeLine($"{brand} {modelName} FrontCamera is working.");
//         }
//          public void CheckBrontCamera()
//         {
//             console.writeLine($"{brand} {modelName} BackCamera is working.");
//         }
//         };
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             properties p1( 12 , 324 , "12 megapixal" , " 24 megapixal");


//             p1.ON();
//             p1.OFF();
//             p1.RESTART();
//             p1.checkFrontCamera();
//             p1.checkBackCamera();
//         }
//     };
// }


using System;

namespace Product
{
    internal class Properties
    {
        private string Brand = "APPLE";
        private int Storage;
        private int Ram;
        private string FrontCamera;
        private string BackCamera;

        public Properties(int ram, int storage, string frontCamera, string backCamera)
        {
            Ram = ram;
            Storage = storage;
            FrontCamera = frontCamera;
            BackCamera = backCamera;
        }

        public void ON()
        {
            Console.WriteLine($"{Brand} is now powered on.");
        }

        public void OFF()
        {
            Console.WriteLine($"{Brand} is now powered off.");
        }

        public void RESTART()
        {
            Console.WriteLine($"{Brand} is now restarting.");
        }

        public void CheckFrontCamera()
        {
            Console.WriteLine($"{Brand} Front Camera ({FrontCamera}) is working.");
        }

        public void CheckBackCamera()
        {
            Console.WriteLine($"{Brand} Back Camera ({BackCamera}) is working.");
        }
    }
}

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Properties p1 = new Properties(12, 324, "12 megapixels", "24 megapixels");

//             p1.ON();
//             p1.OFF();
//             p1.RESTART();
//             p1.CheckFrontCamera();
//             p1.CheckBackCamera();
//         }
//     }
// }

    
