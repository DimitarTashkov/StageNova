using StageNova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageNova.Services.Interfaces
{
    public interface ITicketService
    {
        List<Performance> GetPerformancesByPlayId(Guid playId);
        void BookTicket(Guid userId, Guid performanceId, int count);
        List<Ticket> GetTicketsByUser(Guid userId);
        List<Ticket> GetAllTickets();
        void DeleteTicket(Guid id);
    }
}
