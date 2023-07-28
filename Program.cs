using System;

class Program
{
    static void Main(string[] args)
    {
        Smartphone smartphone = new Smartphone();
        smartphone.Connect();
        smartphone.Charge(60);
        Console.WriteLine(smartphone.Display());

        Console.WriteLine();

        Laptop laptop = new Laptop();
        laptop.Connect();
        laptop.Charge(120);
        Console.WriteLine(laptop.Display());
    }
}