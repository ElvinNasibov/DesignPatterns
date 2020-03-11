using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class Command // Zakaz
    {
        //Zakaz znayet o Povare (kto eqo budet vipolnyat)
        protected Receiver receiver;

        public Command (Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Operation();

    }

    class ConcreteCommand : Command // Konkretniy Zakaz
    {
        public ConcreteCommand(Receiver receiver) : base(receiver) 
        { }

        public override void Operation()
        {
            receiver.ExecuteOperation();
        }
    }

    class Invoker // Ofichiant
    {
        // Ofichiant znayet o zakaze i peredayet eqo povaru -> (a Zakaz znayet kakomu Povaru)
        Command command;

        public void StoreCommand (Command command)
        {
            this.command = command;
        }

        public void Execute()
        {
            command.Operation();
        }
    }


    class Receiver // Povar
    {
        public void ExecuteOperation()
        {
            Console.WriteLine("Receiver!");
        }
    }

    /*
        //--------------------------- Command
        Console.WriteLine("--------------------------- Command");
        Receiver povar = new Receiver();
        Command zakaz = new ConcreteCommand(povar);
        //Invoker ofichiant = new Invoker(zakaz);
        Invoker ofichiant = new Invoker();

        ofichiant.StoreCommand(zakaz);
        ofichiant.Execute();

    */


}
