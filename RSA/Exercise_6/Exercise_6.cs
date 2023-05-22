/*
 Задание 6 - RSA
 Напишите функцию, вычисляющую значение 𝜑(𝑚), где
𝜑(𝑚) −функция Эйлера (по определению)
 */

public static class DZ2_Exercise_6
{
    // Функция для вычисления наибольшего общего делителя (НОД) двух чисел
    private static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        
        return GCD(b, a % b);
    }

    // Функция для вычисления функции Эйлера (функции 𝜑)
    private static int EulerPhiCalc(int m)
    {
        int result = 1;

        for (int i = 2; i < m; i++)
        {
            if (GCD(i, m) == 1)
                result++;
        }

        return result;
    }


    public static void Main()
    {
        Console.WriteLine("Введите число:");
        string numberString = Console.ReadLine();
        int number = Convert.ToInt32(numberString);
        int phiCalculate = EulerPhiCalc(number);
        Console.WriteLine("EulerPhi({0}) = {1}", number, phiCalculate);

    }
    
}