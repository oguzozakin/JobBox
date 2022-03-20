using Microsoft.EntityFrameworkCore;

public class JobRepository : IJobRepository{
    private readonly JobBoxContext _context;

    public JobRepository(JobBoxContext context)
    {
        _context = context;
    }
    public async Task<List<Job>> GetAllJobs()
    {
       return await _context.Jobs.ToListAsync();

    }
    public async Task<Job> CreateJob(Job job){
        await _context.AddAsync(job);       
        await  _context.SaveChangesAsync();
        return job;
    }
    public async Task<Job> GetJobByName(string Name){
        return await _context.Jobs.FirstOrDefaultAsync(p => p.Name == Name);
    }
    public async Task<Job> GetJobByJobType(string JobType){
        return await _context.Jobs.FirstOrDefaultAsync(p => p.JobType == JobType);
    }
    public async Task<Job> GetJobBySalary(int Salary){
        return await _context.Jobs.FirstOrDefaultAsync(p => p.Salary == Salary);
    }
    public async Task<Job> UpdateJob(Job job){
        _context.Update(job);
        await _context.SaveChangesAsync();
        return job;
    }
    public async Task DeleteJob(Job job){
        _context.Jobs.Remove(job);
        _context.SaveChangesAsync();
       
    }
}