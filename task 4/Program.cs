using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Program
    {


        public class List<T>
        {
            private T[] _Titems;

            private int _size;



            public List()
            {
                _Titems = new T[_size]; 

                _size = 0;
            }



            public int Count{

                get { return _size; }
            }



            public int Copacity {
                get { return _Titems.Length; }
            }



            public void Add(T item)
            {
                if (_size == _Titems.Length)
                {
                    Console.WriteLine("theu are both same");
                }
            }


            public void RemoveRange(int index, int count)
            {

                int Iindex = index;
                int Icount = count;


                Icount = 50;
                Iindex = 60;

                if (count > 0 || index > 0)
                    Console.WriteLine("true");

                else
                    Console.WriteLine("false");
               
       

            }



            public bool Remove(T value)
            {
                for (int i = 0; i < _size; i++)
                {
                    if (_Titems[i].Equals(value))
                    {
                       
                        return true;
                    }
                }
                return false;
            }




        }





        static void Main(string[] args)
        {

            



        }
    }

    } 







