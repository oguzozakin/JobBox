public interface IPositionService{
    Task<List<Position>> GetAllPositions();
    Task<Position> GetPositionById(int Id);
    Task<Position> GetPositionByName(string Name);
    Task<Position> CreatePosition(Position position);
    Task<Position> UpdatePosition(Position position,int id);
    Task DeletePosition(Position position);
}