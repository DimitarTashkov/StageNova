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
    public class PlayService : IPlayService
    {
        private readonly StageNovaDbContext _context;

        public PlayService(StageNovaDbContext context)
        {
            _context = context;
        }

        public List<Play> GetAllPlays()
        {
            return _context.Plays.ToList();
        }

        public List<Play> GetPlaysByGenre(string genre)
        {
            return _context.Plays
                .Where(p => p.Genre == genre && p.IsActive)
                .ToList();
        }

        public void AddPlay(Play play)
        {
            if (play.Id == Guid.Empty)
            {
                play.Id = Guid.NewGuid();
            }
            _context.Plays.Add(play);
            _context.SaveChanges();
        }

        public void UpdatePlay(Play play)
        {
            var existing = _context.Plays.Find(play.Id);
            if (existing != null)
            {
                existing.Title = play.Title;
                existing.Genre = play.Genre;
                existing.Director = play.Director;
                existing.Description = play.Description;
                existing.PosterImage = play.PosterImage;
                existing.DurationMinutes = play.DurationMinutes;
                existing.TicketPrice = play.TicketPrice;
                existing.IsActive = play.IsActive;

                _context.SaveChanges();
            }
        }

        public void DeletePlay(Guid id)
        {
            var play = _context.Plays.Find(id);
            if (play != null)
            {
                _context.Plays.Remove(play);
                _context.SaveChanges();
            }
        }

        public Play GetPlayById(Guid id)
        {
            return _context.Plays.Find(id);
        }

        // Performance management
        public List<Performance> GetPerformancesByPlayId(Guid playId)
        {
            return _context.Performances
                .Where(p => p.PlayId == playId)
                .OrderBy(p => p.Date)
                .ToList();
        }

        public Performance GetPerformanceById(Guid id)
        {
            return _context.Performances
                .Include(p => p.Play)
                .FirstOrDefault(p => p.Id == id);
        }

        public void AddPerformance(Performance performance)
        {
            if (performance.Id == Guid.Empty)
            {
                performance.Id = Guid.NewGuid();
            }
            _context.Performances.Add(performance);
            _context.SaveChanges();
        }

        public void UpdatePerformance(Performance performance)
        {
            var existing = _context.Performances.Find(performance.Id);
            if (existing != null)
            {
                existing.Date = performance.Date;
                existing.TotalSeats = performance.TotalSeats;
                existing.AvailableSeats = performance.AvailableSeats;

                _context.SaveChanges();
            }
        }

        public void DeletePerformance(Guid id)
        {
            var performance = _context.Performances.Find(id);
            if (performance != null)
            {
                _context.Performances.Remove(performance);
                _context.SaveChanges();
            }
        }
    }
}
