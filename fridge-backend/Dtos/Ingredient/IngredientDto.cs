namespace fridge_backend.Dtos.Ingredient;

public class IngredientDto
{
    public int Id { get; set; }
    public int ReceiptId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Quantity { get; set; } = string.Empty;
}