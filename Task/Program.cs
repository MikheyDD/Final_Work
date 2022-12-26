// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = {"Hello", "2", "world", ":-"};
Print(array);
Console.WriteLine();
string[] resultArray = GetArrayOfShorterElemets(array, 3);
Print(resultArray);

string[] GetArrayOfShorterElemets(string[] arr, int maxLenght)
{
    int length = arr.Length;
    string[] tempResult = new string[length];
    string elem = string.Empty;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        elem = arr[i];
        if (elem.Length <= maxLenght)
        {
            tempResult[count] = elem;
            count++;
        }
    }
    string[] result = new string[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = tempResult[i];
    }
    return result;
}



void Print(string[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
}