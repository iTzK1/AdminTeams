using System;

namespace AdminTeams.App.Models
{
    // Para exibir no Grid (dados formatados)
    public class PlayerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; } 
        public int ShirtNumber { get; set; }
        public string Team { get; set; }     
        public string Position { get; set; }  
    }

  
}