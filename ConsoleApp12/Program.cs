namespace ConsoleApp12
{
    internal class Program
    {
        public static long SquareDigits(long n)
        {
            string numberString = n.ToString();
            string result = "";

            foreach (char digit in numberString)
            {
                int digitValue = digit - '0';
                int square = digitValue * digitValue;

                result += square.ToString();
            }
            return long.Parse(result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string input = Console.ReadLine();

            if (long.TryParse(input, out long number))
            {
                long result = SquareDigits(number);
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка. Введено не коректное число");
            }
        }
    }
}
