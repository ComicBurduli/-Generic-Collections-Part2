using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> list = new HashSet<int>();

            list.Add(32);

            list.Add(36);

            list.Add(23);

            list.Add(77);

            list.Add(89);


            foreach (var item in list) 
                Console.WriteLine(item);




            list.Remove(77);
            list.Remove(36);




            foreach(var item in list)   

                    Console.WriteLine(item);    





        }
    }
}
