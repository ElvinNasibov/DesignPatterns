using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{    
    abstract class Component
    {
        protected string name;
        public Component (string name)
        {
            this.name = name;
        }
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract Component GetChild(int index);
        public abstract void Operation();

    }

    class Composite : Component
    {
        ArrayList nodes = new ArrayList();

        public Composite(string name): base(name)
        { }

        public override void Add(Component component)
        {
            nodes.Add(component);
        }

        public override void Remove(Component component)
        {
            nodes.Remove(component);
        }

        public override Component GetChild(int index)
        {
            return nodes[index] as Component;
        }

        public override void Operation()
        {
            Console.WriteLine(name);

            foreach (Component component in nodes)
            {
                component.Operation();
            }
        }
    }

    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        { }

        public override void Add(Component component)
        {
            throw new InvalidOperationException();
        }

        public override void Remove(Component component)
        {
            throw new InvalidOperationException();
        }
        public override Component GetChild(int index)
        {
            throw new InvalidOperationException();
        }
        public override void Operation()
        {
            Console.WriteLine(name);
        }
    }

    /*
    //--------------------------- Composite
    Console.WriteLine("--------------------------- Composite");
    AbstractFactory.Component root = new Composite("root");
    AbstractFactory.Component branch1 = new Composite(" - branch1");
    AbstractFactory.Component branch2 = new Composite(" - branch2");
    AbstractFactory.Component leaf1 = new Leaf(" - - leaf1");
    AbstractFactory.Component leaf2 = new Leaf(" - - leaf2");
    AbstractFactory.Component leaf3 = new Leaf(" - - leaf3");

    root.Add(branch1);
    root.Add(branch2);
    branch1.Add(leaf1);
    branch1.Add(leaf2);
    branch2.Add(leaf3);

    root.Operation();

    Console.ReadKey();
     */

}
