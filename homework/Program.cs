string[] StringArray(string[] array)
{
    string[] MyArray = new string[array.Length];
    int ElementsCount = 0; 
    for(int i=0; i < array.Length; i++)
        if(array[i].Length <= 3)
    {
            MyArray[ElementsCount++] = array[i];
    }
    string[] result = new string[ElementsCount];
    for(int i = 0; i < ElementsCount; i++)
        result[i] = MyArray[i];
    return result;
}
void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i+1} элемент: ");
        array[i] = Console.ReadLine();
    }
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
}

Console.Write("Введите колличество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myStringArray = new string[size];
InputArray(myStringArray);
string[] processedArray = StringArray(myStringArray);
Console.WriteLine("В массиве элементов <= 3: ");
ShowArray(processedArray);