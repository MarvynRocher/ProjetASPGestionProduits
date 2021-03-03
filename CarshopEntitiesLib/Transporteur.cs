using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Carshop.Shared
{
    [Table("Transporteur")]
    public partial class Transporteur
    {
        public Transporteur()
        {
            Commandes = new HashSet<Commande>();
        }

        [Key]
        public long TransporteurID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Nom { get; set; }
        [Column(TypeName = "VARCHAR(24)")]
        [StringLength(24)]
        public string Telephone { get; set; }

        [InverseProperty(nameof(Commande.Transporteur))]
        public virtual ICollection<Commande> Commandes { get; set; }
    }
}
