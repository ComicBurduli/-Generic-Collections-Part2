using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_2025_Generic_Collections_Part2
{
    internal class Program
    {


             
        static void Main(string[] args)
        {

            ///task 1  List Exercises:

            Console.WriteLine("task 1 List Exercises:");

           Console.WriteLine();

            LinkedList <string> list = new LinkedList<string>();    

            list.AddLast("Saba Burduli");
            list.AddLast("giorgi grigalashvili");
            list.AddLast("Dato Akhrakhadze");
            list.AddLast("giorgi Afciauri");


            foreach (string item in list) 
                Console.WriteLine(item);

            Console.WriteLine();

             list.RemoveFirst();

            list.RemoveLast();


            foreach (string item in list)   
                Console.WriteLine(item);




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("task 2 List Exercises:");
            Console.WriteLine();

            LinkedList<Employes> employesNames = new LinkedList<Employes>();

            LinkedListNode<Employes> namesandUsernames =

            employesNames.AddFirst(new Employes() { Name = "gio", UserName = "burduli" });

            employesNames.AddFirst(new Employes() { Name = "Saba", UserName = "Xucishvili" });

            employesNames.AddFirst(new Employes() { Name = "Tamar", UserName = "Danelia" });

            employesNames.AddFirst(new Employes() { Name = "Iago", UserName = "vashadze" });





            //Console.Write(namesandUsernames.Previous.Value.Name);
            //Console.Write(namesandUsernames.Previous.Value.UserName);

            //Console.WriteLine();

            //Console.Write(namesandUsernames.Previous.Value.Name);
            //Console.Write(namesandUsernames.Previous.Value.UserName);


            //Console.WriteLine();


            //Console.Write(namesandUsernames.Previous.Value.Name);
            //Console.Write(namesandUsernames.Previous.Value.UserName);



            //Console.WriteLine();


            //Console.Write(namesandUsernames.Previous.Value.Name);
            //Console.Write(namesandUsernames.Previous.Value.UserName);


           
        }


        public class Employes
        {



            public string Name { get; set; }

            public string UserName { get; set; }



        }


    }
}
