using System.Data.SqlClient;


namespace FitnessClubApp.Models
{
    public class DBHelper : ICoachRepository
    {
        

        string conString = "Server=Dhivya-pc\\SqlExpress;Database=FitnessTracker;integrated security=true";
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public DBHelper()
        {
            con = new SqlConnection(conString);
            con.Open();
        }


        public int AddNewCoach(Coach coach)
        {
            string cmdText = "insert into Coaches(CoachName, CoachType, Email, Contact) values('" + coach.CoachName + "','" + coach.CoachType + "','" + coach.Email + "'," + coach.Contact + ")";
            com = new SqlCommand(cmdText, con);
            return com.ExecuteNonQuery();
}

        public Coach GetCoach(int id)
        {
            Coach c = GetCoaches().FirstOrDefault(cc => cc.CoachId == id);
                return c;
        }

        public List<Coach> GetCoaches()
        {
            List<Coach> coaches = new List<Coach>();
            com = new SqlCommand("Select * from coaches", con);
            reader = com.ExecuteReader();
            while(reader.Read())
            {
                Coach coach = new Coach();
                coach.CoachId = reader.GetInt32(0);
                coach.CoachName = reader.GetString(1);
                coach.CoachType = reader.GetString(2);
                coach.Email = reader.GetString(3);
                coach.Contact = reader.GetInt32(4);
                coaches.Add(coach);
            }

            return coaches;
            
        }
    }
}
