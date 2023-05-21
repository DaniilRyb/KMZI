/*
Дано 𝑛 битовое данное. Задана перестановка бит (1,8,23,0,16,...).
Написать функцию, выполняющую эту перестановку. Пример числа 10101110 

*/


/*
 Пример использования программы:
 Введите двоичное число: 10101110
 Введите перестановку бит (через запятую): 5,3,7,1,4,0,6,2
 Результат перестановки бит: 11110001
 */

public static class Exercise_6
{
    private static int PerformBitPermutation(string binaryNumber, string[] positions)
    {
        int result = 0;
        int bitLength = binaryNumber.Length;

        for (int i = 0; i < positions.Length; i++)
        {
            int pos = Convert.ToInt32(positions[i].Trim());

            // Получаем значение бита в позиции pos из исходного числа
            int bitValue = GetBitValue(binaryNumber, bitLength - pos - 1);

            // Сохраняем значение бита в соответствующей позиции в результирующем числе
            result |= bitValue << i;
        }

        return result;
    }
    private static int GetBitValue(string binaryNumber, int position)
    {
        if (position < 0 || position >= binaryNumber.Length)
            return 0;

        return binaryNumber[position] - '0';
    }
    private static int ReverseBits(int number)
    {
        int reversedNumber = 0;

        while (number != 0)
        {
            reversedNumber <<= 1;
            reversedNumber |= number & 1;
            number >>= 1;
        }

        return reversedNumber;
    }
    
    public static void DZ1_Exercise_6()
    {
        
        Console.Write("Введите двоичное число: ");
        string binaryNumber = Console.ReadLine();

        Console.WriteLine("Введите перестановку бит (через запятую):");
        string[] positions = Console.ReadLine().Split(',');

        int result = PerformBitPermutation(binaryNumber, positions);
        int reversedResult = ReverseBits(result);
        Console.WriteLine("Результат перестановки бит: " + Convert.ToString(reversedResult, 2));

    }
    
    }
