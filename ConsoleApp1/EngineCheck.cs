using System;
using System.Linq;
using Microsoft.ClearScript.V8;

namespace ConsoleApp1
{
    public class EngineCheck
    {
        private readonly Action<string> _workCompleteCallback;

        public EngineCheck(Action<string>? workCompleteCallback = null)
        {
            _workCompleteCallback = workCompleteCallback ?? (Action<string>) (s => { });
        }

        public void Run(int iterations = 20000)
        {
            using var engine = new V8ScriptEngine();
            engine.Evaluate(@"
                         function createString (obj) {
                            return JSON.stringify(obj);
                         }               
            ");

            foreach (int n in Enumerable.Range(0, iterations))
            {
                var obj = new {Number = n, Text = "some string string"};
                string scriptOutput = engine.Script.createString(obj);
                _workCompleteCallback(scriptOutput);
            }
        }
    }
}