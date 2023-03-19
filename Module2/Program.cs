using System;

namespace Module2
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please input array`s size");
            String inputSize = Console.ReadLine();
            inputSize = inputSize == "" ? "0" : inputSize ?? "0";
            
            int arraySize = Int32.Parse(inputSize);

            int maxValue = 0;
            int subMaxValue = 0;

            int num = 0;

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("Please input next element of array");
                String inputNum = Console.ReadLine();
                inputNum = inputNum == "" ? "0" : inputNum ?? "0";
                
                num = Int32.Parse(inputNum);

                if (num > maxValue)
                {
                    subMaxValue = maxValue;
                    maxValue = num;
                }
                else if (num < maxValue)
                {
                    subMaxValue = num > subMaxValue ? num : subMaxValue;
                }
            }
            
            Console.WriteLine(subMaxValue);
        }
    }
}