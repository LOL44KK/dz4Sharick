namespace dz4Sharick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Task1();

            Console.WriteLine("\n\n");
            Console.WriteLine("Task 2");
            Task2();
        }

        public static void Task1()
        {
            string[] arrRoman = new string[4000];

            for (int i = 1; i != 4000; i++)
            {
                arrRoman[i] = ToRoman(i);
            }

            for (int i = 1; i < arrRoman.Length; i++)
            {
                Console.WriteLine(arrRoman[i] + "\t| " + i);
            }
        }

        public static string ToRoman(int number) {
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] hund = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] thou = { "", "M", "MM", "MMM" };

            string roman = "";
            roman += thou[(number / 1000) % 10];
            roman += hund[(number / 100) % 10];
            roman += tens[(number / 10) % 10];
            roman += ones[number % 10];
            return roman;
        }

        public static void Task2()
        {
            const int N = 6;
            const int M = 6;
            int[,] matrix = new int[N, M];

            int num = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = num;
                    num++;
                }
            }

            //for (int i = 0; i < M * N; i++)
            //{
            //    matrix[i / N, i % N] = i;
            //}
            //или так

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
