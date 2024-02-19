using PersonalDevelopmentAssistant.Entities;
using PersonalDevelopmentAssistant.Data;
using Microsoft.EntityFrameworkCore;

namespace PersonalDevelopmentAssistant.Services
{
    public class GoalService : IGoalService
    {
        private readonly ApplicationDbContext _context;

        public GoalService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Goal>> GetAllTasks()
        {
            var goals = await _context.Goals.ToListAsync();
            return goals;
        }
    }
}
