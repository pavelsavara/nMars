using System;
using System.Collections.Generic;
using System.Text;

namespace nMars.RedCode.Utils
{
    public class ExceptionHandler
    {
        public static int DumpException(Exception ex)
        {
            System.Console.Error.WriteLine(ex.StackTrace);
            do
            {
                System.Console.Error.WriteLine();
                System.Console.Error.WriteLine(ex.GetType().ToString());
                System.Console.Error.WriteLine(ex.Message);
                ex = ex.InnerException;
                if (ex == null)
                    break;
            } while (true);
            return -255;
        }
    }
}
