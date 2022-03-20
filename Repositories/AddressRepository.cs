
using Microsoft.EntityFrameworkCore;

public class AddressRepository : IAddressRepository
{
    private readonly JobBoxContext _context;

    public AddressRepository(JobBoxContext context)
    {
        _context = context;
        
    }
    
    public async Task<Address> GetAddress(int id)
    {

        var getAddress = await _context.Set<Address>().SingleOrDefaultAsync(p => p.Id == id);

        if (getAddress != null)
        {

            return getAddress;

        }
        else
        {
            return null;
        }
    }


    public async Task<City> GetCityByName(string CityName)
    {
        return await _context.Cities.FirstOrDefaultAsync(c => c.Name == CityName);

    }


    public async Task<District> GetDistrictByName(string DistirctName)
    {
        return await _context.Districts.FirstOrDefaultAsync(c => c.Name == DistirctName);

    }


    public async Task<List<Address>> GetAllAddress()
    {

        return await _context.Addresses.ToListAsync();
    }
    public async Task<Address> GetAddressById(int id)
    {

        var getAddress = await _context.Addresses.SingleOrDefaultAsync(p => p.Id == id);

        if (getAddress != null)
        {

            return getAddress;

        }
        else
        {
            return null;
        }
    }

    public async Task<List<District>> GetAllDistrictsByCityId(int id)
    {
        var getDistricts = await _context.Districts.Where(p => p.CityId == id).ToListAsync();
        if (getDistricts != null)
        {

            return getDistricts;

        }
        else
        {
            return null;
        }
    }
    public async Task DeleteAddress(int id)
    {


        var DeletedAddress = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == id);
        _context.Addresses.Remove(DeletedAddress);
        _context.SaveChangesAsync();

    }


    public async Task<Address> UpdateAddress(int id)
    {
        throw new NotImplementedException();
    }

   
    public async Task<City> CreateCity(City city)
    {
        await _context.AddAsync(city);
        await _context.SaveChangesAsync();
        return city;
    }


    public async Task<District> CreateDistrict(District district)
    {
        await _context.AddAsync(district);
        await _context.SaveChangesAsync();
        return district;
    }

  

    public async Task DeleteCity(City city)
    {
        _context.Remove(city);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteDistrict(District district)
    {
        _context.Remove(district);
        await _context.SaveChangesAsync();
        
    }


}
