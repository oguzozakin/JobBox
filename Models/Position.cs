public class Position {
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Employeer> Employeer { get; set; }
}