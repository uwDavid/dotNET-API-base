using System.ComponentModel.DataAnnotations;

namespace NetApiBase.Models;

public class Employee : BaseEntity
{
    public string Name { get; set; } // combined field of first + last name


    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }
    public ICollection<Expense> Expenses { get; set; }
}