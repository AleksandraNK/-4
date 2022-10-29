// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void Degree (int A, int B)
// {int degree=1;
// for (int i=1; i<=B; i++)
// {
//      degree=degree*A;
// }
// Console.WriteLine (degree);
// }


// Console.Clear();
// Console.WriteLine("Введите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// Degree (A,B);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void Sum (int n)
// {
//     int num = 0;
//     int num1 = 0;
//     int i = 0;
//     int sum =0;
//     while (n>0)
//     {
//         num=n%10;
//         num1=n/10;
//         sum = sum + num;
//         n=num1;
//         i++;
//     }
//     Console.WriteLine (sum);
// }
// Console.Clear();
// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// Sum (n);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] arrey=new int [8];

void Random (int[] arrey)
{
    for (int i=0; i<arrey.Length; i++)
    arrey [i]=new Random().Next();
}

void Print (int[] arrey)
{
    for (int i=0; i<arrey.Length; i++)
    Console.Write ($"{arrey[i]}  ");
}

Random (arrey);
Print (arrey);
