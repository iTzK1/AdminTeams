using AdminTeams.Domain.Base;

namespace AdminTeams.Domain.Entities
{
    public class Position : BaseEntity<int>
    {
        public Position() : base(0)
        {
        }

        public Position(int id, string name, string acronym) : base(id)
        {
            Name = name;
            Acronym = acronym;
        }

        public string Name { get; set; }
        public string Acronym { get; set; }
    }
}