using DefaultNamespace;
using fridge_backend.Dtos.Receipt;
using fridge_backend.Interfaces;
using fridge_backend.Mappers;
using Microsoft.EntityFrameworkCore;

namespace fridge_backend.Repository;

public class ReceiptRepository : IReceiptRepository
{
    private readonly ApplicationDBContext _context;
    public ReceiptRepository(ApplicationDBContext context)
    {
        _context = context;
        
    }
    public Task<List<Receipt>> GetAllAsync()
    {
        return _context.Receipts.ToListAsync();
    }

    public async Task<Receipt?> GetByIdAsync(int id)
    {
        return await _context.Receipts.FindAsync(id);
    }

    public async Task<Receipt> CreateAsync(Receipt receiptModel)
    {
        await _context.Receipts.AddAsync(receiptModel);
        await _context.SaveChangesAsync();
        return receiptModel;
    }

    public async Task<Receipt> UpdateAsync(int id, UpdateReceiptRequestDto receiptDto)
    {
        var receiptModel = await _context.Receipts.FindAsync(id);
        if (receiptModel == null)
        {
            return null;
        }
        receiptModel.Name = receiptDto.Name;
        receiptModel.CategoryId = receiptDto.CategoryId;
        receiptModel.Ingredients = (receiptDto.Ingredients ?? new())
            .Select(i => new Ingredient { Id = i.Id, Name = i.Name, Quantity = i.Quantity })
            .ToList();
        await _context.SaveChangesAsync();
        return receiptModel;
    }

    public async Task<Receipt?> DeleteAsync(int id)
    {
        var receiptModel = await _context.Receipts.FindAsync(id);
        if (receiptModel == null)
        {
            return null;
        }
        _context.Receipts.Remove(receiptModel);
        await _context.SaveChangesAsync();
        return receiptModel;
    }
}