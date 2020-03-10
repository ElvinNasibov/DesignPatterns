using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
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
            // Singleton thirdinstance = new Singleton(); // error

            Console.WriteLine(firstInstance.GetHashCode());
            Console.WriteLine(secondInstance.GetHashCode());
            Console.WriteLine(ReferenceEquals(firstInstance,secondInstance));

            firstInstance.SampleOperation();
            Console.WriteLine(secondInstance.GetSampleData());

            Console.ReadKey();
         */


    }
}
