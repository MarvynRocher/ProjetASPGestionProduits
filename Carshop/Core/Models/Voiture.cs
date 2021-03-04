using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System;

namespace Carshop.Core.Models
{
    public class Voiture
    {
        
        public long VoitureID { get; set; }

        public string Marque { get; set; }

        public string Modele { get; set; }
  
        public string Categorie { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
  
        public DateTime? DateAjout { get; set; }

        public decimal? Prix { get; set; }
        public long FournisseurID { get; set; }
        public long CommandeID { get; set; }

    }
}
