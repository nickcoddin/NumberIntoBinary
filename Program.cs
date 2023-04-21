namespace NumberIntoBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("to get binary number, please Enter only Number: ");
            string? stringNumber = Console.ReadLine();
            NumberTransformation.InputNumber(stringNumber);
            Console.ReadKey();
        }
    }
}