using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.cs
{
    class ClsNaming
    {
        public void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running");
        }
    }
    public class A
    {
        public static void Main()
        {
            ClsNaming obj1 = new ClsNaming();
            Thread t1 = new Thread(obj1.Thread1);
            Thread t2 = new Thread(obj1.Thread1);
            Thread t3 = new Thread(obj1.Thread1);
            t1.Name = "js";
            t2.Name = "bhupesh";
            t3.Name = "Payal";
            t1.Start();
            t2.Start();
            t3.Start();
            Console.Read();
        }
    }

}

