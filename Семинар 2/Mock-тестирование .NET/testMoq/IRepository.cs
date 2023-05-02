public interface IRepository : IDisposable
{
    List<Computer> GetComputerList();
    Computer GetComputer(int id);
    void Create(Computer item);
    void Update(Computer item);
    void Delete(int id);
    void Save();
}
