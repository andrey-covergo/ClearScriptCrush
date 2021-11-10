using ConsoleApp1;
using Xunit;
using Xunit.Abstractions;

namespace TestProjectXUnit
{

    public class UnitTest1
    {
        private readonly ITestOutputHelper _output;

        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void With_output()
        {
            _output.WriteLine("start");
            new EngineCheck(r => _output.WriteLine(r)).Run();
            _output.WriteLine("end");
        }

        [Fact]
        public void Silent()
        {
            _output.WriteLine("start");
            new EngineCheck().Run();
            _output.WriteLine("end");
        }
    }
}