using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
            //Данный алгоритм, написанный по блок-схеме, неверно обрабатывает число 1
            //С математической точки зрения единица не является простым числом.
            //В комментариях минимальные изменения, которые можно внести, чтобы это пофиксить
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int d = 0;
            int i = 2; //i = 1;
            while (i < number) 
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0) Console.WriteLine("Простое"); //if (d == 1)
            else Console.WriteLine("Не простое"); 

        }
    }
}
