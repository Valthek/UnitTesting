using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.SimpleOperations
{
    public class IsEvenShould
    {
        public static IEnumerable<object[]> IsEvenData()
        {
            yield return new object[] { 1, false };
            yield return new object[] { 2, true };
            yield return new object[] { 3, false };
            yield return new object[] { 4, true };
        }

        [Theory]
        [MemberData(nameof(IsEvenData))]
        public void ReturnEvenOrOddUsingMemberData(int number, bool isEven)
        {
          
                // Arrange:
                TestingAPI.Operations.SimpleOperations simple = new();
                // Act: 
                var result = simple.IsEven(number);
                // Assert
                Assert.Equal(isEven, result);
     
        }
    }
}
