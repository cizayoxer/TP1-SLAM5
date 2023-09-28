using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_SLAM5.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TP1_SLAM5
{
    public partial class FormGestionCommandes : Form
    {
        string type;
        int idModif;
        public FormGestionCommandes(string type)
        {
            InitializeComponent();
            this.type = type;
            this.idModif = -1;

        }
        public FormGestionCommandes(string type,int idModif)
        {
            InitializeComponent();
            this.type = type;
            this.idModif = idModif;

        }

        private void FormGestionCommandes_Load(object sender, EventArgs e)
        {
            
            cbCliComm.ValueMember = "NUMCLI";
            cbCliComm.DisplayMember = "nomComplet";
            // nomComplet est la concaténation du nom et prénom issu de la requête suivante
            bsClients.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli
            });
            cbCliComm.DataSource = bsClients;

            if (type == "Modif") { 
                cbCliComm.SelectedValue = idModif;
                Commande comm = Modele.RecupererCommande(idModif);
                tbMontant.Text = comm.Montantcde.ToString();
                dtpCommande.Text = comm.Datecde.ToString();
            }

            if (type == "Ajout")
            {
                btnAjouterComm.Visible = true;
                btnModifComm.Visible = false;
            }
            else 
            {
                if (type == "Modif") 
                { btnAjouterComm.Visible = false;
                  btnModifComm.Visible = true;
                } 
            }
        }

        private void btnValidComm_Click(object sender, EventArgs e)
        {

            try
            {
                int montant = int.Parse(tbMontant.Text);
                DateTime date = dtpCommande.Value.Date;
                int IdClient = Convert.ToInt32(cbCliComm.SelectedValue);

                if (IdClient != -1)
                {
                    if (Modele.AjoutCommande(montant, date, IdClient))
                    {
                        MessageBox.Show("Insertion réussie");
                        tbMontant.Text = "";

                    }
                }
            }
            catch (Exception ex)
            {
                tbMontant.Text = "";
                MessageBox.Show("veuillez entrer un entier en montant");
            }


        }
    }
}
