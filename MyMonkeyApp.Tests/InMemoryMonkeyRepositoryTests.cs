using Xunit;
using MyMonkeyApp.Data;

namespace MyMonkeyApp.Tests
{
    public class InMemoryMonkeyRepositoryTests
    {
        [Fact]
        public async Task GetAllAsync_ReturnsMonkeys()
        {
            var repo = new InMemoryMonkeyRepository();
            
            var monkeys = await repo.GetAllAsync();
            
            Assert.NotNull(monkeys);
            // TODO: more asserts later
        }
    }
}