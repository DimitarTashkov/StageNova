using StageNova.Models;
using System;
using System.Linq;
using System.Text;

namespace StageNova.Utilities
{
    public static class InvoiceHelper
    {
        public static string GenerateOrderInvoice(Order order)
        {
            var sb = new StringBuilder();
            sb.AppendLine("========== STAGENOVA INVOICE ==========");
            sb.AppendLine($"Invoice #: {order.Id.ToString().Substring(0, 8).ToUpper()}");
            sb.AppendLine($"Date:      {order.OrderDate:dd.MM.yyyy HH:mm}");
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("BUYER DETAILS:");
            sb.AppendLine($"Name:    {order.User?.Username ?? "N/A"}");
            sb.AppendLine($"Phone:   {order.PhoneNumber}");
            sb.AppendLine($"Address: {order.DeliveryAddress}");
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("ITEMS:");

            foreach (var item in order.OrderItems)
            {
                string name = item.Souvenir?.Name ?? "Unknown Item";
                sb.AppendLine($"- {name,-20} x{item.Quantity}  {item.UnitPrice * item.Quantity:F2} BGN");
            }

            sb.AppendLine("----------------------------------------");
            sb.AppendLine($"TOTAL AMOUNT:          {order.TotalAmount:F2} BGN");
            sb.AppendLine("========================================");
            sb.AppendLine("Thank you for choosing StageNova!");

            return sb.ToString();
        }

        public static string GenerateTicketReceipt(Ticket ticket)
        {
            var sb = new StringBuilder();
            sb.AppendLine("========== THEATER TICKET ==========");
            sb.AppendLine($"Ticket #: {ticket.Id.ToString().Substring(0, 8).ToUpper()}");
            sb.AppendLine($"Date:     {ticket.Performance?.Date:dd.MM.yyyy HH:mm}");
            sb.AppendLine("-----------------------------------------");
            sb.AppendLine($"Play:    {ticket.Performance?.Play?.Title ?? "N/A"}");
            sb.AppendLine($"Viewer:  {ticket.User?.Username}");
            sb.AppendLine($"Seats:   {ticket.TicketsCount}");
            sb.AppendLine($"Total:   {ticket.TotalPrice:F2} BGN");
            sb.AppendLine("-----------------------------------------");
            sb.AppendLine("Status:  CONFIRMED");
            sb.AppendLine("=========================================");

            return sb.ToString();
        }
    }
}
