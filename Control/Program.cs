void foo()
{
    string[] words = new string[4];
    for (int i = 0; i < words.GetLength(0); i++)
    {
        Console.WriteLine("Введите " + i + " слово: ");
        words[i] = Console.ReadLine();
    }
    Console.Write("Ваш массив [");
    for (int i = 0; i < words.GetLength(0); i++)
    {
        if(i != words.GetLength(0) -1)
        Console.Write(words[i] + ", ");
        else Console.WriteLine(words[i] + "]");
    }
}

foo();
