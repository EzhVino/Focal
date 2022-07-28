string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input element {i + 1}: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ModifyMassive(string[] massive, int elementSize)
{
    int newSize = 0;
    for (int index = 0; index < massive.Length; index++)
    {
        if (massive[index].Length <= elementSize)
            newSize++;
    }

    if (newSize != 0)
    {

    }

    else Console.WriteLine("Massive contains no required elements");
}