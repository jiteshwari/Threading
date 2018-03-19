using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading 
{
    class ThreadEx
    {
        public void Thread1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(300);
            }
        } 
 
    }
    public class Property
    {
        public static void Main()
        {
            ThreadEx  obj1  = new ThreadEx();
            Thread t1 = new Thread(new ThreadStart(obj1.Thread1));
            Thread t2 = new Thread(new ThreadStart(obj1.Thread1));
            Thread t3 = new Thread(new ThreadStart(obj1.Thread1));

            t1.Start();
            t2.Start();
            t3.Start();
            Console.Read();


        }
    } 
}
