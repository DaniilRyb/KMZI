
public static class DZ1_Exercise_5
{
    private static uint CycleShiftLeft(uint number, int shift)
    {
        uint shiftedBits = number >> (32 - shift);
        return (number << shift) | shiftedBits;
    }

    private static uint CycleShiftRight(uint number, int shift)
    {
        uint shiftedBits = number << (32 - shift);
        return (number >> shift) | shiftedBits;
    }
    public static void Exercise5()
    
    {
        
        uint number = 0b101010101110111010; 
        int n = 3; 
        
        uint y = CycleShiftLeft(number, n);
        uint z = CycleShiftRight(number, n);

        Console.WriteLine($"Входное значение: {Convert.ToString(number,2)}" );
        Console.WriteLine($"количество бит для сдвига: {n}");
        Console.WriteLine($"Результат сдвига (влево): {Convert.ToString(y,2)}");
        Console.WriteLine($"Результат сдвига (вправо): {Convert.ToString(z,2)}");
    }
}