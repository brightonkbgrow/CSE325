﻿namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Topic { get; set; }
        public int SacramentMeetingId { get; set; }
        public SacramentMeeting? SacramentMeeting { get; set; }
    }

}