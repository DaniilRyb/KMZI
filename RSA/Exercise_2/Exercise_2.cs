/*Реализуйте (бинарный) расширенный алгоритм Евклида. */

public class DZ2_Exercise_2 {

    private static void BinaryExtendedEuclidean(long a, long b, out long gcd, out long x, out long y)
    {
        long x0 = 1, y0 = 0, x1 = 0, y1 = 1;

        while (b != 0)
        {
            long quotient = a / b;

            long tempX = x0 - quotient * x1;
            long tempY = y0 - quotient * y1;

            x0 = x1;
            y0 = y1;
            x1 = tempX;
            y1 = tempY;

            long temp = b;
            b = a - quotient * b;
            a = temp;
        }

        gcd = a;
        x = x0;
        y = y0;
    }   
    public static void Exercise_2()
    {
        
        Console.WriteLine("Введите первое число:");
        long a = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        long b = Convert.ToInt64(Console.ReadLine());

        long gcd, x, y;
        BinaryExtendedEuclidean(a, b, out gcd, out x, out y);

        Console.WriteLine("НОД(" + a + ", " + b + ") = " + gcd);
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);

    }
}


