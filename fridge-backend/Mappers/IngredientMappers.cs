using DefaultNamespace;
using fridge_backend.Dtos.Ingredient;

namespace fridge_backend.Mappers;

public static class IngredientMappers
{
    public static IngredientDto ToIngredientDto(this Ingredient ingredient)
    {
        return new IngredientDto
        {
            Id = ingredient.Id,
            Name = ingredient.Name,
            ReceiptId = ingredient.ReceiptId,
            Quantity = ingredient.Quantity,
        };
    }
}