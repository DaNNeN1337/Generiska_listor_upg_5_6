using System;

namespace DanielGeneriskaListor
{
    class Program
    {
        static void Main(string[] args)
        {
            mylist<string> list = new mylist<string>();

            list.AddLast("Bredåker");
            list.AddFirst("Daniel");
            list.AddLast("Hejhej");
            list.AddFirst("Jag heter");

            list.RemoveLast(); // tar bort "hejhej" som är sista i index
            


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString() + " " + i);
            }
            Console.ReadLine();
        }
    }
}
