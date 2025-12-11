using System;

namespace AdminTeams.App.Models
{
    public class InjuryViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Player { get; set; } 
    }
}