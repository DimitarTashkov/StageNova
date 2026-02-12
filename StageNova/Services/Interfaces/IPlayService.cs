using StageNova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageNova.Services.Interfaces
{
    public interface IPlayService
    {
        List<Play> GetAllPlays();
        List<Play> GetPlaysByGenre(string genre);
        void AddPlay(Play play);
        void UpdatePlay(Play play);
        void DeletePlay(Guid id);
        Play GetPlayById(Guid id);

        // Performance management
        List<Performance> GetPerformancesByPlayId(Guid playId);
        Performance GetPerformanceById(Guid id);
        void AddPerformance(Performance performance);
        void UpdatePerformance(Performance performance);
        void DeletePerformance(Guid id);
    }
}
