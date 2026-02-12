using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageNova.Models
{
    public class Performance
    {
        public Performance()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Play))]
        public Guid PlayId { get; set; }
        public virtual Play Play { get; set; }

        public DateTime Date { get; set; }

        public int TotalSeats { get; set; }

        public int AvailableSeats { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
