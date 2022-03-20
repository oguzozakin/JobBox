public interface IJobService{
    Task<List<Job>> GetAllJobs();
    Task<Job> CreateJob(Job job);
    Task<Job> GetJobByName(string Name);
    Task<Job> GetJobByJobType(string JobType);
    Task<Job> GetJobBySalary(int Salary);
    Task<Job> UpdateJob(int id,Job job);
    Task DeleteJob(Job job);
}