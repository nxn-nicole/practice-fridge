namespace DefaultNamespace;

public class Receipt
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public List<Ingredient>? Ingredients { get; set; } = new List<Ingredient>();
}