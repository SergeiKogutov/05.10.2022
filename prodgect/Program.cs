// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void printArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine("");
}

string[] array = { "hello", "world", "123", ":-)" };

printArray(array);

string[] selected(string[] Array)
{
    string[] mas = new string[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {  
            mas[i] = Array[i] ;
        }
    }
    return mas;
}

string[] mas = selected(array);
printArray(mas);
