public interface IEmployeerService{
    Task<List<Employeer>> GetAllEmployeers();
    Task<Employeer> CreateEmployeer(Employeer employeer);
    Task<Employeer> GetEmployeerById(int Id);
    Task<Employeer> UpdateEmployeer(int id,Employeer employeer);
    Task DeleteEmployeer(Employeer employeer);

}