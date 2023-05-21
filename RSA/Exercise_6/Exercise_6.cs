/*
 Задание 6 - RSA
 Напишите функцию, вычисляющую значение 𝜑(𝑚), где
𝜑(𝑚) −функция Эйлера (по определению)
 */

public static class DZ2_Exercise_6
{
    
    private static int EulerPhiCalculate(int m)
    {
        int result = m; // Изначально присваиваем результату значение m

        // Итеративно находим все простые числа p, которые делят m,
        // и вычитаем из результата значение result / p
        // до тех пор, пока m не станет равно 1
        
        for (int p = 2; p * p <= m; p++)
        {
            if (m % p == 0) // Если p является делителем m
            {
                while (m % p == 0)
                    m /= p; // Делим m на p, пока оно делится на p

                result -= result / p; // Вычитаем result / p из результата
            }
        }

        // Если m > 1, то m является простым числом, и мы вычитаем
        // result / m из результата
        if (m > 1)
            result -= result / m;

        return result;
    }
    public static void Main()
    {
        Console.WriteLine("Введите число:");
        string numberString = Console.ReadLine();
        int number = Convert.ToInt32(numberString);
        int phiCalculate = EulerPhiCalculate(number);
        Console.WriteLine("EulerPhi({0}) = {1}", number, phiCalculate);

    }
    
}