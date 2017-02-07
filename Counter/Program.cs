using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex05_Tuesday_5
{
    class Program
    {
       //static Random rd = new Random();
        static object _lock = new object();
        static void Main(string[] args)
        {
            second sc = new second();
            Thread myThread1 = new Thread(new ThreadStart(counter1));
            Thread myThread3 = new Thread(new ThreadStart(sc.counter3));
            Thread myThread2 = new Thread(new ThreadStart(counter2));
            Thread myThread4 = new Thread(new ThreadStart(sc.counter4));

            myThread1.Start();
            myThread3.Start();
            myThread2.Start();
            myThread4.Start();
            myThread1.Join();
            myThread2.Join();
            myThread3.Join();
            myThread4.Join();
        }

        public static void counter1()
        {
            
            int i;
            for ( i = 1; i <= 10; i++)
            {
                
                    Console.WriteLine("The next number to be picked:" + i);
               
                Thread.Sleep(500);

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
                    
                   Thread.Sleep(1000);
                    if (i == 10)
                    {
                        
                        Console.WriteLine("no customers are served (the clerk sleep)");
                    }
                    if (i == 3)
                    {
                        Console.WriteLine("no customers are served it is break time");
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