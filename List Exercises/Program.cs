using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// task 2  List Exercises: 
            

            Dictionary<string , string> contacts = new Dictionary<string , string>();
            contacts["leo Messi"] = "599-55-64-77";
            contacts["Cristiano"] = "588-55-65-12";
            contacts["giorgi"] = "517-82-82-83";
            contacts["mate"] = "beridze";
            contacts["solomon"] = "dadiani";


            foreach (var item in contacts)
            {
                Console.WriteLine(item);
            }


            if (contacts.ContainsKey("leo Messi"))
            
                {
                contacts.Remove("leo Messi");
            }
            

            Console.WriteLine();



            foreach (var item in contacts)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();



            if (contacts.TryGetValue("Cristiano", out string phonenumber))
            {
                Console.WriteLine("Phone Number is in list : " + phonenumber);
            }



            else
            {

                Console.WriteLine("there is no like this abonent in this list");
            }
        }
    }
}
