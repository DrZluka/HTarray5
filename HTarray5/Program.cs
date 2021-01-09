using System;

namespace HTarray5
{
    class Program
    {
        static void MaxValue(ref int[] array)
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            Console.WriteLine(maxValue);
            // ну, или просто: int maxValue = array.max();
            //Console.WriteLine(maxValue);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 8, 20, 1, 0, 55, 77, 22, 20, 21, 12 };

            MaxValue(ref myArray);
        }
    }
}
