using DefaultNamespace;
using fridge_backend.Dtos.Ingredient;

namespace fridge_backend.Dtos.Receipt;

public class ReceiptDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public List<IngredientDto>? Ingredients { get; set; } = new List<IngredientDto>();
}