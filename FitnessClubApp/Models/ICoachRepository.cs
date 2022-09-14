namespace FitnessClubApp.Models
{
    public interface ICoachRepository
    {
        List<Coach> GetCoaches();
        Coach GetCoach(int coach);

        int AddNewCoach(Coach coach);
    }
}
