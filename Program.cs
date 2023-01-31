using System;
using System.Collections.Generic;

namespace C_Light
{
    class Program
    {
        static void Main()
        {
            const string SumCommand = "sum";
            const string CommandExit = "exit";

            bool isProgramWork = true;
            List<int> dynamicArray = new List<int>();

            while (isProgramWork)
            {
                Console.Clear();
                Console.WriteLine($"<--добавить число в массив- просто  введите числа ");
                Console.WriteLine($"{SumCommand}<--сложить все числа в массиве");
                Console.WriteLine($"{CommandExit}<--выйти из программы");
               
                string userInput = Console.ReadLine();
 
                switch (userInput)
                {
                    case SumCommand:
                        SumOfNumbers(dynamicArray);
                        break;

                    case CommandExit:
                        isProgramWork = false;
                        break;

                    default:
                        AddNumber(userInput, dynamicArray);
                        break;
                }

                Console.Write("\nНажмите любую кнопку для того чтобы продолжить");
                Console.ReadKey();
            }
        }

        private static void AddNumber(string userInput, List<int> dynamicArray)
        {
            if (int.TryParse(userInput, out int number))
            {
                dynamicArray.Add(number);
            }
            else
            {
                Console.WriteLine("Неверный ввод!");
            }
        }

        private static void SumOfNumbers(List<int> dynamicArray)
        {
            int arraySum = 0;

            foreach (int number in dynamicArray)
            {
                arraySum += number;
            }

            Console.WriteLine($"сумма чисел в массиве ровна - {arraySum}");
        }
    }
}
