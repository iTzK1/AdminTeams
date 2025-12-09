namespace AdminTeams.App.Models
{
   
    public class TeamViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }

    public class TeamInputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }
}