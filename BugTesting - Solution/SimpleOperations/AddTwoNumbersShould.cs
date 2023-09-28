namespace Tests.SimpleOperations
{
    public class AddTwoNumbersShould
    {
        [Fact]
        public void Return5For2And3()
        {
            // Arrange:
            TestingAPI.Operations.SimpleOperations simple = new();
            // Act: 
            var result = simple.AddTwoNumbers(2,3);
            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Return4000For1And3999()
        {
            // Arrange:
            TestingAPI.Operations.SimpleOperations simple = new();
            // Act: 
            var result = simple.AddTwoNumbers(1, 3999);
            // Assert
            Assert.Equal(4000, result);
        }
    }
}
