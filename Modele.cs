using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TP1_SLAM5.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace TP1_SLAM5
{
    internal static class Modele
    {
        private static BdPartitionsContext monModel;
        public static void init()
        {
            monModel = new BdPartitionsContext();
        }
        public static List<Client> listeClients()
        {
            return monModel.Clients.ToList();
        }
        public static List<Auteur> listeAuteurs()
        {
            return monModel.Auteurs.ToList();
        }
        public static List<Partition> listePartitions()
        {
            return monModel.Partitions.Include(a => a.NumstyleNavigation).ToList();
        }
        public static List<Commande> listeCommandes()
        {
            return monModel.Commandes.Include(a => a.NumcliNavigation).ToList();
        }

        public static List<Commande> listeCommandesParClient(int idClient)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Numcli ==
            idClient).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }

        public static List<Partition> listePartitionsParStyle(int idStyle)
        {
            List<Partition> lesPartitions = monModel.Partitions.Where(p => p.Numstyle ==
            idStyle).Include(p => p.NumstyleNavigation).ToList();
            return lesPartitions;
        }

        public static List<Style> listeStyle()
        {
            return monModel.Styles.ToList();
        }
        public static bool AjoutCommande(int montant, DateTime dateC, int idClient)
        {
            Commande maCommande;
            bool vretour = true;
            try
            {
                maCommande = new Commande();
                maCommande.Montantcde = montant; // mise à jour des propriétés
                maCommande.Datecde = DateOnly.FromDateTime(dateC); // la propriété DateCde doit être en DateTime dans la BD et dans la classe Commande, modifier si besoin.
                maCommande.Numcli = idClient;
                // ajout de l’objet : correspond à un insert
                monModel.Commandes.Add(maCommande);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                
                vretour = false;
            }
            return vretour;
        }
        public static Commande RecupererCommande(int idCommande)
        {
            Commande uneCommande = new Commande();
            try
            {
                uneCommande = monModel.Commandes.First(x => x.Numcde == idCommande);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneCommande;
        }



    }
}
