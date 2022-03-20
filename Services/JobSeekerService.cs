public class JobSeekerService : IJobSeekerService
{
    private IJobSeekerRepository _jobSeekerRepository;

    public JobSeekerService(IJobSeekerRepository jobSeekerRepository)
    {
        _jobSeekerRepository = jobSeekerRepository;
    }
    public async  Task<List<JobSeeker>> GetAllJobSeekers()
    {
        return await _jobSeekerRepository.GetAllJobSeekers();
    }
    public async Task<JobSeeker> CreateJobSeeker(JobSeeker jobSeeker)
    {
        var result = await _jobSeekerRepository.GetJobseekerById(jobSeeker.Id);
        if(result == null)
        {
            await _jobSeekerRepository.CreateJobSeeker(jobSeeker);
            return jobSeeker;
        }
        throw new Exception("Aynı isimde iş arayan bulunmaktadır.");       
    }
    public async Task<JobSeeker> GetJobSeekerById(int id)
    {
        return await _jobSeekerRepository.GetJobseekerById(id);
    }
    public async Task<JobSeeker> GetJobseekerByLevelOfEducation(string levelOfEducation)
    {
        return await _jobSeekerRepository.GetJobseekerByLevelOfEducation(levelOfEducation);
    }
    public async Task<JobSeeker> UpdateJobSeeker(JobSeeker jobSeeker, int id)
    {
        var updatedJobSeeker = await _jobSeekerRepository.GetJobseekerById(jobSeeker.Id);
        if(updatedJobSeeker != null)
        {
            updatedJobSeeker = jobSeeker;
            await _jobSeekerRepository.UpdateJobSeeker(updatedJobSeeker);
            return jobSeeker;
        }
        throw new Exception("Güncellenecek iş arayan bulunamadı.");
    }
    public async Task DeleteJobSeeker(JobSeeker jobSeeker)
    {
        var deletedJobSeeker = await _jobSeekerRepository.GetJobseekerById(jobSeeker.Id);
        if(deletedJobSeeker != null)
        {
            await _jobSeekerRepository.DeleteJobSeeker(jobSeeker);
        }
        else
        {
            throw new Exception("Silinecek iş arayan bulunamadı.");
        }
        
    }


}