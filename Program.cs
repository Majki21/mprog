using System;

namespace mprog
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            StreamReader sr = null;
            sr = new StreamReader("/home/linuxmint/Desktop/doc");
            Console.WriteLine(sr.ReadToEnd());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
