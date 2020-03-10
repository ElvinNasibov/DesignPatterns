using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{



    class Facade
    {
        SubClassA subClassA = new SubClassA();
        SubClassB subClassB = new SubClassB();
        SubClassC subClassC = new SubClassC();
        SubClassD subClassD = new SubClassD();

        public void OperationAB()
        {
            subClassA.OperationA();
            subClassB.OperationB();
        }

        public void OperationCD()
        {
            subClassC.OperationC();
            subClassD.OperationD();
        }
    }

    class SubClassA
    {
        public void OperationA()
        {
            Console.WriteLine("Operation A");
        }
    }

    class SubClassB
    {
        public void OperationB()
        {
            Console.WriteLine("Operation B");
        }
    }

    class SubClassC
    {
        public void OperationC()
        {
            Console.WriteLine("Operation C");
        }
    }

    class SubClassD
    {
        public void OperationD()
        {
            Console.WriteLine("Operation D");
        }
    }

    /*
    //--------------------------- Facade
    Console.WriteLine("--------------------------- Facade");
    Facade facade = new Facade();
    facade.OperationAB();
    facade.OperationCD(); 
     */


}
