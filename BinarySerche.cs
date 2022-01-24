using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Data_Structures
{
    internal class BinarySerche
    {

        public String line;
        public String[] valueArr;

        public void FileReader() 
        {
            int i = 0;
            using (FileStream fileStream = File.OpenRead(@"D:\.Net\C#\RFP_Data_Structures\List.txt"))
            {
                using (TextReader reader = new StreamReader(fileStream))
                {   
                    line = reader.ReadLine();
                    valueArr =line.Split(',');

                    foreach (String s in valueArr)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine(valueArr[2]);
                }
            }
        }
        public void  binarySearch(String x)
        {
            FileReader();
            int l = 0, r = valueArr.Length - 1;
            while (l <= r)
            {
                int m = 0 + (r - l) / 2;

                int res = x.CompareTo(valueArr[m]);

                // Check if x is present at mid
                if (res == 0)
                    Console.WriteLine(x+" is present at index "+m);

                // If x greater, ignore left half
                if (res > 0)
                    l = m + 1;

                // If x is smaller, ignore right half
                else
                    r = m - 1;
            }
        }
        public void BubleSort(int[] arr)
        {
            Display<int>(arr);
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {


                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n----------- Sorted Array ----------------\n");
            Display<int>(arr);
        }


        public void InsertionSort(String[]array)
        {
            int i, j;

            Display<String>(array);
            for (i = 1; i < array.Length; i++)
            {
                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = (string)value;              
            }
            Console.WriteLine("\n----------- Sorted Array ----------------\n");
            Display<String>(array);
        }
        static public void Display<T>(T[] array)
        {
            for (int i= 0; i< array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

