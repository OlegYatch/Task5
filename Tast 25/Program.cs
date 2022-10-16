/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

Console.WriteLine("Введите число N ");
int N= int.Parse(Console.ReadLine());
int SumNumber()
{
    int count=Convert.ToString(N).Length;
    int variable = 0;
    int result = 0;
    
for (int i=0; i<count; i++)
{
    count = N-N%10;
    result=result + (N-count);
    N=N/10;
}
return result; 
}
int sumN=SumNumber();
Console.WriteLine(sumN);