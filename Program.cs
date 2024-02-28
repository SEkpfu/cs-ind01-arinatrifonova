using System;
using System.Data.SqlTypes;

/////////////// 14 вариант
//////// 1
class Progarm
{ 
    static void Main()
    {
        double[] mass1 = new double[8];

        Console.Write("Введите 8 чисел: ");
        for (int i = 0; i < 8; i++)
        {
            mass1[i]= Int32.Parse(Console.ReadLine());
        }

        double[] mass2 = new double[8];
        for (int i = 0; i < 8; i++)
        {
            mass2[i] = Calculate(mass1[i]);
        }

        Console.WriteLine("Новый массив: ");
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(mass2[i]);
        }
        int a = -3, b = 11;

        double sumsr = 0;
        int countsr = 0;

        Console.WriteLine("Числа, которые входят в промежуток: ");
        for (int i = 0; i < 8; i++) 
        {
            if (mass2[i] >= a && mass2[i] <= b) 
            {
                sumsr += mass2[i];
                countsr++;
                Console.WriteLine(mass2[i]);
            }
        }
        Console.WriteLine($"Среднее арифметическое равно: {sumsr/countsr}, {sumsr}, {countsr}");
        // mass1=x mass2=y
        int count = 0;
        for (int i = 0; i < 8; i++) 
        {
            if ((mass1[i] <= 8 && mass1[i] >= 0) && ((mass2[i] - mass2[i])<=8))
            {
                Console.WriteLine(mass1[i]);
                Console.WriteLine(mass2[i]);
                count++;
            }
            else if ((mass1[i] <= 8 && mass1[i] >= 0) && ((mass2[i] - mass2[i]) <= 8))
            {
                Console.WriteLine(mass1[i]);
                Console.WriteLine(mass2[i]);
                count++;
            }
            else if (((mass1[i] * mass1[i] + mass2[i] * mass2[i]) < 8 * 8) && (mass1[i] >= -8 && mass1[i] <= 0) && (mass2[i] >= -8 && mass2[i] <= 0))  
            {
                count++;
            }
            else if (((mass1[i] * mass1[i] + mass2[i] * mass2[i]) < 8 * 8) && (mass1[i] >= -4 && mass1[i] <= 0) && (mass2[i] <= 8 && mass2[i] >= 0))
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел, которые подходят: " + count);
    }

    static double Calculate(double x)
    {
        if (x < -4)
        {
            return ((x * x - 1.0 / x) / 3 * x) * ((x + 3) / 1 + x);
        }
        else if (x >= -4 && x < 6 * Math.PI) 
        {
            return (x - 5) * (x - 5) * Math.Pow(Math.Sin(2 * x), 2.0);
        }
        else
        {
            return 35.0 / 3.0;
        }
    }
}
