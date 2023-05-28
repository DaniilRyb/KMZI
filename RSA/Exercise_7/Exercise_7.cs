/*
 Задание 7 - RSA
Напишите программу, представляющую число 𝑚 в каноническом
разложении по степеням простых чисел. 
*/

public class DZ2_Exercise_7  {

    // Функция для получения всех простых множителей числа
    private static List<int> GetPrimeFactors(int number)
    {
        List<int> primeFactors = new List<int>();

        // Проверяем делимость на 2
        while (number % 2 == 0)
        {
            primeFactors.Add(2);
            number /= 2;
        }

        // Проверяем делимость на остальные нечетные числа
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            while (number % i == 0)
            {
                primeFactors.Add(i);
                number /= i;
            }
        }

        // Если number > 2, оставшееся число является простым множителем
        if (number > 2)
        {
            primeFactors.Add(number);
        }

        return primeFactors;
    }

    // Функция для получения степени простого множителя в разложении числа
    private static int GetPowerOfPrimeFactor(int number, int primeFactor)
    {
        int power = 0;

        while (number % primeFactor == 0)
        {
            power++;
            number /= primeFactor;
        }

        return power;
    }
    public static void Exercise_7()
    {
        Console.WriteLine("Введите число:");
        string numberString = Console.ReadLine();
        int m = Convert.ToInt32(numberString);
        
        if (m < 2)
        {
            Console.WriteLine("Число не может быть разложено по степеням простых чисел.");
            return;
        }

        Console.WriteLine("Каноническое разложение числа {0}:", m);
        
        
        List<int> primeFactors = GetPrimeFactors(m);

        for (int i = 0; i < primeFactors.Count; i++)
        {
            int primeFactor = primeFactors[i];
            int power = GetPowerOfPrimeFactor(m, primeFactor);

            Console.WriteLine("{0}^{1}", primeFactor, power);

            // Пропускаем повторные простые множители
            while (i + 1 < primeFactors.Count && primeFactors[i + 1] == primeFactor)
            {
                i++;
            }
        }
    }
}
