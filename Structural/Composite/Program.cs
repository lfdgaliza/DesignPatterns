using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var composite1 = new TreeItemComposite("Composite 1");
            var composite11 = new TreeItemComposite("Composite 1.1");
            var composite12 = new TreeItemComposite("Composite 1.2");

            composite1.Add(composite11);
            composite1.Add(composite12);

            composite11.Add(new TreeItemLeaf("Leaf 1"));
            var c11leaf2 = new TreeItemLeaf("Leaf 2");
            composite11.Add(c11leaf2);
            composite11.Add(new TreeItemLeaf("Leaf 3"));

            composite12.Add(new TreeItemLeaf("Leaf 1"));
            composite12.Add(new TreeItemLeaf("Leaf 2"));

            Console.WriteLine(composite1.GetText());
            Console.WriteLine();
            Console.WriteLine(composite11.GetText());
            Console.WriteLine();
            Console.WriteLine(composite12.GetText());
            
            Console.WriteLine("\n***\n");

            composite11.Remove(c11leaf2);
            Console.WriteLine(composite11.GetText());
        }
    }
}
