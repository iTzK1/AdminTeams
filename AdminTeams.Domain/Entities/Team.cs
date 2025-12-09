using AdminTeams.Domain.Base;


namespace AdminTeams.Domain.Entities
{
    public class Team : BaseEntity<int>
    {
        public Team() : base(0)
        {
        }

        public Team(int id, string name, string category) : base(id)
        {
            Name = name;
            Category = category;
        }

        public string Name { get; set; }
        public string Category { get; set; }
    }
}