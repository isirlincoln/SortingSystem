using System;
using System.Collections.Generic;
using System.Text;

namespace SortingSystem
{
    public class Sort
    {
        public void CalculateAverage(int[] array)
        {
            double mean = 0;
            foreach (int x in array)
            {
                mean += x;
            }
            mean /= array.Length;
            Console.WriteLine(mean);
        }
        public void ReverseTheArray(int[] array)
        {
            int z = array.Length - 1;
            int b = 0;
            while (b <= z)
            {
                int a = array[z];
                array[z] = array[b];
                array[b] = a;
                z--;
                b++;
            }
            Console.WriteLine(string.Join(", ", array));
        }
        public void Rotate(int direction, int[] array, int howManyTimes)
        {
            switch (direction)
            {
                case 1:
                    
                    for (int x = 0; x < howManyTimes; x++)
                    {
                        int n = array[0];
                        for (int i = 0; i < array.Length - 1; i++)
                        {
                            array[i] = array[i + 1];
                        }
                        array[array.Length-1] = n;
                    }
                    break;
                case 2:

                    for (int x = 0; x < howManyTimes; x++)
                    {
                        int n = array[array.Length-1];
                        for (int i = array.Length-1; i >=1; i--)
                        {
                            array[i] = array[i - 1];
                        }
                        array[0] = n;
                    }
                    break;
            }
            Console.WriteLine(string.Join(", ", array));

        }
        public void Bubble(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int a = 0; a < array.Length-1; a++)
                {
                    if (array[a] > array[a + 1])
                    {
                        int t = array[a + 1];
                        array[a + 1] = array[a];
                        array[a] = t;
                    }

                }
            }
            Console.WriteLine(string.Join(", ", array));
        }

    }
}
