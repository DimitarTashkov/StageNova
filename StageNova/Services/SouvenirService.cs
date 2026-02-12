using Microsoft.EntityFrameworkCore;
using StageNova.Data;
using StageNova.Models;
using StageNova.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StageNova.Services
{
    public class SouvenirService : ISouvenirService
    {
        private readonly StageNovaDbContext _context;

        public SouvenirService(StageNovaDbContext context)
        {
            _context = context;
        }

        public List<Souvenir> GetAllSouvenirs()
        {
            return _context.Souvenirs.ToList();
        }

        public Souvenir GetSouvenirById(Guid id)
        {
            return _context.Souvenirs.Find(id);
        }

        public void PurchaseItem(Guid userId, Guid souvenirId, int quantity, string address, string phone)
        {
            var souvenir = _context.Souvenirs.Find(souvenirId);

            if (souvenir != null && souvenir.StockQuantity >= quantity)
            {
                souvenir.StockQuantity -= quantity;

                var order = new Order
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    OrderDate = DateTime.Now,
                    TotalAmount = souvenir.Price * quantity,
                    DeliveryAddress = address,
                    PhoneNumber = phone
                };

                var orderItem = new OrderItem
                {
                    Id = Guid.NewGuid(),
                    OrderId = order.Id,
                    SouvenirId = souvenirId,
                    Quantity = quantity,
                    UnitPrice = souvenir.Price
                };

                _context.Orders.Add(order);
                _context.OrderItems.Add(orderItem);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Not enough stock available.");
            }
        }

        public void AddSouvenir(Souvenir souvenir)
        {
            if (souvenir.Id == Guid.Empty) souvenir.Id = Guid.NewGuid();
            _context.Souvenirs.Add(souvenir);
            _context.SaveChanges();
        }

        public void UpdateSouvenir(Souvenir souvenir)
        {
            var existing = _context.Souvenirs.Find(souvenir.Id);
            if (existing != null)
            {
                existing.Name = souvenir.Name;
                existing.Price = souvenir.Price;
                existing.StockQuantity = souvenir.StockQuantity;
                existing.ImagePath = souvenir.ImagePath;
                _context.SaveChanges();
            }
        }

        public void DeleteSouvenir(Guid id)
        {
            var item = _context.Souvenirs.Find(id);
            if (item != null)
            {
                _context.Souvenirs.Remove(item);
                _context.SaveChanges();
            }
        }

        public List<Order> GetOrdersByUserId(Guid userId)
        {
            return _context.Orders
                           .Include(o => o.User)
                           .Include(o => o.OrderItems)
                           .ThenInclude(oi => oi.Souvenir)
                           .Where(o => o.UserId == userId)
                           .OrderByDescending(o => o.OrderDate)
                           .ToList();
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders
                           .Include(o => o.User)
                           .Include(o => o.OrderItems)
                           .ThenInclude(oi => oi.Souvenir)
                           .OrderByDescending(o => o.OrderDate)
                           .ToList();
        }

        public void DeleteOrder(Guid id)
        {
            var order = _context.Orders.Include(o => o.OrderItems).FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                _context.OrderItems.RemoveRange(order.OrderItems);
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
    }
}
