﻿using AbstractFactory;
using System;
using System.Collections.Generic;
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

            /* // sonuc - Builder
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
            Console.ReadKey();

        }



    }






}
