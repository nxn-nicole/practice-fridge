using DefaultNamespace;
using fridge_backend.Dtos.Ingredient;

namespace fridge_backend.Dtos.Receipt;

public class CreateReceiptDto
{    
    public string Name { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public List<CreateIngredientDto> Ingredients { get; set; } = new List<CreateIngredientDto>();
}