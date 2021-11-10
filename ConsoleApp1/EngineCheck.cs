using Microsoft.ClearScript.V8;

class EngineCheck
{
    public void Run(int iterations)
    {
        using var engine = new V8ScriptEngine();
        engine.Evaluate( @"
                         function createString (obj) {
                            return JSON.stringify(obj);
                         }               
            ");
            
        foreach (int n in Enumerable.Range(0, 20000))
        {
            var obj = new {Number = n, Text = "some string string"};
            string scriptOutput = engine.Script.createString(obj);
            Console.WriteLine(scriptOutput);
        }
    }
}