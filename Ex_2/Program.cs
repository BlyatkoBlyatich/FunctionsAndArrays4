 //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfNum(int number)
{
    int sum = 0;
    while(number != 0)
    {
        sum = sum + number%10; // присваем значение sum последнее цифру вводимого числа
        number = number/10; // избавляемся от последней цифры введенного числа и переходим к циклу, пока число не равно 0
    }
    return sum; // возвращаем полученное значение sum и завершаем метод
}

Console.WriteLine("Input a number"); // вводим число
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" Sum of digit number is: {SumOfNum(num)}"); // выводим получение значение, рез