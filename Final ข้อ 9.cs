using System;

namespace Final2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Input skill: ");
            string name = Console.ReadLine();
            while (name != "?")
            {
                Node node1 = new Node(name);
                Console.Write("Add dependency for {0} ? (Y/N) : ", name);
                char Yes_No = char.Parse(Console.ReadLine());
                if (Yes_No == 'Y' || Yes_No == 'y')
                {
                    Console.Write("Input skill: ");
                    name = Console.ReadLine();
                    node1.nextNode = node1;
                }
                else if (Yes_No == 'N' || Yes_No == 'n')
                {
                    Console.WriteLine("No");
                }
            }
        }
        class Node
        {
            public string name;
            public Node nextNode;

            public Node(string nameValue)
            {

                name = nameValue;
                nextNode = null;


            }
        }
    }
}
