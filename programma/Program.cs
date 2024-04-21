/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Примеры:
[“Hello”, “2”, “world”, “:-)”]             → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”] */

class Program
{
    static void Main(string[] args)
    {
        string[] firstArray = { "Hello", "2", "world", "185", "xyz" };
        string[] newArray = FilterStrings(firstArray);

        Console.WriteLine("Задан массив строк: ");
        PrintArray(firstArray);
        Console.WriteLine();
        Console.WriteLine("Вот из него все значения длинною < или = 3: ");
        PrintArray(newArray);
    }

    static string[] FilterStrings(string[] firstArray)
    {
        int count = 0;
        foreach (string str in firstArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;
        foreach (string str in firstArray)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str;
                index++;
            }
        }

        return newArray;
    }

    static void PrintArray(string[] arr)
    {
        foreach (string str in arr)
        {
            Console.Write(str + "," + " ");
        }
    }
}