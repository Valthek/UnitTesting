using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAPI.Operations;
using Xunit.Abstractions;

namespace Tests.DuplicateOperations
{
    [Collection("SharedState")]
    public class MultiplyWithSelfShould
    {
        private readonly SharedState sharedState;
        private TestingAPI.Operations.DuplicateOperations operations;
        private readonly ITestOutputHelper outputHelper;

        public MultiplyWithSelfShould(SharedState sharedState, ITestOutputHelper outputHelper)
        {
            this.sharedState = sharedState;
            operations = new TestingAPI.Operations.DuplicateOperations();
            this.outputHelper = outputHelper;
        }

        [Fact]
        public void ReturnCubeForNumber()
        {
            foreach ((int number, int cube) in sharedState.Data)
            {
                outputHelper.WriteLine($"{number} times {number} should be {cube}");
                // Arrange already done
                // Act
                var result = operations.multiplyWithSelf(number);
                // assert
                Assert.Equal(cube, result);
            }
        }
    }
}