namespace FirstPartialExam.Models;

public class ProductModel : EmployeeModel
{
    public ProductModel()
    {
    }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public DateTime LastMovement   { get; set; }
    
}