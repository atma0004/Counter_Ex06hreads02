using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex05_Tuesday_5
{
    class Program
    {
       
        static object _lock = new object();
        static void Main(string[] args)
        {
            
            Thread myThread1 = new Thread(new ThreadStart(counter1));
            Thread myThread2 = new Thread(new ThreadStart(counter2));

            myThread1.Start();
            myThread2.Start();
            myThread1.Join();
            myThread2.Join();
        }

        public static void counter1()
        {
            
            int i;
            for ( i = 1; i <= 10; i++)
            {
                
                    Console.WriteLine("The next number to be picked:" + i);
                    Thread.Sleep(1000);
                
            }


        }
        public static void counter2()
        {


            
            for (int i = 1; i <= 10; i++)
            {
                Monitor.Enter(_lock);
                try
                {
                    Console.WriteLine("Now handling: " + i);
                    Thread.Sleep(1500);
                    if (i == 10||i==5)
                    {
                        Console.WriteLine("no customers are served (the clerk sleep)");
                    }

                }
                finally
                {
                    Monitor.Exit(_lock);
                }
                
            }

        }








    }
}