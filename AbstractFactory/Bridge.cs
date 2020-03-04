using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
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

}
