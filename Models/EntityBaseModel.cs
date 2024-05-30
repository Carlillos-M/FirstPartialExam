namespace FirstPartialExam.Models;

public class EntityBaseModel
{

    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime ModificationDate { get; set; }
    public DateTime CreationDate { get; set; }
}