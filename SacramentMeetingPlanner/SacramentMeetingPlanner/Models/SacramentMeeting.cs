using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeeting
    {
        public int Id { get; set; }

        [Display(Name = "Meeting Date and Time")]
        public DateTime MeetingDate { get; set; }

        [Display(Name = "Conductor")]
        public required string ConductingLeader { get; set; }

        [Display(Name = "Opening Hymn")]
        public required string OpeningSong { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public required string SacramentHymn { get; set; }

        [Display(Name = "Closing Hymn")]
        public required string ClosingSong { get; set; }

        [Display(Name = "Opening Prayer")]
        public required string OpeningPrayer { get; set; }

        [Display(Name = "Closing Prayer")]
        public required string ClosingPrayer { get; set; }

        [Display(Name = "Speaker")]
        public ICollection<Speaker> Speakers { get; set; }


    }

}
