/*
 Задание 1 - DES
 С клавиатуры вводится 32-разрядное целое число 𝑎 в двоичной системе счисления.
1. Вывести 𝑘 −ый бит числа 𝑎. Номер бита предварительно запросить у пользователя.
2. Установить/снять 𝑘 −ый бит числа 𝑎.
3. Поменять местами 𝑖 −ый и 𝑗 −ый биты в числе 𝑎. Числа 𝑖 и 𝑗 предварительно запросить у пользователя.
4. Обнулить младшие 𝑚 бит.
пример 32 битного числа для проверки: 10101011100111011100101011111001
*/

public static class DZ1_Exercise_1
{

    // Проверяем, что введенная строка состоит из 32 символов, содержащих только '0' и '1'
    private static bool IsValidBinaryNumber(string binaryNumber)
    {
        foreach (var ch in binaryNumber)
            if (ch != '0' && ch != '1')
                return false;
        return true;
    }

    // Сдвигаем число a на k позиций вправо и применяем побитовую маску для получения значения бита
    private static int searchBitInNumber(int a, int k)
    {
        return (a >> k) & 1;
    }
    private static string SetOrResetBit(int number, int operation, int k)
    {
        
        int bitMask = 1 << k; // Создаем маску путем сдвига 1 на k позиций влево
        if (operation == 1)
        {
             number |= bitMask; // Установка бита в 1 с помощью побитовой операции "ИЛИ"
        }
        else if (operation == 0)
        {
             number &= ~bitMask; // Снятие бита (установка в 0) с помощью побитовой операции "И с инверсией"
        }
        
        return Convert.ToString(number, 2);;
    }
    
    private static int swapBits(int i, int j, int number)
    {
        int bitMaskI = 1 << i; // Создаем маску для бита i путем сдвига 1 на i позиций влево
        int bitMaskJ = 1 << j; // Создаем маску для бита j путем сдвига 1 на j позиций влево
                
        int bitValueI = (number >> i) & 1; // Получаем значение бита i
        int bitValueJ = (number >> j) & 1; // Получаем значение бита j
                
        if (bitValueI != bitValueJ)
        {
            // Используем побитовые операции для смены значений битов i и j
            number = (number & ~bitMaskI) | (bitValueJ << i);
            number = (number & ~bitMaskJ) | (bitValueI << j);
        }

        return number;
    }

    private static int ResetLowerBits(int m, int number)
    {
        int bitMask = (1 << m) - 1; // Создаем маску путем сдвига 1 на m позиций влево и вычитаем 1
        number &= ~bitMask; // Обнуляем младшие m бит с помощью побитовой операции "И с инверсией"   
        return number;
    }

    public static void Exercise_1()
    {
        Console.Write("Введите 32-разрядное целое число a в двоичной системе счисления: ");
        string? binaryNumber = Console.ReadLine();

        var number = Convert.ToInt32(binaryNumber, 2);
        // Справа на лево (младшие биты справа)
        // 1
        Console.WriteLine(
            "Введите команды от 1-4: \n" +
            "1. Вывести 𝑘 −ый бит числа 𝑎.\n" +

            "2. Установить/снять 𝑘 −ый бит числа 𝑎\n" +
            "3. Поменять местами байты в заданном 32-разрядном числе \n" +
            "4. Введите количество нулей для обнуления младших 𝑚 бит:");
                          
        string command = "";
        command = Console.ReadLine();
        switch (command)
        {
            case "1":
                if (binaryNumber?.Length != 32 || !IsValidBinaryNumber(binaryNumber))
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите 32-разрядное число в двоичной системе.");
                    return;
                }

                Console.Write("Введите номер бита k: ");
                int position = Convert.ToInt32(Console.ReadLine());
                int bitValue = searchBitInNumber(number, position);
                Console.WriteLine($"Значение {position}-го бита числа {binaryNumber} равно: {bitValue}");
                
                break;
            
            case "2":
                Console.Write("Введите номер бита k: ");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.Write("Выберите операцию (1 - установить бит, 0 - снять бит): ");
                int operation = Convert.ToInt32(Console.ReadLine());
                string resultNumber = SetOrResetBit(number, operation, k);
                Console.WriteLine($"Результат: {resultNumber.PadLeft(32, '0')}");
            
                break;

            case "3":
                int i = 0;
                int j = 0;
                Console.Write("Введите номер бита i: ");
                i = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите номер бита j: ");
                j = Convert.ToInt32(Console.ReadLine());
                int resultNumberSwapBits = swapBits(i, j, number);
                string binaryResult = Convert.ToString(resultNumberSwapBits, 2); // Преобразуем результат в двоичное число
                Console.WriteLine($"Результат: {binaryResult.PadLeft(32, '0')}");
                break;
            
            case "4":
                Console.Write("Введите количество младших бит, которые нужно обнулить (m): ");
                int m = Convert.ToInt32(Console.ReadLine());
                int resultResetMLowerBits = ResetLowerBits(m, number);
                string resultStringResetMLowerBits = Convert.ToString(resultResetMLowerBits, 2); // Преобразуем результат в двоичное число
                Console.WriteLine($"Результат: {resultStringResetMLowerBits.PadLeft(32, '0')}");
                break;
        }
    }
}