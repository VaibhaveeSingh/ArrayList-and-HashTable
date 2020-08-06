using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListFunction
{


    class HashTableFunctions
    {
        static void Main()
        {

            Hashtable hTable = new Hashtable();
            hTable.Add(1, "one");
            hTable.Add("two", 12.34);
            hTable.Add('C', "cap");


            Console.WriteLine("----------------------------------------------------------------\ncontains\n ");

            Console.WriteLine(hTable.Contains(1));
            Console.WriteLine("----------------------------------------------------------------\nContainskey\n ");

            Console.WriteLine(hTable.ContainsKey(2));
            Console.WriteLine("----------------------------------------------------------------\nContainsvalue\n ");

            Console.WriteLine(hTable.ContainsValue("cap"));
            Console.WriteLine("----------------------------------------------------------------\ncopyTo\n ");

            Array arr = new Object[hTable.Count];

            hTable.CopyTo(arr, 0);

            foreach (DictionaryEntry a in arr)
            {
                Console.WriteLine("{0}={1}", a.Key, a.Value);
            }

            Console.WriteLine("----------------------------------------------------------------\nkey property\n");

            foreach (var k in hTable.Keys)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("----------------------------------------------------------------\nvalue property\n");

            foreach (var v in hTable.Values)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();
        }
    }
}
