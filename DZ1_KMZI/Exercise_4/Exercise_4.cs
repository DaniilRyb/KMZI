/*
Задание 4 - DES
Найти максимальную степень 2, на которую делится данное целое число. Примечание.
Операторами цикла пользоваться нельзя. Например, 
для числа 48 результатом будет 16, для числа 36 результатом будет 4.
*/

public static class DZ1_Exercise_4
{
    private static int CalculatePowerOfMaxPowTwo(int number)
    {
        return number & ~(number - 1);
    }
    
    public static void Exercise4()
    {
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Результат = {CalculatePowerOfMaxPowTwo(number)}");
        
    }
}