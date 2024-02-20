using PersonalDevelopmentAssistant.Entities;

namespace PersonalDevelopmentAssistant.Services
{
    public interface IGoalService
    {
        Task<List<Goal>> GetAllGoals();
    }
}
