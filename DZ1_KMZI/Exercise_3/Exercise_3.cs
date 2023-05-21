// пример 32 битного числа для проверки: 10101011100111011100101011111001

public static class DZ1_Exercise_3
{

    public static void Exercise3()
    {

        Console.Write("Введите 32-разрядное целое число в двоичной системе счисления: ");
        string binaryNumber = Console.ReadLine();

        if (binaryNumber.Length != 32)
        {
            Console.WriteLine("Некорректная длина числа. Введите 32-разрядное число.");
            return;
        }

        Console.Write("Введите номер первого байта (от 0 до 3): ");
        int firstByte = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер второго байта (от 0 до 3): ");
        int secondByte = Convert.ToInt32(Console.ReadLine());

        if (firstByte < 0 || firstByte > 3 || secondByte < 0 || secondByte > 3)
        {
            Console.WriteLine("Некорректный номер байта. Введите число от 0 до 3.");
            return;
        }

        int number = Convert.ToInt32(binaryNumber, 2); // Преобразуем число из двоичного представления в целое число

        int byteMask = 0xFF; // Маска для извлечения байта
        int shift1 = firstByte * 8;
        int shift2 = secondByte * 8;

        int byte1 = (number >> shift1) & byteMask; // Извлекаем первый байт
        int byte2 = (number >> shift2) & byteMask; // Извлекаем второй байт

        int swappedNumber = number & ~(byteMask << shift1) & ~(byteMask << shift2); // Обнуляем байты в исходном числе
        swappedNumber |= byte1 << shift2; // Заменяем первый байт на позиции второго байта
        swappedNumber |= byte2 << shift1; // Заменяем второй байт на позиции первого байта

        string swappedBinaryNumber = Convert.ToString(swappedNumber, 2).PadLeft(32, '0'); // Преобразуем результат в двоичное число

        Console.WriteLine($"Результат: {swappedBinaryNumber}");
    }
}