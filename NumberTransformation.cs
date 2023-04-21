namespace NumberIntoBinary
{
    public static class NumberTransformation
    {
        public static void InputNumber(string stringNumber)
        {
            int inputNumber;

            if(!int.TryParse(stringNumber, out inputNumber))
            {
                Console.WriteLine("incorrect input");
            }
            else
            {
                string binaryNumber = Convert.ToString(inputNumber, 2);
                Console.WriteLine("number {0} in binary system is: {1}", inputNumber, binaryNumber);
            }
        }
    }
}
