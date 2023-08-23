/*
 Задание 9 - RSA
 * Напишите программу быстрого возведения в степень по модулю 𝑚.
 */

public class DZ2_Exercise_9
{
    private static long ModuloPower(long baseNumber, long exponent, long m)
    {
        if (m == 1)
            return 0;
        
        long result = 1;
        baseNumber %= m;
        
        while (exponent > 0)
        {
            if ((exponent & 1) == 1)
                result = (result * baseNumber) % m;
            
            exponent >>= 1;
            baseNumber = (baseNumber * baseNumber) % m;
        }
        
        return result;
    }
    public static void Exercise_9()
    {
        Console.WriteLine("Введите основание числа:");
        long baseNumber = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine("Введите показатель степени:");
        long exponent = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine("Введите модуль:");
        long m = Convert.ToInt64(Console.ReadLine());
        
        long result = ModuloPower(baseNumber, exponent, m);
        Console.WriteLine("Результат: " + result);
    }
    
}