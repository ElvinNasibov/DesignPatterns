using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    //--------------------------- AbstractFactory
    abstract class AbstractProductA
    {

    }

    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA productA);
    }

    abstract class AbstractProductC
    {
        public abstract void Close(AbstractProductB productB);
    }

    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateAbstractProductA();
        public abstract AbstractProductB CreateAbstractProductB();
        public abstract AbstractProductC CreateAbstractProductC();
    }

    //-----------------------------------------------------------

    class CocaColaWater : AbstractProductA
    {

    }

    class CocaColaBottle : AbstractProductB
    {
        public override void Interact(AbstractProductA water)
        {
            Console.WriteLine(this + " interacts with " + water);
        }
    }

    class CocaColaCover : AbstractProductC
    {
        public override void Close(AbstractProductB bottle)
        {
            Console.WriteLine(this + " closes " + bottle);
        }
    }

    class CocaColaFactory : AbstractFactory
    {
        public override AbstractProductA CreateAbstractProductA()
        {
            return new CocaColaWater();
        }
        public override AbstractProductB CreateAbstractProductB()
        {
            return new CocaColaBottle();
        }
        public override AbstractProductC CreateAbstractProductC()
        {
            return new CocaColaCover();
        }
    }

    //-----------------------------------------------------------

    class PepsiColaWater : AbstractProductA
    {

    }

    class PepsiColaBottle : AbstractProductB
    {
        public override void Interact(AbstractProductA water)
        {
            Console.WriteLine(this + " interacts with " + water);
        }
    }

    class PepsiColaCover : AbstractProductC
    {
        public override void Close(AbstractProductB bottle)
        {
            Console.WriteLine(this + " closes " + bottle);
        }
    }

    class PepsiColaFactory : AbstractFactory
    {
        public override AbstractProductA CreateAbstractProductA()
        {
            return new PepsiColaWater();
        }
        public override AbstractProductB CreateAbstractProductB()
        {
            return new PepsiColaBottle();
        }
        public override AbstractProductC CreateAbstractProductC()
        {
            return new PepsiColaCover();
        }
    }

    //-----------------------------------------------------------

    class Client
    {
        private AbstractProductA water;
        private AbstractProductB bottle;
        private AbstractProductC cover;

        public Client(AbstractFactory factory)
        {
            // abstragirovaniye processov instanchirovaniya
            water = factory.CreateAbstractProductA();
            bottle = factory.CreateAbstractProductB();
            cover = factory.CreateAbstractProductC();
        }

        public void Run()
        {
            // abstragirovaniya variyantov ispolzovaniya
            bottle.Interact(water);
            cover.Close(bottle);
        }

    }

    //-----------------------------------------------------------

    /*     
        //--------------------------- AbstractFactory

        Client client = null;
        client = new Client(new CocaColaFactory());
        client.Run();

        client = null;
        client = new Client(new PepsiColaFactory());
        client.Run();

        Console.ReadKey();

     */

}
