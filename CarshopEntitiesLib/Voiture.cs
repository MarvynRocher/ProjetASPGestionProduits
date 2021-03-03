using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Carshop.Shared
{
    [Table("Voiture")]
    public partial class Voiture
    {
        [Key]
        public long VoitureID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Marque { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Modele { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Categorie { get; set; }
        [Column(TypeName = "VARCHAR(255)")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "VARCHAR(255)")]
        [StringLength(255)]
        public string Image { get; set; }
        [Column(TypeName = "DATE")]
        public DateTime? DateAjout { get; set; }
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal? Prix { get; set; }
        public long FournisseurID { get; set; }
        public long CommandeID { get; set; }

        [ForeignKey(nameof(CommandeID))]
        [InverseProperty("Voitures")]
        public virtual Commande Commande { get; set; }
        [ForeignKey(nameof(FournisseurID))]
        [InverseProperty("Voitures")]
        public virtual Fournisseur Fournisseur { get; set; }
    }
}
