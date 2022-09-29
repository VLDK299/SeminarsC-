
string[] array = new string[5] {"0", "11", "123", "4444", "555555"};

void ShowArray(string[] array)
{
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}


ShowArray(array);