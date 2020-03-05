using System;

namespace algorithms
{     
    class Program
    {
       
       // Функция формирования входных данных
       
       // Функция поиска заданного элемента

        // Функция вывода результата
        
        static void Main(string[] args)
        {
            //Создание массива, который хранит 100 целых чисел
            int[] myArray = new int[100];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 1;
                Console.Write(myArray[i]);
            }


            var item = 69;
            var low = 0;
            var high = myArray.Length - 1;
            var mid = 0;
            var guess = 0;

            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = myArray[mid];
                if (guess == item)
                {
                    Console.WriteLine(guess);
                    break;
                }
                else if (guess > item)
                {
                    high = mid - 1;
                }
                else if (guess < item)
                {
                    low = mid + 1;
                }

            }
        }
    }
}
