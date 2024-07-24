using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolerFirst
{
    internal class Bai9
    {
        //Bài 9: Cho một mảng số nguyên hãy thực hiện sắp xếp dãy tang và giảm dần
        public void sortArrayIncreaseAndDecrease(int[] inputArray) {
            Console.WriteLine("mảng số nguyên sắp xếp tăng dần");
            //tang dan
            for (int i = 0; i < inputArray.Length; i++)
            {
               for (int j = i; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[i])
                    {
                        int wrap = inputArray[j];
                        inputArray[j] = inputArray[i];
                        inputArray[i] = wrap;
                    } 
                }
                Console.Write(inputArray[i]+" ");

            }
            Console.WriteLine("\nmảng số nguyên sắp xếp giảm dần");
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i; j < inputArray.Length; j++)
                {
                    if (inputArray[j] > inputArray[i])
                    {
                        int wrap = inputArray[j];
                        inputArray[j] = inputArray[i];
                        inputArray[i] = wrap;
                    }
                }
                Console.Write(inputArray[i] + " ");

            }

        }
    }
}
