namespace Tests.DuplicateOperations
{
    [CollectionDefinition("SharedState")]
    public class SharedState : ICollectionFixture<SharedState>
    {
        public List<(int number, int square)> Data { get; set; }

        public SharedState()
        {
            Data = new List<(int, int)>
            {
                (2,4),(3,9), (4,16)
            };

        }
    }
}
