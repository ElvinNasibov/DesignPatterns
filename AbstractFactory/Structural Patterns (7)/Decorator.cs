using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class AbstractComponent
    {
        public abstract void Operation();
    }

    class ConcreteComponenet : AbstractComponent
    {
        public override void Operation()
        {
            Console.WriteLine("Concrete Componenet Operation.");
        }
    }


    abstract class Decorator : AbstractComponent
    {
        public AbstractComponent component { protected get; set; }

        public override void Operation()
        {
            if (component != null)
                component.Operation();
        }
    }

    class ConcreteDecoratorA : Decorator
    {
        string someState = "Some State.";

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(someState);
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        protected void SomeBehavior()
        {
            Console.WriteLine("Some Behavior.");
        }

        public override void Operation()
        {
            base.Operation();
            SomeBehavior();
        }
    }

    /*
    //--------------------------- Decorator
    Console.WriteLine("--------------------------- Decorator");
            AbstractComponent someComponenet = new ConcreteComponenet();
    Decorator decoratorA = new ConcreteDecoratorA();
    Decorator decoratorB = new ConcreteDecoratorB();

    decoratorA.component = someComponenet;
    decoratorB.component = decoratorA;
    decoratorB.Operation();

    Console.ReadKey();
    */

}
