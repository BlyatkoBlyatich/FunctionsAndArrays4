//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int [] CreateArray(int size, int maxValue, int minValue)
{
    int[] array = new int[size]; // выделили память и размер, выделите под переменный int сайз штук. (имя массива, тип массива, память (new int))
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1); //+1 потому что последний элемент не войдет в массив
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) // пока инлекс массива = 0, а индекс массива меньше его длинны, прибавляем индекс массива
    {
        Console.Write(array[i] + " "); // обращаемся к массиву и выводим числа через пробел
    }
    Console.WriteLine(); // пропуск строки
}

Console.WriteLine("Vvedite razmer massiva");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite maximal'noe znachenie");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite minimal'noe znachenie");
int min = Convert.ToInt32(Console.ReadLine());

int[] MyArray = CreateArray(a, max, min);
ShowArray(MyArray);

