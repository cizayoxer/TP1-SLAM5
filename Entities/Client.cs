﻿using System;
using System.Collections.Generic;

namespace TP1_SLAM5.Entities;

public partial class Client
{
    public int Numcli { get; set; }

    public string? Nomcli { get; set; }

    public string? Prenomcli { get; set; }

    public string? Adrcli { get; set; }

    public string? Telcli { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();
}
