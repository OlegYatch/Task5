/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.WriteLine("Введите число А ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B ");
int B = int.Parse(Console.ReadLine());
int Exponentiation()
{
    int result=1;
    for (int i=1; i<=B; i++)
    {
        result=result*A;
    }
    return result;

}
int exp=Exponentiation();
Console.WriteLine("Возведение числа А в степень В = " + exp);