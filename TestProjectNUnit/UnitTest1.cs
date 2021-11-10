using System;
using NUnit.Framework;

namespace TestProjectNUnit;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Console.WriteLine("Hello, World!");
        new EngineCheck(r => Console.WriteLine(r)).Run();
        Console.WriteLine("All done");
    } 
    
    [Test]
    public void Silent()
    {
        new EngineCheck().Run();
    }
}