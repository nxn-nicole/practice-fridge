using DefaultNamespace;
using fridge_backend.Dtos.Ingredient;
using fridge_backend.Dtos.Receipt;

namespace fridge_backend.Mappers;

public static class ReceiptMappers
{
    public static ReceiptDto ToReceiptDto(this Receipt receiptModel)
    {
        return new ReceiptDto
        {
            Id = receiptModel.Id,
            Name = receiptModel.Name,
            CategoryId = receiptModel.CategoryId,                
            CreatedOn = receiptModel.CreatedOn,
            Ingredients = receiptModel.Ingredients?
                .Select(i => new IngredientDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Quantity = i.Quantity
                }).ToList() ?? new(),
        };
    }

    public static Receipt ToReceiptFromCreateDto(this CreateReceiptDto receiptDto)
    {
        return new Receipt
        {
            Name = receiptDto.Name,
            CategoryId = receiptDto.CategoryId,
            CreatedOn = receiptDto.CreatedOn,
            Ingredients = (receiptDto.Ingredients ?? new ()).Select(i=> new Ingredient
            {
                Name = i.Name,
                Quantity = i.Quantity,
            }).ToList()
        };
    }
}