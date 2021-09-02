using System;
using System.Threading;


namespace MultiThreding_Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main started");

           Thread t1 = new Thread(Program.Thread1Function);
            t1.Start();

            Thread t2 = new Thread(Program.Thread2Function);
            t2.Start();

             Console.WriteLine("Main completed");
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
        }

       public static void Thread2Function()
       {
        Console.WriteLine("Thread2Function started");
       }
    }
}
