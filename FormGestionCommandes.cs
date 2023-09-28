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
        Commande comm;
        
        public FormGestionCommandes(string type)
        {
            InitializeComponent();
            this.type = type;
            comm = new Commande();

        }
        public FormGestionCommandes(string type, int idModif)
        {
            InitializeComponent();
            this.type = type;
            comm = Modele.RecupererCommande(idModif);


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

            if (type == "Modif")
            {
                cbCliComm.SelectedValue = comm.Numcli;
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
                {
                    btnAjouterComm.Visible = false;
                    btnModifComm.Visible = true;
                }
            }
        }

        private void btnValidComm_Click(object sender, EventArgs e)
        {

            try
            {
                comm.Montantcde = int.Parse(tbMontant.Text);
                comm.Datecde = DateOnly.FromDateTime(dtpCommande.Value.Date);
                comm.Numcli = Convert.ToInt32(cbCliComm.SelectedValue);

                if (comm.Numcli != -1)
                {
                    if (Modele.AjoutCommande(comm))
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

        private void btnModifComm_Click(object sender, EventArgs e)
        {
            try
            {
                comm.Montantcde = int.Parse(tbMontant.Text);
                comm.Datecde = DateOnly.FromDateTime(dtpCommande.Value.Date);
                comm.Numcli = Convert.ToInt32(cbCliComm.SelectedValue);

                if (comm.Numcli != -1)
                {
                    if (Modele.ModifCommande(comm))
                    {
                        MessageBox.Show("Modification réussie");
                        tbMontant.Text = "";
                        this.Close();

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
