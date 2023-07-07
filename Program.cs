// Допущение для всех задач: Пользователь вводит адекватные значение 
// (если в условии задачи написано "возводит число A в натуральную степень B", то мы допускаем, 
// что число B на вход мы получим натуральное, а вот А может быть любое, иначе придется использовать слишком много проверок)

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Task 66:");
Console.WriteLine();

int SumOfNaturals(int n, int m)
{
    if (Math.Max(n,m) < 0)
    {
        return 0;
    }
    if(Math.Min(n,m) < 0)
    {
        return SumOfNaturals(1, Math.Max(n,m));
    }
    if(n != m) 
    {
        return Math.Min(n,m) + SumOfNaturals(Math.Min(n,m) + 1, Math.Max(n,m));
    }
    return Math.Min(n,m);
}


Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

int res = SumOfNaturals(m ,n);
if (res == 0)
    Console.WriteLine("M and N < 0");
else
    Console.Write(res);