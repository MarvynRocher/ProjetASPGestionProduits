using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Carshop.Shared
{
    [Table("Commande")]
    public partial class Commande
    {
        public Commande()
        {
            Voitures = new HashSet<Voiture>();
        }

        [Key]
        public long CommandeID { get; set; }
        [Column(TypeName = "DATE")]
        public DateTime? DateCommande { get; set; }
        [Column(TypeName = "DATE")]
        public DateTime? DateLivraison { get; set; }
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal? Frais { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string NomLivraison { get; set; }
        [Column(TypeName = "VARCHAR(60)")]
        [StringLength(60)]
        public string AdresseLivraison { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        [StringLength(20)]
        public string VilleLivraison { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string CodePostalLivraison { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        [StringLength(20)]
        public string PaysLivraison { get; set; }
        public string UserName { get; set; }
        public long TransporteurID { get; set; }

        [ForeignKey(nameof(TransporteurID))]
        [InverseProperty("Commandes")]
        public virtual Transporteur Transporteur { get; set; }
        [InverseProperty(nameof(Voiture.Commande))]
        public virtual ICollection<Voiture> Voitures { get; set; }
    }
}
