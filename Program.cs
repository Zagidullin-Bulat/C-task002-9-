// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");

if (m > n)
    Console.WriteLine("Ошибка, введите верные данные.");
    
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
        
    return n + CountNaturalSum(m, n - 1);
}

Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");