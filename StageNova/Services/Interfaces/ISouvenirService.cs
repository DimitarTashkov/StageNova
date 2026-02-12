using StageNova.Models;
using System;
using System.Collections.Generic;

namespace StageNova.Services.Interfaces
{
    public interface ISouvenirService 
    {
        List<Souvenir> GetAllSouvenirs();
        Souvenir GetSouvenirById(Guid id);
        void PurchaseItem(Guid userId, Guid souvenirId, int quantity, string address, string phone);
        void AddSouvenir(Souvenir souvenir);
        void UpdateSouvenir(Souvenir souvenir);
        void DeleteSouvenir(Guid id);
        List<Order> GetOrdersByUserId(Guid userId);
        List<Order> GetAllOrders();
        void DeleteOrder(Guid id);
    }
}
