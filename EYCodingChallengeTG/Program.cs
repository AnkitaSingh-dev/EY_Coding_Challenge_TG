using System;
using System.Text;

namespace EYCodingChallengeTG
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Convert.ToInt32(Console.ReadLine());
            string[] inputValues = new string[inputNumbers];

            for (var i = 0; i < inputNumbers; i++)
            {
                inputValues[i] = Console.ReadLine();
            }
            foreach (var item in inputValues)
            {

                byte[] asciiBytes = Encoding.ASCII.GetBytes(item);
                int oddTotal = 0, evenTotal = 0;
                for (int i = 0; i < asciiBytes.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenTotal += asciiBytes[i];
                    }
                    else
                    {
                        oddTotal += (int)asciiBytes[i];
                    }

                }

                var absoluteDiff = Math.Abs(evenTotal - oddTotal);

                Console.WriteLine(IsPrime(absoluteDiff) ? "Prime String" : "Casual String");
            }
        }

        static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return false;

            var limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; ++i)
                if (number % i == 0)
                    return false;
            return true;

        }
    }
}
