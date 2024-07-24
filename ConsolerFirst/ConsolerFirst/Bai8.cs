using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolerFirst
{
    internal class Bai8
    {
        public void printArrayLeVaArrayChan(int[] arr)
        {
            int[] arrayOdd =new int[10];
            int[] arrayOven = new int[10];
            int indexOdd=0,indexOven=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] %2== 0)
                {
                    arrayOdd[indexOdd]= arr[i];
                    indexOdd++;
                }
                else
                {
                    arrayOven[indexOdd] = arr[i];
                    indexOven++;
                }
            }
            Console.WriteLine("Các phân tử của mạng chẵn là ");
            for (int i = 0;i < indexOdd;i++)
            {
                Console.Write(arrayOdd[i]+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("Các phân tử của mạng lẻ là ");
            for (int i = 0; i < indexOven; i++)
            {
                Console.Write(arrayOven[i] + " ");
            }
        }
    }
}
