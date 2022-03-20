using Microsoft.AspNetCore.Mvc;
namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class PositionController : ControllerBase
{
    private readonly IPositionService _IPositionService;

    public PositionController(IPositionService positionService)
    {
        _IPositionService = positionService;

    }
    [HttpGet]
    public async Task<List<Position>> GetAllPositions()
    {
        return await _IPositionService.GetAllPositions();
    }
    [HttpGet("GetPositionById")]
    public async Task<Position> GetPositionById([FromQuery] int id)
    {
        return await _IPositionService.GetPositionById(id);
    }
    [HttpGet("GetPositionByName")]
    public async Task<Position> GetPositionByName([FromQuery]string name)
    {
        return await _IPositionService.GetPositionByName(name);
    }
    [HttpPost("CreatePosition")]
    public async Task<Position> CreatePosition(Position position)
    {
        return await _IPositionService.CreatePosition(position);
    }
    [HttpPut("UpdatePosition")]
    public async Task<Position> UpdatePosition(Position position, int id)
    {
        return await _IPositionService.UpdatePosition(position,id);
    }
    [HttpDelete("DeletePosition")]
    public async Task DeletePosition(Position position)
    {
        await _IPositionService.DeletePosition(position);
    }
}
