Console.Write("Введите значения элементов массива строк через пробел: ");
string[] stringArray = Console.ReadLine().Split().ToArray();



void PrintArray(string[] stringArr)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (i < (stringArray.Length - 1)) Console.Write($"{stringArray[i]}, ");
        else Console.Write($"{stringArray[i]}");
    }
    Console.Write("]");
}

PrintArray(stringArray);