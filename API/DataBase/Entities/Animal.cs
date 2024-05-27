using DataBase.Entities;

public class Animal : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public int OwnerId { get; set; } // Adaugare proprietate OwnerId
    public Owner Owner { get; set; } // Adaugare proprietate Owner
}
