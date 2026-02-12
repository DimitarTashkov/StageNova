using Microsoft.EntityFrameworkCore;
using StageNova.Data;
using StageNova.Models;
using StageNova.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageNova.Services
{
    public class TicketService : ITicketService
    {
        private readonly StageNovaDbContext _context;

        public TicketService(StageNovaDbContext context)
        {
            _context = context;
        }

        public List<Performance> GetPerformancesByPlayId(Guid playId)
        {
            return _context.Performances
                .Where(p => p.PlayId == playId && p.AvailableSeats > 0)
                .OrderBy(p => p.Date)
                .ToList();
        }

        public void BookTicket(Guid userId, Guid performanceId, int count)
        {
            var performance = _context.Performances
                .Include(p => p.Play)
                .FirstOrDefault(p => p.Id == performanceId);

            if (performance == null)
            {
                throw new Exception("Performance not found.");
            }

            if (performance.AvailableSeats < count)
            {
                throw new Exception("Not enough available seats.");
            }

            performance.AvailableSeats -= count;

            var ticket = new Ticket
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                PerformanceId = performanceId,
                TicketsCount = count,
                TotalPrice = performance.Play.TicketPrice * count
            };

            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        public List<Ticket> GetTicketsByUser(Guid userId)
        {
            return _context.Tickets
                .Include(t => t.Performance)
                .ThenInclude(p => p.Play)
                .Where(t => t.UserId == userId)
                .OrderByDescending(t => t.Performance.Date)
                .ToList();
        }

        public List<Ticket> GetAllTickets()
        {
            return _context.Tickets
                .Include(t => t.User)
                .Include(t => t.Performance)
                .ThenInclude(p => p.Play)
                .OrderByDescending(t => t.Performance.Date)
                .ToList();
        }

        public void DeleteTicket(Guid id)
        {
            var ticket = _context.Tickets.Find(id);
            if (ticket != null)
            {
                // Restore available seats
                var performance = _context.Performances.Find(ticket.PerformanceId);
                if (performance != null)
                {
                    performance.AvailableSeats += ticket.TicketsCount;
                }

                _context.Tickets.Remove(ticket);
                _context.SaveChanges();
            }
        }
    }
}
