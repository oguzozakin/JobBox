using Microsoft.EntityFrameworkCore;

public class PositionRepository : IPositionRepository{
    private readonly JobBoxContext _context;

    public PositionRepository(JobBoxContext context)
    {
        _context = context;
    }
    public async Task<List<Position>> GetAllPositions()
    {
        return await _context.Positions.ToListAsync();
    }
    public async Task<Position> GetPositionById(int id)
    {
        var getPosition = await _context.Positions.SingleOrDefaultAsync(p => p.Id == id);

        if (getPosition != null)
        {
            return getPosition;
        }
        else
        {
            return null;
        }
    }
    public async Task<Position> GetPositionByName(string Name)
    {
        return await _context.Positions.FirstOrDefaultAsync(p => p.Name == Name);
    }
    public async Task<Position> CreatePosition(Position position)
    {
        await _context.AddAsync(position);
        await _context.SaveChangesAsync();
        return position;
    }
    public async Task<Position> UpdatePosition(Position position)
    {
        _context.Update(position);
         await _context.SaveChangesAsync();
        return position;
    }
    public async Task DeletePosition(Position position)
    {
        _context.Remove(position);
        _context.SaveChangesAsync();
    }

}