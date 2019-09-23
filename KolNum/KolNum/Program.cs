using System;

namespace KolNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int x = int.Parse(Console.ReadLine());
            int kol = 0;
            int sum = 0;
            int KolOrder = 0;
            while (x != 0)
            {
                 if (x % 10 % 2 == 0) 
                 {
                  sum = sum + (x % 10);
                  kol++;
                         
                 }
                    if (x % 10 % 3 == 0)
                    {
                    KolOrder++;
                    }
                  
             x = x / 10;
            }
         // Console.WriteLine("Сумма четных  " + sum);
           Console.WriteLine("Кол-во Четных цифр= " + kol + "  Сумма четных цифр = " + sum);
           Console.WriteLine("Кол-во Чисел кратных 3 :  " + KolOrder++);
           Console.ReadKey();
        }
    }
}
