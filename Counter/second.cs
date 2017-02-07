using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex05_Tuesday_5
{
    class second
    {
        
        //private object _lock = new object();
        
        public  void counter3()
        {

            int i;
            for (i = 1; i <= 10; i++)
            {

                Console.WriteLine("The next number to be picked from second counter:" + i);
               Thread.Sleep(1000);
                

            }


        }
        public  void counter4()
        {



            for (int i = 1; i <= 10; i++)
            {

                
                try
                {
                    Console.WriteLine("Now handling second counter: " + i);
                    
                    Thread.Sleep(2000);
                    if (i == 10)
                    {

                        Console.WriteLine("no customers are served (the clerk sleep) from second counter");
                    }
                    if (i == 3)
                    {
                        Console.WriteLine("no customers are served it is break time from second counter");
                    }
                }
                finally
                {
                    
                }

            }

        }








    }
}
