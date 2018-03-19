using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    /// <summary>
    ///  This class is implemanting the join method, which is available inside the Thread class
    /// </summary>
    class ClsThread
    {
        private static void Thread1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread1 is started " + i);
            }
            Console.WriteLine("Thread 1 exist");
        }
        private static void Thread2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread2 is started " + i);
            }
           
            Console.WriteLine("Thread 2 exist");
        }

        private static void Thread3()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread3 is rinning " +  i);
            }
            Thread.Sleep(400);
            Console.WriteLine("Thread 3 exist");
        }                       

        public  static void Main()
        {
            Console.WriteLine("Main thread Started ");
            Thread thread1 = new Thread(Thread1);
            Thread thread2 = new Thread(Thread2);
            Thread thread3 = new Thread(Thread3);
            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join(); 
            thread2.Join();
            thread3.Join(300);

            Console.WriteLine("Main thread exist");
            Console.ReadKey();
        }
    }
} 
