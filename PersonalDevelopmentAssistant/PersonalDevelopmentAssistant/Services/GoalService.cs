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

        public async Task<List<Goal>> GetAllGoals()
        {
            // Simulate asynchronous loading to demonstrate a loading indicator
            await Task.Delay(500);

            var goals = await _context.Goals.ToListAsync();
            return goals;
        }
    }
}
