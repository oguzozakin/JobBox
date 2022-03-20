using Microsoft.AspNetCore.Mvc;
namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployerController : ControllerBase
{
    private readonly IEmployeerService _IEmployeerService;

    public EmployerController(IEmployeerService employeerService)
    {
        _IEmployeerService = employeerService;

    }
    [HttpGet]
    public async Task<List<Employeer>> GetAllEmployeers()
    {
        return await _IEmployeerService.GetAllEmployeers();
    }
    
    [HttpPost("CreateEmployeer")]
    public async Task<Employeer> CreateEmployeer(Employeer employeer)
    {
        return await _IEmployeerService.CreateEmployeer(employeer);
    }
    [HttpGet("GetEmployeertById")]
    public async Task<Employeer> GetEmployeertById([FromQuery] int id)
    {
        return await _IEmployeerService.GetEmployeerById(id);
    }
    [HttpPut("UpdateEmployeer")]
    public async Task<Employeer> UpdateEmployeer([FromQuery] int id,Employeer employeer)
    {
        return await _IEmployeerService.UpdateEmployeer(id,employeer);
    }
    [HttpDelete("DeleteEmployeer")]
    public async Task DeleteEmployeer(Employeer employeer)
    {
        await _IEmployeerService.DeleteEmployeer(employeer);
    }

}
