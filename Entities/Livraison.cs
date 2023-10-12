using System;
using System.Collections.Generic;

namespace TP1_SLAM5.Entities;

public partial class Livraison
{
    public int IdLivraison { get; set; }

    public string NomLivraison { get; set; } = null!;

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();
}
