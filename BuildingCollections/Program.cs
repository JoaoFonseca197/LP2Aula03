using System;
using System.Collections.Generic;

namespace BuildingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> list = new List<Building>();
            Stack<Building> stack = new Stack<Building>();
            Queue<Building> queue = new Queue<Building>();
            HashSet<Building> hashset = new HashSet<Building>();

            Building b1 = new Building("b1",5);
            Building b2 = new Building("b2",10);
            Building b3 = new Building("b3",15);
            Building b4 = new Building("b4",20);
            Building b5 = new Building("b5",25);

            list.Add(b1);
            list.Add(b2);
            list.Add(b3);
            list.Add(b4);
            list.Add(b4);
            
            stack.Push(b1);
            stack.Push(b2);
            stack.Push(b3);
            stack.Push(b4);
            stack.Push(b4);

            queue.Enqueue(b1);
            queue.Enqueue(b2);
            queue.Enqueue(b3);
            queue.Enqueue(b4);
            queue.Enqueue(b4);

            hashset.Add(b1);
            hashset.Add(b2);
            hashset.Add(b3);
            hashset.Add(b4);
            hashset.Add(b4);

            foreach(Building building in list)
            {
                Console.WriteLine($"{building.Tipo}|{building.Área}"); 
            }

            Console.WriteLine("/n");

            foreach(Building building in stack)
            {
                Console.WriteLine($"{building.Tipo}|{building.Área}");
            }
            Console.WriteLine("/n");

            foreach(Building building in queue)
            {
                Console.WriteLine($"{building.Tipo}|{building.Área}");
            }
            Console.WriteLine("/n");

            foreach(Building building in hashset)
            {
                Console.WriteLine($"{building.Tipo}|{building.Área}");
            }
        }
        
    }
}
