public interface IJobSeekerRepository{
    Task<List<JobSeeker>> GetAllJobSeekers();
    Task<JobSeeker> CreateJobSeeker(JobSeeker jobSeeker);
    Task<JobSeeker> GetJobseekerById(int Id);
    Task<JobSeeker> GetJobseekerByLevelOfEducation(string LevelOfEducation);
    Task<JobSeeker> UpdateJobSeeker(JobSeeker jobSeeker);
    Task DeleteJobSeeker(JobSeeker jobSeeker);
}