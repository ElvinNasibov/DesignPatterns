using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class Builder
    {
        public abstract void BuildBasement();        
        public abstract void BuildFloor();
        public abstract void BuildRoof();
        public abstract House GetResult();

    }

    //----------------------------------------------------------
    class Basement
    {
        public Basement()
        {
            Console.WriteLine("Basement Created");
        }
    }

    class Floor
    {
        public Floor()
        {
            Console.WriteLine("Floor Created");
        }
    }

    class Roof
    {
        public Roof()
        {
            Console.WriteLine("Roof Created");
        }
    }


    class House
    {
        private ArrayList elementsOfHouse = new ArrayList();
        
        public void Add(object obj)
        {
            elementsOfHouse.Add(obj);
        }

        public void Show()
        {
            foreach (object obj in elementsOfHouse)
                Console.WriteLine("Element: " + obj.ToString() + " builded.");
        }
    }

    //----------------------------------------------------------

    class Director
    {
        Builder builder;
        public Director(Builder b)
        {
            this.builder = b;
        }

        public void Construct()
        {
            builder.BuildBasement();
            builder.BuildFloor();
            builder.BuildRoof();
        }
    }

    //----------------------------------------------------------

    class ConcreteBuilder : Builder
    {
        House house = new House();
        public override void BuildBasement()
        {
            house.Add(new Basement());
        }

        public override void BuildRoof()
        {
            house.Add(new Roof());
        }

        public override void BuildFloor()
        {
            house.Add(new Floor());
        }

        public override House GetResult()
        {
            return house;
        }
    }

    //----------------------------------------------------------

    /*
    public static void Main()
    {        
            //--------------------------- Builder
            Builder stoneHouseBuilder = new ConcreteBuilder();
            Director director = new Director(stoneHouseBuilder);
            director.Construct();

            House house = stoneHouseBuilder.GetResult();
            house.Show();

            Console.ReadKey();
    }
    */


}
