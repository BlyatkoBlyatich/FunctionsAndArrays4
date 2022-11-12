int [] CreateArray(int size)
{
    int[] array = new int[size]; // выделили память и размер, выделите под переменный int сайз штук. (имя массива, тип массива, память (new int))
    Console.WriteLine("Input data of array (array = size): ");
    for(int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Your array components is: ");
    for(int i = 0; i < array.Length; i++) // пока инлекс массива = 0, а индекс массива меньше его длинны, прибавляем индекс массива
    {
        Console.Write(array[i] + " "); // обращаемся к массиву и выводим числа через пробел
    }
    Console.WriteLine(); // пропуск строки
}

Console.WriteLine("Input size of array");
int num = Convert.ToInt32(Console.ReadLine());

int[] Numbers = CreateArray(num); //применяем метод для введенного нами размера
ShowArray(Numbers); // выводим и показываем массив