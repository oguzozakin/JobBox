public class EmployeerService : IEmployeerService
{
    private IEmployeerRepository _employeerRepository;

    public EmployeerService(IEmployeerRepository employeerRepository)
    {
        _employeerRepository = employeerRepository;
    }
    public async  Task<List<Employeer>> GetAllEmployeers()
    {
        return await _employeerRepository.GetAllEmployeers();
    }
    public async Task<Employeer> CreateEmployeer(Employeer employeer)
    {
        var result = await _employeerRepository.GetEmployeerById(employeer.Id);
        if(result == null)
        {
            await _employeerRepository.CreateEmployeer(employeer);
            return employeer;
        }
        throw new Exception("Aynı isimde iş veren bulunmaktadır.");       
    }
    public async Task<Employeer> GetEmployeerById(int id)
    {
        return await _employeerRepository.GetEmployeerById(id);
    }
    public async Task<Employeer> UpdateEmployeer(int id, Employeer employeer)
    {
        var updatedEmployeer = await _employeerRepository.GetEmployeerById(employeer.Id);
        if(updatedEmployeer != null)
        {
            updatedEmployeer = employeer;
            await _employeerRepository.UpdateEmployeer(updatedEmployeer);
            return employeer;
        }
        throw new Exception("Güncellenecek iş veren bulunamadı.");
    }
    public async Task DeleteEmployeer(Employeer employeer)
    {
        var deletedEmployeer = await _employeerRepository.GetEmployeerById(employeer.Id);
        if(deletedEmployeer != null)
        {
            await _employeerRepository.DeleteEmployeer(employeer);
        }
        else
        {
            throw new Exception("Silinecek iş veren bulunamadı.");
        }
        
    }
}