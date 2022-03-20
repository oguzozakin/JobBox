public interface IJobSeekerService{
    Task<List<JobSeeker>> GetAllJobSeekers();
    Task<JobSeeker> CreateJobSeeker(JobSeeker jobSeeker);
    Task<JobSeeker> GetJobSeekerById(int id);
    Task<JobSeeker> GetJobseekerByLevelOfEducation(string levelOfEducation);
    Task<JobSeeker> UpdateJobSeeker(JobSeeker jobSeeker, int id);
    Task DeleteJobSeeker(JobSeeker jobSeeker);
}
