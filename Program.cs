// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers(int n)
// {
//     if(n>0)
//     {
//         Console.Write(n + ", ");
//         ShowNumbers(n-1);
//     }
//     // Console.Write(n + " ");
// }

// Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);

/////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// void FindNumberSum (int numberM, int numberN, int sum)
// {
//     if (numberM > numberN) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (numberM++);
//     FindNumberSum(numberM, numberN, sum);
// }

// Console.WriteLine("Введите начальное число M:");
// int numberM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите начальное число N:");
// int numberN = Convert.ToInt32(Console.ReadLine());

// FindNumberSum(numberM, numberN, 0);