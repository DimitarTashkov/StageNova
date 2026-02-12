using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageNova.Models
{
    public class Play
    {
        public Play()
        {
            this.Performances = new HashSet<Performance>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Director { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public byte[] PosterImage { get; set; }

        public int DurationMinutes { get; set; }

        public decimal TicketPrice { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<Performance> Performances { get; set; }
    }
}
