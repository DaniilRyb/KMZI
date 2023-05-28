/*
 Задание 5 - RSA
 Напишите программу, выводящую все простые числа, которые меньше 𝑚.
*/

public static class DZ2_Exercise_5
{
    private static bool[] eratosphenAlgorithm(int number, bool[] isPrime)
    {
        for (int i = 2; i * i < number; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j < number; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        return isPrime;
    }
    private static bool[] initArrayIsPrime(int m, bool[] isPrime)
    {
        for (int i = 2; i < m; i++) isPrime[i] = true;
        return isPrime;
    }
    private static void printResultEratosphenAlgorithm(int m, bool[] isPrime)
    {
        // Вывод простых чисел
        Console.WriteLine("Простые числа меньше {0}:", m);
        for (int i = 2; i < m; i++)
        {
            if (isPrime[i])
            {
                Console.Write("{0} ", i);
            }
        }
    }

    public static void Exercise_5()
    {
        Console.WriteLine("Введите число 𝑚: ");
        string numberString = Console.ReadLine();
        int m = Convert.ToInt32(numberString);
        
        if (m < 2)
        {
            Console.WriteLine("Простых чисел нет");
            return;
        }

        // Создаем массив для хранения информации о простоте чисел
        bool[] isPrimeInit = new bool[m];
        bool[] isPrime = initArrayIsPrime(m, isPrimeInit);
        bool[] isPrimeResult = eratosphenAlgorithm(m, isPrime);
        printResultEratosphenAlgorithm(m, isPrimeResult);
        
    }
}
