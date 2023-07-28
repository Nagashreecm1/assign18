using System;

// Interface 1: IConnectable
public interface IConnectable
{
    bool Connect();
}

// Interface 2: IRechargeable
public interface IRechargeable
{
    void Charge(int minutes);
}

// Interface 3: IDisplayable
public interface IDisplayable
{
    string Display();
}

// Electronic Device 1: Smartphone
public class Smartphone : IConnectable, IRechargeable, IDisplayable
{
    private bool isConnected;
    private int batteryLevel;

    public Smartphone()
    {
        isConnected = false;
        batteryLevel = 0;
    }

    public bool Connect()
    {
        isConnected = true;
        Console.WriteLine("Smartphone connected!");
        return isConnected;
    }

    public void Charge(int minutes)
    {
        batteryLevel += minutes;
        Console.WriteLine($"Smartphone charged for {minutes} minutes.");
    }

    public string Display()
    {
        return "Smartphone: Battery Level = " + batteryLevel + "%";
    }
}

// Electronic Device 2: Laptop
public class Laptop : IConnectable, IRechargeable, IDisplayable
{
    private bool isConnected;
    private int batteryLevel;

    public Laptop()
    {
        isConnected = false;
        batteryLevel = 0;
    }

    public bool Connect()
    {
        isConnected = true;
        Console.WriteLine("Laptop connected!");
        return isConnected;
    }

    public void Charge(int minutes)
    {
        batteryLevel += minutes;
        Console.WriteLine($"Laptop charged for {minutes} minutes.");
    }

    public string Display()
    {
        return "Laptop: Battery Level = " + batteryLevel + "%";
    }
}