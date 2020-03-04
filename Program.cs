using System;

namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание массива, который хранит 100 целых чисел
            int[] myArray = new int[100];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i+1;
                Console.Write(myArray[i]);
            }

           //Искомое значение
            int searchItem = 27;

            var prevIndex = myArray.Length;
            var nowIndex = myArray.Length / 2;
            var newIndex = 0;

//Поиск элемента в массиве
            while (true)
            {
                if (myArray[nowIndex] == searchItem)
                {
                    Console.WriteLine("Искомое:{0} Найденный элемент массива по индексу:{1} и значением:{2}", searchItem,nowIndex,myArray[nowIndex]);
                    break;
                }
                else if (searchItem < myArray[nowIndex])
                {
                    newIndex = nowIndex - Math.Abs(prevIndex - nowIndex) / 2;
                    prevIndex = nowIndex;
                    nowIndex = newIndex;
                }
                else if (searchItem > myArray[nowIndex])
                {
                    newIndex = nowIndex + Math.Abs(prevIndex - nowIndex) / 2;
                    prevIndex = nowIndex;
                    nowIndex = newIndex;
                }
            }


        }
    }
}
