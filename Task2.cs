/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int n = 0;
int m = 0;

Console.Write("Введите первое значение: ");
bool boolN = int.TryParse(Console.ReadLine(), out int numberN);
Console.Write("Введите второе значение: ");
bool boolM = int.TryParse(Console.ReadLine(), out int numberM);

//Check 
if (!boolN || !boolM)
    Console.WriteLine("Не верно введены значения! Введите число!");
else
{
    n = numberN;
    m = numberM;
}

//sum of range numbers from recursion
int sumOfRangeNumbers(int n, int m)
{
    int sum = m;
    {
        if (m > n)
        {
            sum += sumOfRangeNumbers(n, m - 1);
        }
        return sum;
    }
}

int result = sumOfRangeNumbers(n, m);
Console.WriteLine(result);
