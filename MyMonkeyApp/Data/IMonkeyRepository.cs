namespace MyMonkeyApp.Data;

public interface IMonkeyRepository
{
    Task<IEnumerable<Monkey>> GetAllAsync();
    Task<Monkey?> GetByNameAsync(string name);
    Task<Monkey?> GetRandomAsync();
}