using System;

namespace Product
{
    internal class Laptop
    {
    
        private string cpuType;
        private int ram;
        private int secondaryStorage;
        private int gpuMemory;
        private string displayType;
        private string brand;
        private const string modelName="apple";

        //use constructor
        public Laptop(string cpuType, int ram, int secondaryStorage, int gpuMemory, string displayType, string brand)
        {
            this.cpuType = cpuType;
            this.ram = ram;
            this.secondaryStorage = secondaryStorage;
            this.gpuMemory = gpuMemory;
            this.displayType = displayType;
            this.brand = brand;
        
        }

        //For Ram Install
        public bool InstallOS()
        {
            CheckPrimaryForWindows();
            Console.WriteLine("Operating system installed successfully.");
            return true;
        }

        // Ram Update
        public void UpdateROM()
        {
            if (DownloadROMFromCorrectSource())
            {
                Console.WriteLine("ROM updated successfully.");
            }
            else
            {
                Console.WriteLine("Failed to update ROM. Incorrect source.");
            }
        }

        // For increasing RAM
        public void IncreaseRAM(int additionalRAM)
        {
            ram += additionalRAM;
            Console.WriteLine($"RAM increased by {additionalRAM}GB. Total RAM now: {ram}GB.");
        }

        //For On laptop
        public void On()
        {
            Console.WriteLine($"{brand} {modelName} is now powered on.");
            TweakBatteryBetweenAC_DC();
        }

        //For OFF Laptop
        public void Off()
        {
            Console.WriteLine($"{brand} {modelName} is now powered off.");
        }

        
        private void CheckPrimaryForWindows()
        {
            Console.WriteLine("Checking primary storage for Windows...");
        }


        // downloading ROM from a correct source
        private bool DownloadROMFromCorrectSource()
        {
            Console.WriteLine("Downloading ROM from the correct source...");
            return true; 
        }

        //  battery between AC and DC power
        private void TweakBatteryBetweenAC_DC()
        {
            Console.WriteLine("Tweaking battery settings between AC and DC power.");
        }
    }
}

//     class Program
//     {
//         static void Main(string[] args)
//         {
            
//             Laptop myLaptop = new Laptop("Intel i9", 16, 456, 4, "LED", "Dell");

//             myLaptop.On();
//             myLaptop.InstallOS();
//             myLaptop.IncreaseRAM(8); // Adding 8GB RAM
//             myLaptop.UpdateROM();
//             myLaptop.Off();
//         }
//     }
// }
