using System;

namespace krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tКалькулятор\n");
            A:
            Console.WriteLine("\tВыберите действие:\n" + "1) - сложение\n" + "2) - вычитание\n" + "3) - умножение\n" + "4) - деление\n" + "5) - возведение в степень\n" + "6) - корень числа\n" + "7-8) - не сделал\n"
                + "9) - выход\n");
            B:
            string enter = Console.ReadLine();
            int e = Convert.ToInt32(enter);
            double a, b, c;

            switch (e)
            {
                case 1:
                    Console.WriteLine("Введите первое слагаемое");
                    enter = Console.ReadLine();
                    a = Convert.ToDouble(enter);
                    Console.WriteLine("Введите второе слагаемое");
                    enter = Console.ReadLine();
                    b = Convert.ToDouble(enter);
                    c = a + b;
                    Console.WriteLine("Итог сложения:" + c + "\n");
                    goto A;
                case 2:
                    Console.WriteLine("Введите уменьшаемое");
                    enter = Console.ReadLine();
                    a = Convert.ToDouble(enter);
                    Console.WriteLine("Введите вычитаемое");
                    enter = Console.ReadLine();
                    b = Convert.ToDouble(enter);
                    c = a - b;
                    Console.WriteLine("Итог разности:" + c + "\n");
                    goto A;
                case 3:
                    Console.WriteLine("Введите первый множитель");
                    enter = Console.ReadLine();
                    a = Convert.ToDouble(enter);
                    Console.WriteLine("Введите второй множитель");
                    enter = Console.ReadLine();
                    b = Convert.ToDouble(enter);
                    c = a * b;
                    Console.WriteLine("Итог умножения:" + c + "\n");
                    goto A;
                case 4:
                    Console.WriteLine("Введите делимое");
                    enter = Console.ReadLine();
                    a = Convert.ToDouble(enter);
                    Console.WriteLine("Введите делитель");
                    enter = Console.ReadLine();
                    b = Convert.ToDouble(enter);
                    c = Math.Pow(a, b);
                    Console.WriteLine("Итог деления:" + c + "\n");
                    goto A;
                case 5:
                    Console.WriteLine("Введите число");
                    enter = Console.ReadLine();
                    a = Convert.ToDouble(enter);
                    Console.WriteLine("Введите степень");
                    enter = Console.ReadLine();
                    b = Convert.ToDouble(enter);
                    c = Math.Pow(a, b);
                    Console.WriteLine("Итог возведения:" + c + "\n");
                    goto A;
                case 6:
                    Console.WriteLine("Выберите степень корня\n" + "1) - квадратный корень\n" + "2) - кубический корень\n");
                    enter = Console.ReadLine();
                    int k = Convert.ToInt32(enter);
                    if (k == 1)
                    {
                        Console.WriteLine("Введите число\n");
                        enter = Console.ReadLine();
                        a = Convert.ToDouble(enter);
                        c = Math.Sqrt(a);
                        Console.WriteLine("Итог извлечения корня:" + c + "\n");
                        goto A;
                    }
                    else if (k == 2)
                    {
                        Console.WriteLine("Введите число\n");
                        enter = Console.ReadLine();
                        a = Convert.ToDouble(enter);
                        c = Math.Pow(a, 1 / 3f);
                        Console.WriteLine("Итог извлечения корня:" + c + "\n");
                    }
                    goto A;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такого действия нет");
                    goto B;
            }
        }
    }
}