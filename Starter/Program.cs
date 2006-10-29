using System;
using System.Collections.Generic;
using nMars.pMarsDll;
using nMars.RedCode;
using nMars.SimpleEngine;
using Parser.Test;

namespace nMars.Starter
{
    internal class Program
    {
        private static void Main()
        {
            ParserTest t = new ParserTest();
            //t.Loader();
            //return;

            Rules rules = new Rules();

            //nMarsParser parser = new nMarsParser(rules);
            pMarsDllParser parser = new pMarsDllParser(rules);
            List<IWarrior> rr = new List<IWarrior>();
            List<int> forcedaddr = new List<int>();

            rr.Add(parser.Parse(@"D:\Zamboch\Zdrojaky\nMars\Warriors\warriors\corewin\bluefunk.red"));
            rr.Add(parser.Parse(@"D:\Zamboch\Zdrojaky\nMars\Warriors\warriors\pmars\rave.red"));
            //rr.Add(parser.Parse(@"D:\Zamboch\Zdrojaky\nMars\Warriors\warriors\2test\mod1test.rc"));
            //rr.Add(parser.Parse(@"D:\Zamboch\Zdrojaky\nMars\Warriors\warriors\pmars\validate.red"));
            //forcedaddr.Add(0);

            //Engine se = new Engine();
            pMarsDllEngine pe=new pMarsDllEngine();
            PSpaces spaces = new PSpaces();
            Random r = new Random(0);
            pe.Run(rules, rr, spaces, r, forcedaddr);

            /*
            Rules rules = new Rules();
            Engine se = new Engine();
            RedCodeParser parser = new RedCodeParser(rules);
            List<IWarrior> rr = new List<IWarrior>();
            List<int> forcedaddr=new List<int>();
            rr.Add(parser.Load(@"D:\Zamboch\Zdrojaky\nMars\rc\pmars\validate.red"));
            forcedaddr.Add(10);
            //rr.Add(parser.Load(@"..\..\..\rc\blur\Ikarus.rc"));
            //rr.Add(parser.Load(@"..\..\..\rc\scanner\mischief.rc"));
            PSpaces spaces = new PSpaces();
            Random r = new Random(0);
            se.Run(rr, rules, spaces, r, forcedaddr);
             */
            //Console.WriteLine("\n\nDone");
            //Console.ReadKey();
        }
    }
}