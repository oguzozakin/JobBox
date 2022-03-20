public class Employeer{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public virtual ICollection<WorkPlace> WorkPlace { get; set; }
    public virtual ICollection<Position> Position { get; set; }

}