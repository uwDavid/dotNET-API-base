namespace NetApiBase.Models;

public class Expense : BaseEntity
{
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public Company Company { get; set; }
    public Employee Employee { get; set; }
}