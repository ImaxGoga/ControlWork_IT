void foo()
{
    string[] words = new string[4];
    int k=0;
    for (int i = 0; i < words.GetLength(0); i++)
    {
        Console.WriteLine("Введите " + i + " слово: ");
        words[i] = Console.ReadLine();
        if(words[i].Length <= 3)
        k++;
    }
    string[] result = new string[k];
    Console.Write("Ваш массив ");
    PrintArray(words);    
    int j = 0;
    for (int i = 0; i < words.GetLength(0); i++)
    {
        if(words[i].Length <= 3)
        {
            result[j] = words[i];
            j++;
        }
    }
    Console.Write("Результирующий массив ");
    if(result.GetLength(0) == 0)
    Console.Write("[]");
    else PrintArray(result);
}

void PrintArray(string[] mass)
{
    Console.Write("[");
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        if(i != mass.GetLength(0) -1)
        Console.Write(mass[i] + ", ");
        else Console.WriteLine(mass[i] + "]");
    }
}

foo();
