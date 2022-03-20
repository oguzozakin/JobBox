public interface IEmployeerRepository{
    Task<List<Employeer>> GetAllEmployeers();
    Task<Employeer> CreateEmployeer(Employeer employeer);
    Task<Employeer> GetEmployeerById(int Id);
    Task<Employeer> UpdateEmployeer(Employeer employeer);
    Task DeleteEmployeer(Employeer employeer);
}