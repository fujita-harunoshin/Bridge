﻿namespace Bridge;

internal class Program
{
    static void Main(string[] args)
    {
        var client = new Client();

        Abstraction abstraction;

        abstraction = new Abstraction(new ConcreteImplementationA());
        client.ClientCode(abstraction);

        Console.WriteLine();

        abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
        client.ClientCode(abstraction);
    }
}
