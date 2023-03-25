string[] filledArray = new string[7] {"git", "java", "C#", "python", "github", "sql", "GB"};
string[] currentArray = new string[7];

void NewArray(string[] filledArray, string[] currentArray)
{
    int count = 0;
    for (int i = 0; i < filledArray.Length; i++)
    {
    if(filledArray[i].Length <= 3)
        {
        currentArray[count] = filledArray[i];
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
NewArray(filledArray, currentArray);
PrintArray(currentArray);