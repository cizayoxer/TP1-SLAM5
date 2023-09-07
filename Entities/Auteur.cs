﻿using System;
using System.Collections.Generic;

namespace TP1_SLAM5.Entities;

public partial class Auteur
{
    public int Numaut { get; set; }

    public string? Nomaut { get; set; }

    public string? Prenomaut { get; set; }

    public virtual ICollection<Partition> Numparts { get; set; } = new List<Partition>();
}
