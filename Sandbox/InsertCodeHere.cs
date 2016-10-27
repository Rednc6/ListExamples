using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> aListOfInt = new List<int>();
            aListOfInt.Add(4);
            aListOfInt.Add(12);
            aListOfInt.Add(9);

            // Case 1
            Console.WriteLine("Case 1: Element with index 1 is {0}", aListOfInt[1]);

            // Case 2
            Console.WriteLine("Case 2: List contains {0} elements", aListOfInt.Count);
 
            aListOfInt.Add(5);
            aListOfInt.Add(22);

            // Case 3
            Console.WriteLine("Case 3: Element with index 3 is {0}", aListOfInt[3]);

            aListOfInt.RemoveAt(0);

            // Case 4
            Console.WriteLine("Case 4: Element with index 3 is {0}", aListOfInt[3]);



            aListOfInt.Clear();
            aListOfInt.Add(14);
            aListOfInt.Add(87);
            aListOfInt.Add(62);
            aListOfInt.Add(21);
            aListOfInt.Add(40);
            aListOfInt.Add(3);

            // Case 5: Make some code that prints out 
            // all the elements in the list

            for (int i = 0; i < aListOfInt.Count; i++)
            {
                int printNumbers = aListOfInt[i];
                Console.WriteLine("Case 5: All the elements in aListOfInt = {0}", printNumbers);
            }
      

            // Case 6: Make some code that finds the 
            // sum of the elements in the list, and prints the result
            int sum = 0;
            
            foreach (int p in aListOfInt)
            {
                                
                sum = sum + p;
                
            }
            Console.WriteLine("Case 6: Sum of all the elements = {0}", sum);

            //int totalVærdi = aListOfInt.Sum();
            //Console.WriteLine("Case 6: The sum of all elements in aListofInt = {0}", totalVærdi);


            // Case 7: Make some code that finds the 
            // average of the elements in the list, and prints the result
            // Tip: Think about how average is defined; then
            // you might reuse something from Case 6

            double avgSum;
            avgSum = 0;
            foreach (var p in aListOfInt)
            {
                avgSum = sum / aListOfInt.Count;

            }
            Console.WriteLine("Case 7: Average sum of all the elements = {0}", avgSum);
            //double averageVærdi = aListOfInt.Average();
            //Console.WriteLine("Case 7: The Average of all elements in aListOfInt = {0}", averageVærdi);

            // [DIFFICULT]
            // Case 8: Make some code that finds the
            // smallest element in the list, and prints the result
            // Tip: Think in detail about how you would do this manually

            
            int minValue = aListOfInt[0];
            foreach (var p in aListOfInt)
            {
                if(minValue > p)
                {
                    minValue = p;
                }
                   
            }
            Console.WriteLine("Minimum value in elements = {0 }", minValue);

            //int SmallestVærdi = aListOfInt.Min();
            //Console.WriteLine("Case 8: The lowest value of all the elements in aListOfInt = {0}", SmallestVærdi);








            // The LAST line of code should be ABOVE this line
        }
    }
}
