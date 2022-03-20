public interface IAddressService{
    Task<List<Address>> GetAllAddresses();
    Task<Address> GetAddress(int id);
    Task<List<District>> GetAllDistrictsByCityId(int id);
    Task DeleteAddress(int id);
    Task<Address> UpdateAddress(int id);
    Task<City> CreateCity(City city);
    Task<District> CreateDistrict(District district);
    Task DeleteCity(City city);
    Task DeleteDistrict(District district);

}