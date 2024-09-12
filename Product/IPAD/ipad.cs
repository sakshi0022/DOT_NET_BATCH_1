using System;

public class iPadProperties
{
    public string ModelName { get; set; }
    public string ModelNumber { get; set; }
    public string DisplaySize { get; set; }
    public string Processor { get; set; }
    public int Storage { get; set; }
    public int Ram { get; set; }
    public string RearCamera { get; set; }
    public string FrontCamera { get; set; }
    public string BatteryLife { get; set; }

    public iPadProperties(string modelName, string modelNumber, string displaySize, string processor, int storage, int ram, string rearCamera, string frontCamera, string batteryLife)
    {
        ModelName = modelName;
        ModelNumber = modelNumber;
        DisplaySize = displaySize;
        Processor = processor;
        Storage = storage;
        Ram = ram;
        RearCamera = rearCamera;
        FrontCamera = frontCamera;
        BatteryLife = batteryLife;
    }

    public void DisplayProperties()
    {
        Console.WriteLine($"Model Name: {ModelName}");
        Console.WriteLine($"Model Number: {ModelNumber}");
        Console.WriteLine($"Display Size: {DisplaySize}");
        Console.WriteLine($"Processor: {Processor}");
        Console.WriteLine($"Storage: {Storage} GB");
        Console.WriteLine($"RAM: {Ram} GB");
        Console.WriteLine($"Rear Camera: {RearCamera}");
        Console.WriteLine($"Front Camera: {FrontCamera}");
        Console.WriteLine($"Battery Life: {BatteryLife}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        iPadProperties iPadAir = new iPadProperties("iPad Air", "A2316", "10.9 inches", "A14 Bionic", 256, 6, "12MP", "7MP", "Up to 10 hours");
        iPadAir.DisplayProperties();
    }
}