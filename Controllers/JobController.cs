using Microsoft.AspNetCore.Mvc;
namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class JobController : ControllerBase
{
    private readonly IJobService _IJobService;

    public JobController(IJobService jobService)
    {
        _IJobService = jobService;

    }
    [HttpGet]
    public async Task<List<Job>> GetAllJobs()
    {
        return await _IJobService.GetAllJobs();
    }
    [HttpPost("CreateJob")]
    public async Task<Job> CreateJob(Job job)
    {
        return await _IJobService.CreateJob(job);
    }
    [HttpGet("GetJobByName")]
    public async Task<Job> GetJobByName(string name)
    {
        return await _IJobService.GetJobByName(name);
    }
    [HttpGet("GetJobByJobType")]
    public async Task<Job> GetJobByJobType(string jobType)
    {
        return await _IJobService.GetJobByJobType(jobType); 
    }
    [HttpGet("GetJobBySalary")]
    public async Task<Job> GetJobBySalary(int salary)
    {
        return await _IJobService.GetJobBySalary(salary);
    }
    [HttpPut("UpdateJob")]
    public async Task<Job> UpdateJob([FromQuery] int id,Job job)
    {
        return await _IJobService.UpdateJob(id,job);
    }
    [HttpDelete("DeleteJob")]
    public async Task DeleteJob(Job job)
    {
        await _IJobService.DeleteJob(job);
    }
}