public interface IAddressRepository{
    Task<List<Address>> GetAllAddress();
    Task<Address> GetAddress(int id);
    Task<Address> GetAddressById(int id);
    Task<District> GetDistrictByName(string name);
    Task<City> GetCityByName(string CityName);
    Task<List<District>> GetAllDistrictsByCityId(int id);
    Task<Address> UpdateAddress(int id);
    Task<City> CreateCity(City city);
    Task<District> CreateDistrict(District district);
    Task DeleteAddress(int id);
    Task DeleteCity(City city);
    Task DeleteDistrict(District district);

}