namespace Tests.SimpleOperations
{
    public class AreCloseToEachotherShould
    {
        public class AreCloseToEachother : TheoryData<int, int, int, bool>
        {
            Random rand = new Random();

            public AreCloseToEachother()
            {
                // numbers are within 5
                foreach (int i in Enumerable.Range(1, 10))
                {
                    Add(i, i + rand.Next(1, 5), 5, true);
                }
                // numbers are within 10
                for (int i = 0; i < 1000; i += 100)
                {

                    Add(i, i - rand.Next(1, 10), 10, true);
                }
            }
        }

        [Theory]
        [ClassData(typeof(AreCloseToEachother))]
        public void ReturnTrueForTruthyGeneratedData(int firstNumber, int secondNumber, int closeness, bool areClose)
        {
            // Arrange:
            TestingAPI.Operations.SimpleOperations simple = new();
            // Act: 
            var result = simple.AreCloseToEachother(firstNumber, secondNumber, closeness);
            // Assert
            Assert.Equal(areClose, result);
        }
    }
}
