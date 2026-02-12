using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageNova.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey(nameof(Performance))]
        public Guid PerformanceId { get; set; }
        public virtual Performance Performance { get; set; }

        public int TicketsCount { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
