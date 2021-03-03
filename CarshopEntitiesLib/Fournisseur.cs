using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Carshop.Shared
{
    [Table("Fournisseur")]
    public partial class Fournisseur
    {
        public Fournisseur()
        {
            Voitures = new HashSet<Voiture>();
        }

        [Key]
        public long FournisseurID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string NomEntreprise { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string NomContact { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string FonctionContact { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Adresse { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Ville { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string CodePostal { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Pays { get; set; }
        [Column(TypeName = "VARCHAR(24)")]
        [StringLength(24)]
        public string Telephone { get; set; }
        [Column(TypeName = "VARCHAR(24)")]
        [StringLength(24)]
        public string Fax { get; set; }

        [InverseProperty(nameof(Voiture.Fournisseur))]
        public virtual ICollection<Voiture> Voitures { get; set; }
    }
}
