/* С использованием следующего факта
    𝜑(𝑎) = 𝑎 ∏ (1 − 1),
реализуйте вычисление функции Эйлера.
*/

public class DZ2_Exercise_8
{
    private static int EulerPhi(int a)
    {
        int result = a;
        for (int p = 2; p * p <= a; p++)
        {
            if (a % p == 0)
            {
                while (a % p == 0)
                {
                    a /= p;
                }
                result -= result / p;
            }
        }
        if (a > 1)
        {
            result -= result / a;
        }
        return result;
    }
    
    public static void Exercise_8()
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int eulerPhi = EulerPhi(number);
        Console.WriteLine("Функция Эйлера для числа " + number + " равна " + eulerPhi);
        
    }
}