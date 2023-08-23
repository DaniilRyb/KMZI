/*
 * Задание 1 - RSA
 * Алгоритм Евклида.
 */
public class Exercise_1
{
    private static int algorithmEvklid(int a, int b)
    {
        // Приводим a и b к неотрицательным значениям
        a = Math.Abs(a);
        b = Math.Abs(b);

        // Проверяем, является ли b равным нулю.
        // Если да, то возвращаем a как результат.
        if (b == 0)
            return a;

        // Вычисляем остаток от деления a на b
        int remainder = a % b;

        // Рекурсивно вызываем алгоритм Евклида для b и остатка
        return algorithmEvklid(b, remainder);
    }

    public static void Exercise()
    {
        Console.WriteLine("Введите число a и b:");
        int number_a = 0, number_b = 0;
        string a = Console.ReadLine();
        number_a = Convert.ToInt32(a);
        string b = Console.ReadLine();
        number_b = Convert.ToInt32(b);
        int gcd = algorithmEvklid(number_a, number_b);
        Console.WriteLine("GCD({0}, {1}) = {2}", a, b, gcd);        
    }
    
}
