namespace NetApiBase.Models;

public class BaseEntity
{
    // We don't have to define this field for all classes
    public Guid ID { get; set; } = Guid.NewGuid();

    public DateTime UpdateDate { get; set; }
}