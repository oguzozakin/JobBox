public class AddresService : IAddressService{
    private readonly IAddressRepository _addressRepository;

    public AddresService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }
  public async Task<Address> GetAddress(int id)
    {
        if (id != null)
        {
            return await _addressRepository.GetAddress(id);

        }
        return null;
    }
    public async Task<List<Address>> GetAllAddresses()
    {
        return await _addressRepository.GetAllAddress();
    }
    public async Task<List<District>> GetAllDistrictsByCityId(int id)
    {
        return await _addressRepository.GetAllDistrictsByCityId(id);
    }
    public async Task DeleteAddress(int id)
    {
        await _addressRepository.DeleteAddress(id);
    }
    public async Task<Address> UpdateAddress(int id)
    {
        return await _addressRepository.UpdateAddress(id);
    }
    public async Task<City> CreateCity(City city)
    {
        var ExistCity = await _addressRepository.GetCityByName(city.Name);
        if (ExistCity == null)
        {
            return await _addressRepository.CreateCity(city);
        }
        else
        {
            throw new Exception();
        }
    }
    public async Task<District> CreateDistrict(District district)
    {
        var ExistState = await _addressRepository.GetDistrictByName(district.Name);
        if (ExistState == null)
        {
            return await _addressRepository.CreateDistrict(district);
        }
        else
        {
            throw new Exception();
        }
    }
    public async Task DeleteCity(City city)
    {

        var ExistCity = await _addressRepository.GetCityByName(city.Name);
        if (ExistCity != null)
        {
            await _addressRepository.DeleteCity(city);
        }
        else
        {
            throw new Exception();
        }
    }
    public async Task DeleteDistrict(District district)
    {
        var ExistState = await _addressRepository.GetDistrictByName(district.Name);
        if (ExistState != null)
        {
            await _addressRepository.DeleteDistrict(district);
        }
        else
        {
            throw new Exception();
        }


    }


}