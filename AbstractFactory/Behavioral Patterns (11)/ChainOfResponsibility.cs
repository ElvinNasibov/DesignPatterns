using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ChainOfResponsibility
    {

    }

    abstract class Handler
    {
        public Handler successor { get; set; }
       
        public abstract void Operation(int parameter);
    }

    class ConcreteHandler1 : Handler
    {
        public override void Operation(int parameter)
        {
            if (parameter == 1)
                Console.WriteLine("One");
            else if (successor != null)
                successor.Operation(parameter);
        }
    }

    class ConcreteHandler2 : Handler
    {
        public override void Operation(int parameter)
        {
            if (parameter == 2)
                Console.WriteLine("Two");
            else if(successor != null)
                successor.Operation(parameter);

        }
    }

    /*
    //--------------------------- ChainOfResponsibility
    Console.WriteLine("--------------------------- ChainOfResponsibility");
    Handler concreteHandler1 = new ConcreteHandler1();
    Handler concreteHandler2 = new ConcreteHandler2();

    concreteHandler1.successor = concreteHandler2;
    concreteHandler1.Operation(1);
    concreteHandler1.Operation(2);
    */

}
