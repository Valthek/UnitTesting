using Microsoft.AspNetCore.Mvc;

namespace TestingAPI.Operations
{
    public class DuplicateOperations
    {

        public int multiplyWithSelf(int number)
        {
            return number * number;
        }

        public int cubeNumber(int number)
        {
            return (int)Math.Pow(number, 2);
        }
    }
}
