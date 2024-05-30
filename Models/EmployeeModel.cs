namespace FirstPartialExam.Models;

public class EmployeeModel : EntityBaseModel
{

    public string Role { get; set; }

    public decimal Salary { get; set; }

    public int Seniority { get; set; }
    
}