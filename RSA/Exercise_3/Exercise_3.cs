/*
 Реализуйте в приведенной системе вычетов поиск мультипликативного
    обратного с использованием расширенного алгоритма Евклида.
*/

/* В этой программе функция FindModularInverse находит мультипликативный обратный числа a по модулю m.
    Она вызывает функцию BinaryExtendedEuclidean для вычисления расширенного алгоритма Евклида и проверяет, что НОД a и m равен 1.
    Затем она возвращает мультипликативный обратный, вычисляемый с использованием формулы (x % m + m) % m, 
чтобы обеспечить положительный результат. */


public class DZ_Exercise_3
{
    private static long FindModularInverse(long a, long m)
    {
        long gcd, x, y;
        BinaryExtendedEuclidean(a, m, out gcd, out x, out y);

        if (gcd != 1)
        {
            throw new ArithmeticException("Мультипликативный обратный не существует.");
        }

        return (x % m + m) % m;
    }

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
    
    public static void Exercise_3()
    {
        
        Console.WriteLine("Введите число:");
        long number = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Введите модуль:");
        long modulus = Convert.ToInt64(Console.ReadLine());

        try
        {
            long inverse = FindModularInverse(number, modulus);
            Console.WriteLine("Мультипликативный обратный числу " + number + " по модулю " + modulus + " равен " + inverse);
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
        
    }
    