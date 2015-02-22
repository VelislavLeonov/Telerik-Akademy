using System;
/*
namespace _08.Binary_short
{
    class Program
    {
        static void Main()
        {
            try
            {
                ushort number = ushort.Parse(Console.ReadLine());
                Console.WriteLine(inBinary(number));
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static string inBinary(ushort s)
        {
            string bin = String.Empty;
            for (int i = 0; i < 16; i++)
            {
            bin = (s >> i & 1) + bin;
            }
        return bin;
        }
    }
}
