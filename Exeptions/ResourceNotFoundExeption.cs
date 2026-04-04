using System;

namespace OsonEats.Exeptions;

public class ResourceNotFoundExeption : Exception
{
    public ResourceNotFoundExeption(string message)
        : base(message) {} 
}