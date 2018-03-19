using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.cs
{
    /// <summary>
    /// This class is implemanting the join method, which is available inside the Thread class.
    /// </summary>
    class ClsJoin
    {
        public void Thread1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(4000);
            }
        }
    }
    public class ThreadClass 
    {
        public static void Main()
        {
            ClsJoin mt = new ClsJoin();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            Thread t4 = new Thread(new ThreadStart(mt.Thread1));

            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
            t4.Start();

        }
    }
}

