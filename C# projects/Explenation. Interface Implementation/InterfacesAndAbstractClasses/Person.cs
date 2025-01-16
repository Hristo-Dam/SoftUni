using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    public abstract class Person : IRunning
    {
        public virtual void Run()
        {
            Console.WriteLine("I am running");
        }
    }
}
