/*
Задание 2B - DES
B) Получить биты из целого числа длиной 𝑙𝑒𝑛 битов, находящиеся между первыми 𝑖 битами и последними 𝑖 битами.
Пример. Пусть есть 12-разрядное целое число, представленное в двоичной системе счисления 100011101101.
Получим биты находящиеся между первыми 3 и последними 3 битами: 011101.
 */


public static class DZ1_Exercise_2b
{
    
    private static uint middle_bits(uint number, int i, int len)
    {
        return ((number >> i) << (32 - len + 2 * i)) >> (32 - len + 2 * i);
    }
    
    public static void Exercise_2b()
    {
        
        int i = 0;
        string number = "";
        Console.WriteLine($"Введите число:");
        number = Console.ReadLine();
        int len = number.Length;

        uint num = Convert.ToUInt32(number, 2);
        Console.WriteLine($" Введите i");
        i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"2: {Convert.ToString(middle_bits(num, i, len),2)}");

    }
}