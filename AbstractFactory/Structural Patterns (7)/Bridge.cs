using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Bridge
    {

    }

    //--------------------------------------------------------
    abstract class Implementor
    {
        public abstract string SomeOperation();

    }
    abstract class Abstract
    {
        protected Implementor implementor;

        public Abstract(Implementor imp)
        {
            this.implementor = imp;
        }

        public virtual string DoSomething()
        {
            return implementor.SomeOperation();
        }

    }
    //--------------------------------------------------------

    class ConcreteImp1 : Implementor
    {
        public override string SomeOperation()
        {
            return "Imp1";
        }
    }
    class ConcreteImp2 : Implementor
    {
        public override string SomeOperation()
        {
            return "Imp2";
        }
    }

    //--------------------------------------------------------

    class RefinedAbstract1 : Abstract
    {
        public RefinedAbstract1(Implementor imp) : base(imp)
        {

        }

        public override string DoSomething()
        {
            return "RefinedAbstract1 is doing smth. with " + base.DoSomething();
        }

    }


    class RefinedAbstract2 : Abstract
    {
        public RefinedAbstract2(Implementor imp) : base(imp)
        {

        }

        public override string DoSomething()
        {
            return "RefinedAbstract2 is doing different things with " + base.DoSomething();
        }

    }

    /*
    
    public static void Main()
    {
        //--------------------------- Bridge
        Console.WriteLine("--------------------------- Bridge");           
        Abstract AnotherAbs11 = new RefinedAbstract1(new ConcreteImp1());
        Console.WriteLine(AnotherAbs11.DoSomething());
            
        Abstract AnotherAbs21 = new RefinedAbstract2(new ConcreteImp1());
        Console.WriteLine(AnotherAbs21.DoSomething());

        Abstract AnotherAbs12 = new RefinedAbstract1(new ConcreteImp2());
        Console.WriteLine(AnotherAbs12.DoSomething());

        Abstract AnotherAbs22 = new RefinedAbstract2(new ConcreteImp2());
        Console.WriteLine(AnotherAbs22.DoSomething());
    }

     */
}
