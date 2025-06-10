namespace EventEase.Services
{
    public class AttendanceTracker
    {
        private List<string> attendees = new();

        public void RegisterAttendance(string person)
        {
            attendees.Add(person);
        }
    }
}