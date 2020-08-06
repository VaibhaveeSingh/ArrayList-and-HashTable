using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection coll = new int[] { 1, 2, 3, 45, 6 };
            ArrayList myArray = new ArrayList();
            int[] array = new int[10];
            myArray.AddRange(coll);
            Console.WriteLine("arrayList count is {0}", myArray.Count);
            Console.WriteLine("____________________________________________________");
            myArray.CopyTo(array, 0);
            Console.WriteLine("copying MyArray to array  using copyto");

            myArray.CopyTo(array, 0);
            Console.WriteLine("after");
            foreach (var c in array)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("using contains to check if the iteam is there ");



            Console.WriteLine("4 is in array :{0}", myArray.Contains(4));
            Console.WriteLine("____________________________________________________");

            Console.WriteLine("index of 3 in my array is {0}", myArray.IndexOf(3));
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("last index of 45 on my array is {0}", myArray.LastIndexOf(45));
            Console.WriteLine("____________________________________________________");

            Console.WriteLine("sorted myArray");
            myArray.Sort();
            foreach (var e in myArray)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("inserting in my array");
            myArray.Insert(2, 1234);
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("inserting a range of elements at index0");
            myArray.InsertRange(0, coll);
            foreach (var f in myArray)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("removing 3 elements from index 1");
            myArray.RemoveRange(1, 3);
            foreach (var g in myArray)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine("____________________________________________________");

            Console.WriteLine("getting range from index 0 to 4");
            ArrayList rangeArray = myArray.GetRange(0, 4);
            foreach (var h in rangeArray)
            {
                Console.WriteLine(h);
            }
            Console.WriteLine("____________________________________________________");
            myArray.RemoveAt(1);
            Console.WriteLine("removing item at index 1");
            foreach (var i in myArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("Reversing my array");
            myArray.Reverse();
            foreach (var j in myArray)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("____________________________________________________");

            myArray.Remove(45);
            Console.WriteLine("removing 45 from my array");
            foreach (var k  in myArray)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("____________________________________________________");
            Console.WriteLine("clear my array");
            myArray.Clear();
            foreach (var l in myArray)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("____________________________________________________");
        }
    }
}
