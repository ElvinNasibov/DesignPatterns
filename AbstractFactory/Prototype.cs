using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Prototype
    {
        public int id { get; private set; }

        public Prototype(int id)
        {
            this.id = id;
        }

        public abstract Prototype Clone();
        public abstract void AnOperation();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id) : base(id)
        {
            
        }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(id);
        }
        public override void AnOperation()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Class : " + this.GetType().ToString());
        }


    }

    class ConcretePrototype2 : Prototype 
    {
        public ConcretePrototype2(int id) : base(id)
        {

        }

        public override Prototype Clone()
        {
            return new ConcretePrototype2(id);
        }
        public override void AnOperation()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Class : " + this.GetType().ToString());
        }
    }

    /*
        //--------------------------- Prototype
        Console.WriteLine("--------------------------- Prototype");

        Prototype prototype = new ConcretePrototype1(1);
        Prototype clone = prototype.Clone();
        clone.AnOperation();

        Prototype prototype2 = new ConcretePrototype2(2);
        Prototype clone2 = prototype2.Clone();
        clone2.AnOperation();

        Console.ReadKey();
     */



}
