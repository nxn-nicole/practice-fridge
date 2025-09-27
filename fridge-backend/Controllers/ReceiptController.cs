using DefaultNamespace;
using fridge_backend.Dtos.Receipt;
using fridge_backend.Interfaces;
using fridge_backend.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/receipt")]
    [ApiController]
    public class ReceiptController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IReceiptRepository _receiptRepo;
        public ReceiptController(ApplicationDBContext context, IReceiptRepository receiptRepo)
        {
            _receiptRepo = receiptRepo;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var receipt = await _receiptRepo.GetAllAsync();
            var receiptDto = receipt.Select(s=> s.ToReceiptDto());
            return Ok(receipt);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var receipt = await _receiptRepo.GetByIdAsync(id);
            if (receipt == null)
            {
                return NotFound();
            }
            return Ok(receipt.ToReceiptDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateReceiptDto receiptDto)
        {
            var receiptModel = receiptDto.ToReceiptFromCreateDto();
            return Ok(receiptModel.ToReceiptDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateReceiptRequestDto updateDto)
        {
            var receiptModel = await _receiptRepo.UpdateAsync(id, updateDto);
            return Ok(receiptModel.ToReceiptDto());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
           await _receiptRepo.DeleteAsync(id);
            return NoContent();
        }
        
            
    }
}