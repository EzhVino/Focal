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
        string[] newMassive = new string[newSize];
        for (int i = 0, j = 0; j < newSize; i++)
        {
            if (massive[i].Length <= elementSize)
            {
                newMassive[j] = massive[i];
                j++;
            }
        }
        ShowArray(newMassive);
    }
    else Console.WriteLine("Massive contains no required elements");
}

Console.Clear();

Console.WriteLine("Specify size of the massive:");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(arraySize);

Console.WriteLine();
ShowArray(myArray);

Console.WriteLine();
ModifyMassive(myArray, 3);