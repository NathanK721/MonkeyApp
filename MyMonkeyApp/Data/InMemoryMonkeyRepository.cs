using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMonkeyApp.Data
{
    public class InMemoryMonkeyRepository : IMonkeyRepository
    {
        private static readonly Random _random = new Random();

        private readonly List<Monkey> _monkeys = new List<Monkey>
        {
            new Monkey { Name = "Baboon" },
            new Monkey { Name = "Capuchin" },
            new Monkey { Name = "Mandrill" },
            new Monkey { Name = "Macaque" },
            new Monkey { Name = "Howler Monkey" },
            new Monkey { Name = "Squirrel Monkey" },
            new Monkey { Name = "Spider Monkey" },
            new Monkey { Name = "Tamarin" }
        };

        public Task<IEnumerable<Monkey>> GetAllAsync()
        {
            return Task.FromResult(_monkeys.AsEnumerable());
        }

        public Task<Monkey?> GetByNameAsync(string name)
        {
            var returnedName = _monkeys.FirstOrDefault(m => m.Name == name.ToLower());
            return Task.FromResult(returnedName);
        }

        public Task<Monkey?> GetRandomAsync()
        {
            var index = _random.Next(0, _monkeys.Count);
            return Task.FromResult(_monkeys.ElementAt(index));
        }
    }
}