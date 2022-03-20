public class WorkPlace{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public virtual ICollection<Employeer> Employeer { get; set; }
}