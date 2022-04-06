using ComponentA.Data;
using System;

namespace ComponentA
{
    class Program
    {
        static void Main(string[] args)
        {
            Leaf leaf = new Leaf();
            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
           
        }
    }
}
