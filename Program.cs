// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []  

// P/s: добавил условие при котором, если все элементы слишком большие выводится сообщение "Все элементы слишком большие"



using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива строк через запятую, без пробелов: ");

        // Чтение введенной строки с элементами массива
        string input = Console.ReadLine();

        // Разделение строки на элементы по запятой
        string[] inputArray = input.Split(',');

        // Формирование нового массива из строк, длина которых равна 3 или меньше символов
        string[] resultArray = FilterStrings(inputArray);

        // Вывод результатов
        if (resultArray.Length == 0)
        {
            Console.WriteLine("Все элементы массива слишком большие");
        }
        else
        {
            Console.WriteLine("Элементы в массиве, длина которых равна 3 или меньше символам:");

            foreach (string str in resultArray)
            {
                Console.WriteLine(str);
            }
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        // Подсчет количества строк, удовлетворяющих условию
        int count = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length < 4)
            {
                count++;
            }
        }

        // Создание нового массива
        string[] resultArray = new string[count];

        // Заполнение нового массива подходящими строками
        int index = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length < 4)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }
}
