using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Factory_Method
    {

    }

    abstract class Product
    {

    }

    abstract class Creator
    {
        Product product;
        public abstract Product FactoryMethod();

        //public void AnOperation()
        //{
        //    product = CreateProduct();
        //}
    }

    //-----------------------------------------------------------

    class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }

    class ConcreteCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }

    //-----------------------------------------------------------

    /*
    public static void Main()
    {        
        //--------------------------- FactoryMethod

        Creator creator = new ConcreteCreator();            
        Product product = null;
        product = creator.FactoryMethod();

        //creator.AnOperation();
        Console.ReadKey();
    }
    */


}
