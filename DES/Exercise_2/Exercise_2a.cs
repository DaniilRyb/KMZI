/*
Задание 2а - DES
A) «Склеить» первые 𝑖 битов с последними 𝑖 битами из целого числа
длиной 𝑙𝑒𝑛 битов. Пример. Пусть есть 12-разрядное целое число,
представленное в двоичной системе счисления 100011101101.
«Склеим» первые 3 и последние 3 бита, получим 100101. 
*/

public static class DZ1_Exercise_2a
{
    private static int GlueBits(string binaryNumber, int i)
    {
        var result = 0;
        var len = binaryNumber.Length;
        if (i >= len)
        {
            Console.WriteLine("Некорректное значение i.");
            return 0;
        }

        var firstBits = Convert.ToInt32(binaryNumber.Substring(0, i), 2); // Преобразуем первые i битов в целое число
        var lastBits = Convert.ToInt32(binaryNumber.Substring(len - i, i), 2); // Преобразуем последние i битов в целое число
        result = (firstBits << i) | lastBits; // "Склеиваем" первые i битов с последними i битами
        return result;
    }

    public static void Main()
    {
        Console.Write("Введите целое число в двоичной системе счисления: ");
        var binaryNumber = Console.ReadLine();
        Console.Write("Введите количество битов, которые нужно склеить (i): ");
        var i = Convert.ToInt32(Console.ReadLine());
        var resultGlueNumbers = GlueBits(binaryNumber, i);
        var binaryResult = Convert.ToString(resultGlueNumbers, 2); // Преобразуем результат в двоичное число
        Console.WriteLine($"Результат: {binaryResult.PadLeft(i * 2, '0')}");
    }
}