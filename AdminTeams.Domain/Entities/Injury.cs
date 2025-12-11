using AdminTeams.Domain.Base;
using System;

namespace AdminTeams.Domain.Entities
{
    public class Injury : BaseEntity<int>
    {
        public Injury() : base(0) { }

        public Injury(int id, string description, DateTime startDate, DateTime? endDate, int playerId) : base(id)
        {
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            PlayerId = playerId;
        }

        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // Pode ser nulo se ainda estiver lesionado

        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
    }
}
