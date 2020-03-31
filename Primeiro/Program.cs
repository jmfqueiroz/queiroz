using System;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            list.Add("M1");
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Insert(2, "M2");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("#List:" + list.Count);

            string s1 = list.Find(x => x[0] == 'C');
            string s2 = list.FindLast(x => x[0] == 'C');

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}