using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class FileLogger
    {
        public static bool Feed(string message)
        {
            try
            {
                StreamWriter Object = new StreamWriter(@"C:\Users\Public\Documents\Readline", true);
                Object.WriteLine(message);
                Object.Close();
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(" Error Message : " + exception.Message);
                return false;
            }
        }
    }
    class MyException : Exception
    {
        public MyException(string Message) : base(Message)
        {
        }
    }
}