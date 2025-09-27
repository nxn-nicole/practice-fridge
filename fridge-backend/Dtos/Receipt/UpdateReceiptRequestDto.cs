using fridge_backend.Dtos.Ingredient;

namespace fridge_backend.Dtos.Receipt;

public class UpdateReceiptRequestDto
{
  
    public string Name { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public List<IngredientDto>? Ingredients { get; set; } = new List<IngredientDto>();

}