using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /*
    abstract class Flyweight
    {
        public abstract void Operation(int externalState);
    }

    class FlyweightFactory
    {
        Hashtable pool = new Hashtable
        {
            {"1", new ConcreteFlyweight() },
            {"2", new ConcreteFlyweight() },
            {"3", new ConcreteFlyweight() }
        };

        public Flyweight GetFlyweight(string key)
        {
            if (!pool.ContainsKey(key))
                pool.Add(key, new ConcreteFlyweight());

            return pool[key] as Flyweight;
        }
    }

    class ConcreteFlyweight : Flyweight
    {
        int internalState;
        public override void Operation(int externalState)
        {
            internalState = externalState;
        }
    }

    class UnsharedConcreteFlyweight : Flyweight
    {
        int allState;
        public override void Operation(int externalState)
        {
            allState = externalState;
        }
    }
    */
    /*
    int externalState = 0;

    Flyweight flyweight = null;
    FlyweightFactory factory = new FlyweightFactory();

    flyweight = factory.GetFlyweight("1");
    flyweight.Operation(externalState);

    flyweight = factory.GetFlyweight("10");
    flyweight.Operation(externalState);

    flyweight = new UnsharedConcreteFlyweight();
    flyweight.Operation(externalState);
    */


    abstract class Flyweight
    {
        public abstract void Greetings(string speech);
    }

    // Разделяемый
    class ActorMikeMyers : Flyweight
    {
        public override void Greetings(string speech)
        {
            Console.WriteLine(speech);
        }
    }
    
    // Неразделяемый
    class RoleAustinPowers : Flyweight
    {
        Flyweight flyweight;

        public RoleAustinPowers(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }

        public override void Greetings(string speech)
        {
            this.flyweight.Greetings(speech);
        }
    }

    // Неразделяемый
    class RoleDoctorEvil : Flyweight
    {
        Flyweight flyweight;

        public RoleDoctorEvil(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }

        public override void Greetings(string speech)
        {
            this.flyweight.Greetings(speech);
        }
    }

    /*
    ActorMikeMyers mike = new ActorMikeMyers();

    RoleAustinPowers austin = new RoleAustinPowers(mike);
    austin.Greetings("Hello! I'm Austin Powers!");

    RoleDoctorEvil dr = new RoleDoctorEvil(mike);
    dr.Greetings("Hello! I'm Dr. Evil!");

    Console.ReadKey();
    */


}
