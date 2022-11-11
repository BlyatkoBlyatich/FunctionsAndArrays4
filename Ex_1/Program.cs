//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Pow(int num1, int num2)
{
    int result = 1;
    for(int i = 0; i < num2; i++)
    {
        result *= num1;
    }
    return result;
}

Console.WriteLine("Input first number");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inpur second number");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Stpyen num1 in num2 = {Pow(a, b)}");
