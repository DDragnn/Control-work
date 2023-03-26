// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Пример:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]


string[] arr1 = new string[] {"hello", "2", "world", ":-)"};
string[] arr2 = new string[arr1.Length];
int count = 0;
void SecondArrayWithIF(string[] arr1, string[] arr2)
{
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}
SecondArrayWithIF(arr1, arr2);
PrintArray(arr2);

