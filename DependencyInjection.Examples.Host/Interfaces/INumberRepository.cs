using System.Collections.Generic;

namespace DependencyInjection.Examples.Host.Interfaces
{
    public interface INumberRepository
    {
        IEnumerable<int> GetAll();
    }
}
