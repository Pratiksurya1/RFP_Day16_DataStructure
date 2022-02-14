using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Data_Structures
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            //2
            BinarySerche binarySerche = new BinarySerche();
            //// binarySerche.FileReader();
            //binarySerche.binarySearch("pratik");


            //4
            int[] arr = { 55, 4, 3, 88, 46, 92, 11, };
            binarySerche.BubleSort(arr);

            //3
            String[] arr2 = { "z", "a", "b", "p", "d" };
            binarySerche.InsertionSort(arr2);


            binarySerche.PrimeNumber();
        }
    }
}