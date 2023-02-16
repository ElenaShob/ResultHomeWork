string [] Select (string[]array)
{
int size = array.Length;
string[] tempArray = new string[size];
int j=0;
for (int i=0; i<size; i++)
    if (array[i].Length <= 3)
    {
        tempArray[j] = array[i];
        j +=1;
    }
string[] newArray = new string[j];
for (int i=0; i<j; i++)   
newArray[i] = tempArray[i]; 
return newArray;
}

void ShowArray(string[] array)

{
    for( int i = 0; i < array.Length; i++)
    {
    if (i == array.Length-1)
    Console.Write(array[i] + ". ");
    else
    Console.Write(array[i] + ", ");
    }

    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] oldArray = new string[size];
for(int i = 0; i < size; i++)
{
Console.Write("Введите строку массива: ");
oldArray[i] = Console.ReadLine();
}
Console.Write("Введенный массив: ");
ShowArray(oldArray);
string[] newArray = Select(oldArray);
Console.Write("Новый массив: ");
ShowArray(newArray);
