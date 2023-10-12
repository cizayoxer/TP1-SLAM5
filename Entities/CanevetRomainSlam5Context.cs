﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TP1_SLAM5.Entities;

public partial class CanevetRomainSlam5Context : DbContext
{
    public CanevetRomainSlam5Context()
    {
    }

    public CanevetRomainSlam5Context(DbContextOptions<CanevetRomainSlam5Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Auteur> Auteurs { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Commande> Commandes { get; set; }

    public virtual DbSet<Livraison> Livraisons { get; set; }

    public virtual DbSet<Partition> Partitions { get; set; }

    public virtual DbSet<Style> Styles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.10.16;port=3306;user=canevet_romain;password=9trIwvDV;database=canevet_romain_SLAM5", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.9.8-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Auteur>(entity =>
        {
            entity.HasKey(e => e.Numaut).HasName("PRIMARY");

            entity.ToTable("auteur");

            entity.Property(e => e.Numaut)
                .HasColumnType("int(11)")
                .HasColumnName("NUMAUT");
            entity.Property(e => e.Nomaut)
                .HasMaxLength(128)
                .HasColumnName("NOMAUT");
            entity.Property(e => e.Prenomaut)
                .HasMaxLength(128)
                .HasColumnName("PRENOMAUT");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Numcli).HasName("PRIMARY");

            entity.ToTable("client");

            entity.Property(e => e.Numcli)
                .HasColumnType("int(11)")
                .HasColumnName("NUMCLI");
            entity.Property(e => e.Adrcli)
                .HasMaxLength(128)
                .HasColumnName("ADRCLI");
            entity.Property(e => e.Nomcli)
                .HasMaxLength(128)
                .HasColumnName("NOMCLI");
            entity.Property(e => e.Prenomcli)
                .HasMaxLength(128)
                .HasColumnName("PRENOMCLI");
            entity.Property(e => e.Telcli)
                .HasMaxLength(255)
                .HasColumnName("TELCLI");
        });

        modelBuilder.Entity<Commande>(entity =>
        {
            entity.HasKey(e => e.Numcde).HasName("PRIMARY");

            entity.ToTable("commande");

            entity.HasIndex(e => e.IdLivraison, "FK_COMMANDE_LIVRAISON");

            entity.HasIndex(e => e.Numcli, "I_FK_COMMANDE_ADHERENT");

            entity.Property(e => e.Numcde)
                .HasColumnType("int(11)")
                .HasColumnName("NUMCDE");
            entity.Property(e => e.Datecde).HasColumnName("DATECDE");
            entity.Property(e => e.IdLivraison)
                .HasColumnType("int(11)")
                .HasColumnName("idLivraison");
            entity.Property(e => e.Montantcde)
                .HasColumnType("int(11)")
                .HasColumnName("MONTANTCDE");
            entity.Property(e => e.Numcli)
                .HasColumnType("int(11)")
                .HasColumnName("NUMCLI");

            entity.HasOne(d => d.IdLivraisonNavigation).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.IdLivraison)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_COMMANDE_LIVRAISON");

            entity.HasOne(d => d.NumcliNavigation).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.Numcli)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMMANDE_ADHERENT");

            entity.HasMany(d => d.Numparts).WithMany(p => p.Numcdes)
                .UsingEntity<Dictionary<string, object>>(
                    "Contenir",
                    r => r.HasOne<Partition>().WithMany()
                        .HasForeignKey("Numpart")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("contenir_ibfk_2"),
                    l => l.HasOne<Commande>().WithMany()
                        .HasForeignKey("Numcde")
                        .HasConstraintName("contenir_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Numcde", "Numpart")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("contenir");
                        j.HasIndex(new[] { "Numcde" }, "I_FK_CONTENIR_COMMANDE");
                        j.HasIndex(new[] { "Numpart" }, "NUMPART");
                        j.IndexerProperty<int>("Numcde")
                            .HasColumnType("int(11)")
                            .HasColumnName("NUMCDE");
                        j.IndexerProperty<int>("Numpart")
                            .HasColumnType("int(11)")
                            .HasColumnName("NUMPART");
                    });
        });

        modelBuilder.Entity<Livraison>(entity =>
        {
            entity.HasKey(e => e.IdLivraison).HasName("PRIMARY");

            entity.ToTable("livraison");

            entity.Property(e => e.IdLivraison)
                .HasColumnType("int(11)")
                .HasColumnName("idLivraison");
            entity.Property(e => e.NomLivraison)
                .HasMaxLength(255)
                .HasColumnName("nomLivraison");
        });

        modelBuilder.Entity<Partition>(entity =>
        {
            entity.HasKey(e => e.Numpart).HasName("PRIMARY");

            entity.ToTable("partitions");

            entity.HasIndex(e => e.Numstyle, "FK_STYLE_PARTITION");

            entity.Property(e => e.Numpart)
                .HasColumnType("int(11)")
                .HasColumnName("NUMPART");
            entity.Property(e => e.Libpart)
                .HasMaxLength(128)
                .HasColumnName("LIBPART");
            entity.Property(e => e.Numstyle)
                .HasColumnType("int(11)")
                .HasColumnName("NUMSTYLE");
            entity.Property(e => e.Prixpart)
                .HasColumnType("int(11)")
                .HasColumnName("PRIXPART");

            entity.HasOne(d => d.NumstyleNavigation).WithMany(p => p.Partitions)
                .HasForeignKey(d => d.Numstyle)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_STYLE_PARTITION");

            entity.HasMany(d => d.Numauts).WithMany(p => p.Numparts)
                .UsingEntity<Dictionary<string, object>>(
                    "Ecrire",
                    r => r.HasOne<Auteur>().WithMany()
                        .HasForeignKey("Numaut")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("ecrire_ibfk_2"),
                    l => l.HasOne<Partition>().WithMany()
                        .HasForeignKey("Numpart")
                        .HasConstraintName("ecrire_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Numpart", "Numaut")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("ecrire");
                        j.HasIndex(new[] { "Numaut" }, "I_FK_ECRIRE_AUTEUR");
                        j.HasIndex(new[] { "Numpart" }, "I_FK_ECRIRE_PARTITIONS");
                        j.IndexerProperty<int>("Numpart")
                            .HasColumnType("int(11)")
                            .HasColumnName("NUMPART");
                        j.IndexerProperty<int>("Numaut")
                            .HasColumnType("int(11)")
                            .HasColumnName("NUMAUT");
                    });
        });

        modelBuilder.Entity<Style>(entity =>
        {
            entity.HasKey(e => e.Numstyle).HasName("PRIMARY");

            entity.ToTable("style");

            entity.Property(e => e.Numstyle)
                .HasColumnType("int(11)")
                .HasColumnName("NUMSTYLE");
            entity.Property(e => e.Libstyle)
                .HasMaxLength(255)
                .HasColumnName("LIBSTYLE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
