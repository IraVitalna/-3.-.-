// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("ВВедите число");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 1;
if (num1 <= 0)
{
    Console.WriteLine("Неверный ввод");
}
else
{
    while (num2<=num1)
    {
       int res = num2*num2*num2; 
       Console.WriteLine(res);
       num2++;
    }
}