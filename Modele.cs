using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_SLAM5.Entities;

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
            return monModel.Partitions.ToList();
        }
        public static List<Commande> listeCommandes()
        {
            return monModel.Commandes.ToList();
        }


    }
}
