using nMars.Test;

namespace nMars.Starter
{
    internal class Program
    {
        private static void Main()
        {
            //ParserTest ptest = new ParserTest();
            //ptest.Single();

            EngineTest etest = new EngineTest();
            //etest.Single();
            etest.Pair();
            etest.Full();
        }
    }
}