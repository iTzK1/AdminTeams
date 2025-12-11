using System;

namespace AdminTeams.App.Models
{
    // Para exibir no Grid (dados formatados)
    public class PlayerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; } // String formatada
        public int ShirtNumber { get; set; }
        public string Team { get; set; }      // Nome do Time
        public string Position { get; set; }  // Nome da Posição
    }

  
}