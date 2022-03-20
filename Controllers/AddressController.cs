using Microsoft.AspNetCore.Mvc;
namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressController : ControllerBase
{
    private readonly IAddressService _IAddressService;

    public AddressController(IAddressService addressService)
    {
        _IAddressService = addressService;

    }

    [HttpGet]
    public async Task<List<Address>> GetAllAddresses()
    {
        return await _IAddressService.GetAllAddresses();
    }

    [HttpGet("GetAddressById")]
    public async Task<Address> GetAddress([FromQuery] int id)
    {
        return await _IAddressService.GetAddress(id);
    }
     
     [HttpGet("GetAllDistrictsByCityId")]
    public async Task<List<District>> GetAllDistrictsByCityId([FromQuery] int id)
    {
        return await _IAddressService.GetAllDistrictsByCityId(id);
    }
   
    [HttpDelete("DeleteAddress")]
    public async Task DeleteAddress([FromQuery] int id)
    {
         await _IAddressService.DeleteAddress(id);
    }
    
    [HttpPut("UpdateAddress")]
    public async Task<Address> UpdateAddress([FromQuery] int id)
    {
        return await _IAddressService.UpdateAddress(id);
    }

    [HttpPost("CreateCity")]
    public async Task<City> CreateCity(City city)
    {
        return await _IAddressService.CreateCity(city);
    }

    [HttpPost("CreateDistrict")]
    public async Task<District> CreateDistrict(District district)
    {
        return await _IAddressService.CreateDistrict(district);
    }

    [HttpDelete("DeleteCity")]
    public async Task DeleteCity(City city)
    {
        await _IAddressService.DeleteCity(city);
    }
    
    [HttpDelete("DeleteDistrict")]
    public async Task DeleteDistrict(District district)
    {
         await _IAddressService.DeleteDistrict(district);
    }
}