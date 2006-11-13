using nMars.Test;

namespace nMars.Starter
{
    internal class Program
    {
        private static void Main()
        {
            /*ParserTest ptest = new ParserTest();
            ptest.Single();
            ptest.Full();
            Console.WriteLine("Parse test done");
            */

            EngineTest etest = new EngineTest();
            //etest.Single();
            //etest.Pair();
            etest.Full();
        }
    }
}