using System;
using System.Globalization;

namespace SortingSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Sort sort = new Sort();
            int[] arrayOne = { 0, 2, 4, 6, 8, 10 };
            int[] arrayTwo = { 1, 3, 5, 7, 9 };
            int[] arrayThree = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            sort.CalculateAverage(arrayOne);
            sort.CalculateAverage(arrayTwo);
            sort.CalculateAverage(arrayThree);
            Console.ReadLine();
            sort.ReverseTheArray(arrayOne);
            sort.ReverseTheArray(arrayTwo);
            sort.ReverseTheArray(arrayThree);
            Console.ReadLine();
            Console.WriteLine("Would you like to rotate 1. Left or 2. Right?");
            int userInputDirection = int.Parse(Console.ReadLine());
            Console.WriteLine("How many rotations would you like?");
            int userInputAmmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Which array would you like to rotat?\n1.Array One\n2.Array Two\n3.Array Three");
            int userSelection = int.Parse(Console.ReadLine());
            switch (userSelection)
            {
                case 1:
                    sort.Rotate(userInputDirection, arrayOne, userInputAmmount);
                    break;
                case 2:
                    sort.Rotate(userInputDirection, arrayTwo, userInputAmmount);
                    break;
                case 3:
                    sort.Rotate(userInputDirection, arrayThree, userInputAmmount);
                    break;
                default:
                    break;
            }
            sort.Bubble(arrayThree);
            Console.ReadLine();
        }
    }
}
