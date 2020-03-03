using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Singleton
    {
        static Singleton uniqueInstance;

        string sampleData = string.Empty;

        protected Singleton()
        {

        }

        public static Singleton Instance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Singleton();
            return uniqueInstance;
        }

        public void SampleOperation()
        {
            sampleData = "Singleton Sample Data";
        }

        public string GetSampleData()
        {
            return sampleData;
        }


        /*
            //--------------------------- Singleton
            Console.WriteLine("--------------------------- Singleton");

            Singleton firstInstance = Singleton.Instance();
            Singleton secondInstance = Singleton.Instance();

            firstInstance.SampleOperation();
            Console.WriteLine(secondInstance.GetSampleData());
            Console.WriteLine(firstInstance.GetHashCode());
            Console.WriteLine(secondInstance.GetHashCode());


            Console.ReadKey();
         */


    }
}
