public interface IPositionRepository{
    Task<List<Position>> GetAllPositions();
    Task<Position> GetPositionById(int Id);
    Task<Position> GetPositionByName(string Name);
    Task<Position> CreatePosition(Position position);
    Task<Position> UpdatePosition(Position position);
    Task DeletePosition(Position position);



}