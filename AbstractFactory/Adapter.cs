using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //// ----------------- Adapter (Class)
    //// Ne rekomenduetsya v C# iz za mnojestvennoqo nasledovaniya
    //public interface iTarget
    //{
    //    void Operation();
    //}

    //class Adaptee
    //{
    //    public void SpecificOperation()
    //    {
    //        Console.WriteLine("SpecificOperation");
    //    }
    //}

    //class Adapter : Adaptee, iTarget
    //{        
    //    public void Operation()
    //    {
    //        SpecificOperation();
    //    }
    //}


    // ----------------- Adapter (Object)

    abstract class Target
    {
        public abstract void Operation();        
    }

    class Adaptee
    {
        public void SpecificOperation()
        {
            Console.WriteLine("SpecificOperation");
        }
    }

    class Adapter : Target
    {
        //Adaptee adaptee = null;
        Adaptee adaptee = new Adaptee();

        //public Adapter()
        //{
        //    adaptee = new Adaptee();
        //}
        public override void Operation()
        {
            adaptee.SpecificOperation();
        }
    }

}
