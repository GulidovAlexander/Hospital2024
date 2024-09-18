namespace BlazorClient.Models.Entity
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public string Specialist { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsAvailable { get; set; }
    }
}
