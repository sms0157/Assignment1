namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1 (add), 2 (subtract), 3 (multiply)");
            Console.Write("Enter number option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                result = num1 + num2;
                Console.WriteLine("Sum of numbers: " + result.ToString());
            }
            else if (option == 2)
            {
                result = num1 - num2;
                Console.WriteLine("Difference of numbers: " + result.ToString());
            }
            else if (option == 3)
            {
                result = num1 * num2;
                Console.WriteLine("Product of numbers: " + result.ToString());
            }
            else
                Console.Write("Invalid choice.");
            Console.ReadLine();
        }
    }
}
