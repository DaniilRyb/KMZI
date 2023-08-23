/* Выведите на экран приведенную систему вычетов по модулю 𝑚. */

/* В этом примере функция PrintReducedResidues выводит приведенную систему вычетов от 1 до 𝑚-1, 
проверяя каждое число с использованием алгоритма нахождения наибольшего общего делителя (GCD).
    Если НОД числа и модуля равен 1, то число взаимно простое с 𝑚 и входит в приведенную систему вычетов.
*/

public class DZ2_Exercise_4
{
    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    private static void PrintReducedResidues(int m)
    {
        for (int i = 1; i < m; i++)
        {
            if (GCD(i, m) == 1)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void Exercise4()
    {
        Console.WriteLine("Введите модуль:");
        int modulus = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Приведенная система вычетов по модулю " + modulus + ":");
        PrintReducedResidues(modulus);
    }
}