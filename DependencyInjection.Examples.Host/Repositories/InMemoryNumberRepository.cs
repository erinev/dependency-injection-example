using DependencyInjection.Examples.Host.Interfaces;
using System.Collections.Generic;

namespace DependencyInjection.Examples.Host.Repositories
{
    public class InMemoryNumberRepository : INumberRepository
    {
        public IEnumerable<int> GetAll() => new[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
    }
}
