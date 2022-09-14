using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessClubApp.Models
{
    public class CoachRepository:ICoachRepository
    {
        private static List<Coach> _coaches = new List<Coach>();
      //  {
      //      new Coach(){  CoachId = "C001",CoachName = "Suresh",CoachType = "WorkOut",Email = "sureshcoach@cloudkampus.com",Contact = 12345679 },

      //      new Coach() { CoachId="C002",CoachName="Amita",CoachType="Workout",Email="Amita@cloudkampus.com",Contact=123456788},

      //new Coach() { CoachId = "C003", CoachName = "Bhuvana", CoachType = "Diet", Email = "diet_Bhuvi@cloudkampus.com", Contact = 127856788 },
      //  new Coach() { CoachId = "C004", CoachName = "Rekha", CoachType = "Diet", Email = "Rehka@cloudkampus.com", Contact = 1237486788 }
      //  };

        public List<Coach> GetCoaches()
        {
            return _coaches;
        }

   
        public  int AddNewCoach(Coach coach)
        {
            _coaches.Add(coach);
            return 1;
        }

        public Coach GetCoach(int coach)
        {
            throw new NotImplementedException();
        }
    }
}
