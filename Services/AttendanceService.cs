namespace BlazorProject.Services
{
    public class AttendanceService
    {
        private readonly List<string> attendees = new();

        public void RegisterAttendance(string name)
        {
            if (!attendees.Contains(name))
            {
                attendees.Add(name);
            }
        }

        public List<string> GetAttendees()
        {
            return attendees;
        }
    }
}