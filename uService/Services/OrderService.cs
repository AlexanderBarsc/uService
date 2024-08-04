using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using uService.Contracts;
using uService.Database;
using uService.Models;

namespace uService.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _dbContext;

        public OrderService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task UlozObjednavku(Objednavka objednavka)
        {

            await _dbContext.Objednavky.AddAsync(objednavka);

            await _dbContext.SaveChangesAsync();
     
        }
    }
}
