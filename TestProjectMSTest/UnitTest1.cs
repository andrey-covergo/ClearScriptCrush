using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectMSTest
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Hello, World!");
            new EngineCheck(r => Console.WriteLine(r)).Run();
            Console.WriteLine("All done");
        }


        [TestMethod]
        public void Silent()
        {
            new EngineCheck().Run();
        }
    }
}