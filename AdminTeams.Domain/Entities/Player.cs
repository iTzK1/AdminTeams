using AdminTeams.Domain.Base;
using AdminTeams.Domain.Entities;


namespace AdminTeams.Domain.Entities
{
    public class Player : BaseEntity<int>
    {
        public Player() : base(0)
        {
        }

        public Player(int id, string name, DateTime birthDate, int shirtNumber, int teamId, int positionId) : base(id)
        {
            Name = name;
            BirthDate = birthDate;
            ShirtNumber = shirtNumber;
            TeamId = teamId;
            PositionId = positionId;
        }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int ShirtNumber { get; set; }


        public int TeamId { get; set; }
        public virtual Team Team { get; set; }


        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
    }
}