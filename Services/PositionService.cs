public class PositionService : IPositionService
{
    private IPositionRepository _positionRepository;

    public PositionService(IPositionRepository positionRepository)
    {
        _positionRepository = positionRepository;
    }
    public async  Task<List<Position>> GetAllPositions()
    {
        return await _positionRepository.GetAllPositions();
    }
    public async Task<Position> GetPositionById(int id)
    {
        return await _positionRepository.GetPositionById(id);
    }
    public async Task<Position> GetPositionByName(string name)
    {
        return await _positionRepository.GetPositionByName(name);
    }
    public async Task<Position> CreatePosition(Position position)
    {
        var result = await _positionRepository.GetPositionById(position.Id);
        if(result == null)
        {
            await _positionRepository.CreatePosition(position);
            return position;
        }
        throw new Exception("Aynı isimde pozisyon bulunmaktadır.");       
    }
     public async Task<Position> UpdatePosition(Position position, int id)
    {
        var updatedPosition = await _positionRepository.GetPositionById(position.Id);
        if(updatedPosition != null)
        {
            updatedPosition = position;
            await _positionRepository.UpdatePosition(updatedPosition);
            return position;
        }
        throw new Exception("Güncellenecek pozisyon bulunamadı.");
    }
    public async Task DeletePosition(Position position)
    {
        var deletedPosition = await _positionRepository.GetPositionById(position.Id);
        if(deletedPosition != null)
        {
            await _positionRepository.DeletePosition(position);
        }
        else
        {
            throw new Exception("Silinecek pozisyon bulunamadı.");
        }
        
    }


}