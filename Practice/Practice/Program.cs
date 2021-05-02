using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryToDecimal(101);
            DecimalToBinary(1);
        }

        private static void DecimalToBinary(int @decimal)
        {
            Console.WriteLine($"Expected value : {Convert.ToString(@decimal, 10)}");

            var binary = string.Empty;

            while (@decimal > 0)
            {
                var reminder = @decimal % 2;
                @decimal /= 2;
                binary = $"{reminder}{binary}";
            }

            Console.WriteLine($"Output value : {binary}");
        }

        private static void BinaryToDecimal(int binary)
        {
            Console.WriteLine($"Expected value : {Convert.ToInt32(binary.ToString(), 2)}");

            var @decimal = 0;
            var weight = 1;

            while (binary != 0)
            {
                var reminder = binary % 10;
                @decimal += reminder * weight;
                binary /= 10;
                weight *= 2;
            }

            Console.WriteLine($"Output value : {@decimal}");
        }
    }
}
