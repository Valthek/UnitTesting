namespace TestingAPI.Operations
{
    // Some very simple operations to test
    public class SimpleOperations
    {
        // Add two numbers together
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        // figures out the sum of two positive numbers
        public int AddTwoPositiveNumbers(int numberOne, int numberTwo)
        {
            if (numberOne < 0)
                throw new ArgumentException("numberOne is negative");
            if (numberTwo < 0)
                throw new ArgumentException("numberTwo is negative");

            return numberOne + numberTwo;
        }

        // figures out if a number is even
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Figures out if two numbers are sufficiently close to eachother, determined by closeness
        public bool AreCloseToEachother(int firstNumber, int secondNumber, int closeness)
        {
            var difference = firstNumber - secondNumber;
            if (Math.Abs(difference) <= closeness)
                return true;
            return false;
        }
    }
}
