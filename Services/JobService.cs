public class JobService : IJobService
{
    private IJobRepository _jobRepository;

    public JobService(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }
    public async  Task<List<Job>> GetAllJobs()
    {
        return await _jobRepository.GetAllJobs();
    }
    public async Task<Job> CreateJob(Job job)
    {
        var result = await _jobRepository.GetJobByName(job.Name);
        if(result == null)
        {
            await _jobRepository.CreateJob(job);
            return job;
        }
        throw new Exception("Aynı isimde iş bulunmaktadır.");       
    }
    public async Task<Job> GetJobByName(string jobName)
    {
        return await _jobRepository.GetJobByName(jobName);
    }
    public async Task<Job> GetJobByJobType(string jobType)
    {
        return await _jobRepository.GetJobByName(jobType);
    }
    public async Task<Job> GetJobBySalary(int salary)
    {
        return await _jobRepository.GetJobBySalary(salary);
    }
    public async Task<Job> UpdateJob(int id, Job job)
    {
        var updatedJob = await _jobRepository.GetJobByName(job.Name);
        if(updatedJob != null)
        {
            updatedJob = job;
            await _jobRepository.UpdateJob(updatedJob);
            return job;
        }
        throw new Exception("Güncellenecek iş bulunamadı.");
    }
    public async Task DeleteJob(Job job)
    {
        var deletedJob = await _jobRepository.GetJobByName(job.Name);
        if(deletedJob != null)
        {
            await _jobRepository.DeleteJob(job);
        }
        else
        {
            throw new Exception("Silinecek iş bulunamadı.");
        }
        
    }

}