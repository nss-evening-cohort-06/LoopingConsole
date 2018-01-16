
using System;
using System.Collections.Generic;

namespace LoopingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = new List<Child>
            {
                new Child {Name = "Suzie", Sick = false},
                new Child {Name = "Ralph", Sick = true}
            };


            //while (true)
            //{
            //    //do something awesome
            //}

            //for (var i = 0; i < children.Count - 1; i++)
            //{
            //    var child = children[i];
            //    Console.WriteLine($"{child.Name} is {(child.Sick ? "sick" : "healthy")}");
            //    Console.WriteLine(child.ForgeASickNote());
            //}

            foreach (var child in children)
            {
                //if (child.Name == "Suzie")
                //{
                //    continue;
                //}
                //if (child.Name == "Suzie")
                //{
                //    break;
                //}

                Console.WriteLine($"{child.Name} is {(child.Sick ? "sick" : "healthy")}");
                Console.WriteLine(child.ForgeASickNote());
            }

            Console.WriteLine("This is our second time talking aboout the same thing.  #Nojudgement.");

            var lineIRead = Console.ReadLine();
        }
    }
}
