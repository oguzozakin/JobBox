using Microsoft.EntityFrameworkCore;

public class EmployeerRepository : IEmployeerRepository{
    private readonly JobBoxContext _context;
    public EmployeerRepository(JobBoxContext context)
    {
        _context=context;
    }

    public async Task<List<Employeer>> GetAllEmployeers()
    {
        return await _context.Employeers.ToListAsync();

    }
    public async Task<Employeer> CreateEmployeer(Employeer employeer)
    {
        await _context.AddAsync(employeer);       
        await  _context.SaveChangesAsync();
        return employeer;
    }
    public async Task<Employeer> GetEmployeerById(int id)
    {
        var getEmployeer = await _context.Employeers.SingleOrDefaultAsync(p => p.Id == id);

        if (getEmployeer != null)
        {
            return getEmployeer;
        }
        else
        {
            return null;
        }
    }
    public async Task<Employeer> UpdateEmployeer(Employeer employeer)
    {
        _context.Update(employeer);
         await _context.SaveChangesAsync();
        return employeer; 
    }
    public async Task DeleteEmployeer(Employeer employeer)
    {
        _context.Remove(employeer);
        _context.SaveChangesAsync();
        
    }
}