using DefaultNamespace;
using fridge_backend.Dtos.Receipt;

namespace fridge_backend.Interfaces;

public interface IReceiptRepository
{
    Task<List<Receipt>> GetAllAsync();
    Task<Receipt?> GetByIdAsync(int id);
    Task<Receipt> CreateAsync(Receipt receipt);
    Task<Receipt> UpdateAsync(int id, UpdateReceiptRequestDto  receiptDto);
    Task<Receipt?> DeleteAsync(int id);
    
}