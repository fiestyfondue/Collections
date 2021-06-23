using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        private static void ToDoList()
        {
            Console.WriteLine("\n In ToDo List");
            //Creating list
            List<string> list = new List<string>();
            //Adding objects to List
            list.Add("Harsh");
            list.Add("Koi");
            list.Add("Naam");
            list.Add("Hashid");

            //Iterating list element
            foreach(var element in list)
            {
                Console.WriteLine(element);
            }

        }
        private static void Stack()
        {
            Console.WriteLine("\n Stack list");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Atharva");
            stack.Push("Alia");
            stack.Push("Jayant");

            string pop = stack.Pop();
        }
        private static void doDictionary()
        {
            Console.WriteLine("\n Dictionary ");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(0, "Harsh");
            dictionary.Add(1, "daffa");
            dictionary.Add(2, "fhadhfh");
            Console.WriteLine("Access value using Key as 0,1,2");

            Console.WriteLine("Iterating Dict");
            foreach (var element in dictionary)
            {

            }
        }
    }
}
