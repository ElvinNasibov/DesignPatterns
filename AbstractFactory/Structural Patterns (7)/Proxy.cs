using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    abstract class Subject
    {
        public abstract void Operation();
    }

    class Original : Subject
    {
        public override void Operation()
        {
            Console.WriteLine("Do Smth");
        }
    }

    class Proxy : Subject 
    {
        Subject surrogate = null;

        public Proxy()
        {
            if (surrogate == null)
                surrogate = new Original();
        }
        public Proxy(Subject original)
        {
            this.surrogate = original;
        }

        public override void Operation()
        {
            surrogate.Operation();
        }

    }

    /*
    //--------------------------- Proxy
    Console.WriteLine("--------------------------- Proxy");
    //Subject original = new Original();
    //Subject proxy = new Proxy(original);
    //proxy.Operation();

    Subject anotherProxy = new Proxy();
    anotherProxy.Operation();
    */


}
