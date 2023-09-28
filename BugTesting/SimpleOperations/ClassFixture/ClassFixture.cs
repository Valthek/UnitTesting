using TestingAPI.Controllers;
using Tests.SimpleOperations.ClassFixture;
using Xunit.Abstractions;

namespace Tests.SimpleOperations.ClassFixture
{
    [CollectionDefinition("SharedState")]
    public class SharedState: ICollectionFixture<SharedState>
    {
        public List<(int number, int square)> Data { get; set; }

        public SharedState() {
            Data = new List<(int, int)>
            {
                (2,4),(3,9), (4,16)
            };

        }

        public void Dispose() => 
            Data = default;
        
    }
}
