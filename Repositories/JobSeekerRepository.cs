using Microsoft.EntityFrameworkCore;

public class JobSeekerRepository : IJobSeekerRepository{
    private readonly JobBoxContext _context;

    public JobSeekerRepository(JobBoxContext context)
    {
        _context = context;
        
    }
    public async Task<List<JobSeeker>> GetAllJobSeekers()
    {
        return await _context.JobSeekers.ToListAsync();
    }
    public async Task<JobSeeker> CreateJobSeeker(JobSeeker jobSeeker)
    {
        await _context.AddAsync(jobSeeker);       
        await  _context.SaveChangesAsync();
        return jobSeeker;
    }
    public async Task<JobSeeker> GetJobseekerById(int id)
    {
        return await _context.JobSeekers.FirstOrDefaultAsync(p => p.Id == id);
    }
    public async Task<JobSeeker> GetJobseekerByLevelOfEducation(string levelOfEducation)
    {
        return await _context.JobSeekers.FirstOrDefaultAsync(p => p.LevelOfEducation == levelOfEducation);
    }
    public async Task<JobSeeker> UpdateJobSeeker(JobSeeker jobSeeker)
    {
        _context.Update(jobSeeker);
         await _context.SaveChangesAsync();
        return jobSeeker; 
    }
    public async Task DeleteJobSeeker(JobSeeker jobSeeker)
    {
        _context.Remove(jobSeeker);
        _context.SaveChangesAsync();
        
    }

}