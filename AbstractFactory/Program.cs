using DesignPatterns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    class Program
    {

        public static void Main()
        {
            //--------------------------- AbstractFactory
            Console.WriteLine("--------------------------- AbstractFactory");

            Client client = null;
            client = new Client(new CocaColaFactory());
            client.Run();

            client = null;
            client = new Client(new PepsiColaFactory());
            client.Run();

            /* // sonuc - AbstractFactory
                AbstractFactory.Program + CocaColaBottle interacts with AbstractFactory.Program + CocaColaWater
                AbstractFactory.Program + CocaColaCover closes AbstractFactory.Program + CocaColaBottle
                AbstractFactory.Program + PepsiColaBottle interacts with AbstractFactory.Program + PepsiColaWater
                AbstractFactory.Program + PepsiColaCover closes AbstractFactory.Program + PepsiColaBottle
            */
            //Console.ReadKey();



            //--------------------------- Builder
            Console.WriteLine("--------------------------- Builder");

            Builder stoneHouseBuilder = new ConcreteBuilder();
            Director director = new Director(stoneHouseBuilder);
            director.Construct();

            House house = stoneHouseBuilder.GetResult();
            house.Show();

            /* //--------------------------- Builder
                Basement Created
                Floor Created
                Roof Created
                Element: DesignPatterns.Basement builded.
                Element: DesignPatterns.Floor builded.
                Element: DesignPatterns.Roof builded.             
             */
            //Console.ReadKey();



            //--------------------------- FactoryMethod
            Console.WriteLine("--------------------------- FactoryMethod");

            Creator creator = new ConcreteCreator();            
            Product product = null;
            product = creator.FactoryMethod();

            //creator.AnOperation();
            //Console.ReadKey();


            //--------------------------- Prototype
            Console.WriteLine("--------------------------- Prototype");

            Prototype prototype = new ConcretePrototype1(1);
            Prototype clone = prototype.Clone();
            clone.AnOperation();

            Prototype prototype2 = new ConcretePrototype2(2);
            Prototype clone2 = prototype2.Clone();
            clone2.AnOperation();

            //Console.ReadKey();


            //--------------------------- Singleton
            Console.WriteLine("--------------------------- Singleton");

            Singleton firstInstance = Singleton.Instance();
            Singleton secondInstance = Singleton.Instance();
            // Singleton thirdinstance = new Singleton(); // error

            Console.WriteLine(firstInstance.GetHashCode());
            Console.WriteLine(secondInstance.GetHashCode());
            Console.WriteLine(ReferenceEquals(firstInstance,secondInstance));

            firstInstance.SampleOperation();
            Console.WriteLine(secondInstance.GetSampleData());

            /*            
                12289376
                12289376
                True
                Singleton Sample Data
            */

            //Console.ReadKey();

            ////--------------------------- Adapter (Class)
            //Console.WriteLine("--------------------------- Adapter (Class)");

            //iTarget target = new Adapter();
            //target.Operation();

            //--------------------------- Adapter (Object)
            Console.WriteLine("--------------------------- Adapter (Object)");

            Target target = new Adapter();
            target.Operation();

            //Console.ReadKey();

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

            /*
                --------------------------- Bridge
                RefinedAbstract1 is doing smth. with Imp1
                RefinedAbstract2 is doing different things with Imp1
                RefinedAbstract1 is doing smth. with Imp2
                RefinedAbstract2 is doing different things with Imp2
            */
            
            //--------------------------- Composite
            Console.WriteLine("--------------------------- Composite");
            Component root = new Composite("root");
            Component branch1 = new Composite(" - branch1");
            Component branch2 = new Composite(" - branch2");
            Component leaf1 = new Leaf(" - - leaf1");
            Component leaf2 = new Leaf(" - - leaf2");
            Component leaf3 = new Leaf(" - - leaf3");

            root.Add(branch1);
            root.Add(branch2);
            branch1.Add(leaf1);
            branch1.Add(leaf2);
            branch2.Add(leaf3);

            root.Operation();
            
            /*             
                --------------------------- Composite
                root
                 - branch1
                 - - leaf1
                 - - leaf2
                 - branch2
                 - - leaf3
            */


            //--------------------------- Decorator
            Console.WriteLine("--------------------------- Decorator");
            AbstractComponent someComponenet = new ConcreteComponenet();
            Decorator decoratorA = new ConcreteDecoratorA();
            Decorator decoratorB = new ConcreteDecoratorB();

            decoratorA.component = someComponenet;
            decoratorB.component = decoratorA;
            decoratorB.Operation();


            /*
                --------------------------- Decorator
                Concrete Componenet Operation
                Some State
                Some Behavior
            */


            //--------------------------- Facade
            Console.WriteLine("--------------------------- Facade");
            Facade facade = new Facade();
            facade.OperationAB();
            facade.OperationCD();

            /*
                --------------------------- Facade
                Operation A
                Operation B
                Operation C
                Operation D
            */


            //--------------------------- Flyweight
            Console.WriteLine("--------------------------- Flyweight");
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

            ActorMikeMyers mike = new ActorMikeMyers();

            RoleAustinPowers austin = new RoleAustinPowers(mike);
            austin.Greetings("Hello! I'm Austin Powers!");

            RoleDoctorEvil dr = new RoleDoctorEvil(mike);
            dr.Greetings("Hello! I'm Dr. Evil!");

            /*
                --------------------------- Flyweight
                Hello! I'm Austin Powers!
                Hello! I'm Dr. Evil!
            */


            //--------------------------- Proxy
            Console.WriteLine("--------------------------- Proxy");
            //Subject original = new Original();
            //Subject proxy = new Proxy(original);
            //proxy.Operation();

            Subject anotherProxy = new Proxy();
            anotherProxy.Operation();

            /*
                --------------------------- Proxy
                Do Smth
                Do Smth
            */


            //--------------------------- ChainOfResponsibility
            Console.WriteLine("--------------------------- ChainOfResponsibility");
            Handler concreteHandler1 = new ConcreteHandler1();
            Handler concreteHandler2 = new ConcreteHandler2();

            concreteHandler1.successor = concreteHandler2;
            concreteHandler1.Operation(1);
            concreteHandler1.Operation(2);

            /*
                --------------------------- ChainOfResponsibility
                One
                Two
            */

            Console.ReadKey();
        }





    }


}
