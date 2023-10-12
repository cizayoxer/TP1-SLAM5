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
        private static CanevetRomainSlam5Context monModel;
        public static void init()
        {
            monModel = new CanevetRomainSlam5Context();
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
        public static bool AjoutCommande(Commande comm)
        {
            
            bool vretour = true;
            try
            {
                monModel.Commandes.Add(comm);
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

        public static bool ModifCommande(Commande comm)
        {
            bool vretour = true;
            try
            {
                monModel.Commandes.Update(comm);
                monModel.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour=false;
            }
            
            return vretour;
        }
        public static bool SuppCommande(int idCommande)
        {
            bool vretour = true;
            try
            {
                Commande maCommande = RecupererCommande(idCommande);
                monModel.Commandes.Remove(maCommande); // correspond au DELETE
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                vretour = false;
            }
            return vretour;
        }

    }
}
