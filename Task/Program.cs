
string[] array = new string[5] {"123", "23", "hello", "world", "res"};
string[] newarray = new string[array.Length];
void ChangeArray(string[] array, string[] newarray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newarray[count] = array[i];
        count++;
        }
    }
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ChangeArray(array, newarray);
ShowArray(newarray);