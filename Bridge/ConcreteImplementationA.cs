﻿namespace Bridge;

internal class ConcreteImplementationA : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationA: The result in platform A.\n";
    }
}
