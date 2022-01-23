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
                  //  return m;

                // If x greater, ignore left half
                if (res > 0)
                    l = m + 1;

                // If x is smaller, ignore right half
                else
                    r = m - 1;
            }
            

        }
    }

}

