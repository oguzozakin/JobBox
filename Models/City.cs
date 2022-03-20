public class City{
    public int Id { get; set; }
    public string Name { get; set; } 
    public int? StateId { get; set; }

    public virtual ICollection<Address>? Addresses {get;set;}
    public virtual ICollection<District>? District { get; set; }
}