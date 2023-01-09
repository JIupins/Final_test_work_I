// Написать программу которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна трем символам.
// Пример: ["hello", "2", "worid", ":-)"] => ["2", ":-)"]

Console.Clear();

string[] CreateArray(int num)
{
    Console.WriteLine();

    string[] arrA = new string[num];

    for (int i = 0; i < arrA.Length; i++)
    {
        Console.Write($"Введите значение {i + 1}-го элемента рассматриваемого ряда (массива): ");
        arrA[i] = Console.ReadLine();
    }

    return arrA;
}

void WriteArray(string phrase, int num, string[] arr)
{
    Console.WriteLine();

    Console.Write(phrase);

    foreach (string i in arr)
    {
        Console.Write($"{i} ");
    }
}

string[] DetectNewArrayWithlenghtOfWordlessThreeChars(string[] arr)
{
    Console.WriteLine();

    string[] arrB = new string[arr.Length];

    int count = default;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrB[count] = arr[i];

            count++;
        }
    }

    Array.Resize(ref arrB, count);

    return arrB;
}

Console.Write("Введите колличество эллементов в рассматриваемом ряду (массиве): ");
int number = Convert.ToInt32(Console.ReadLine());

string[] array = CreateArray(number);

WriteArray($"Сгенерирован произвольный массив из {number} элементов: ", number, array);

array = DetectNewArrayWithlenghtOfWordlessThreeChars(array);

WriteArray($"Сформирован новый массив из {array.Length} элементов, длинна элементов в котором не превышает 3-х символов: ", array.Length, array);