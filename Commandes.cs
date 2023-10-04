using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_SLAM5
{
    public partial class FormCommandes : Form
    {

        public FormCommandes()
        {
            InitializeComponent();
        }

        private void Commandes_Load(object sender, EventArgs e)
        {


            cbClients.ValueMember = "NUMCLI";
            cbClients.DisplayMember = "nomComplet";
            // nomComplet est la concaténation du nom et prénom issu de la requête suivante
            bsClients2.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli
            });
            cbClients.DataSource = bsClients2;

            resetDGV();



        }

        public void resetDGV()
        {
            bsCommandes.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });
            dgvCommandes.DataSource = bsCommandes;
            if (dgvCommandes.Rows.Count > 1)
            {
                dgvCommandes.Columns[0].HeaderText = "Numéro commande";
                dgvCommandes.Columns[1].HeaderText = "Montant commande";
                dgvCommandes.Columns[2].HeaderText = "Date commande";
                dgvCommandes.Columns[3].HeaderText = "Nom";
                dgvCommandes.Columns[4].HeaderText = "Prénom";
            }

        }

        private void bsClients2_CurrentChanged(object sender, EventArgs e)
        {
            // récupération de l’identifiant du client issu de la comboBox : on a NUMCLI en ValueMember de la
            // combo, donc on peut récupérer la valeur par la propriété SelectedValue
            int IdClient = Convert.ToInt32(cbClients.SelectedValue);
            bsCommandes.DataSource = Modele.listeCommandesParClient(IdClient).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            })
            .OrderBy(x => x.Datecde);
            dgvCommandes.DataSource = bsCommandes;
        }

        private void btn_allCli_Click(object sender, EventArgs e)
        {
            bsCommandes.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });
            dgvCommandes.DataSource = bsCommandes;
        }

        private void btnNvComm_Click(object sender, EventArgs e)
        {
            FormGestionCommandes formAddCommandes = new FormGestionCommandes("Ajout");
            formAddCommandes.Show();
        }

        private void btnModifComm_Click(object sender, EventArgs e)
        {
            System.Type type = bsCommandes.Current.GetType();
            int idCommande = (int)type.GetProperty("Numcde").GetValue(bsCommandes.Current, null);

            FormGestionCommandes formAddCommandes = new FormGestionCommandes("Modif", idCommande);
            formAddCommandes.Show();
        }

        private void btnSupprComm_Click(object sender, EventArgs e)
        {
            System.Type type = bsCommandes.Current.GetType();
            int idCommande = (int)type.GetProperty("Numcde").GetValue(bsCommandes.Current, null);

            if (MessageBox.Show("Etes vous sur de vouloir supprimer la commande :" + idCommande,
"Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Modele.SuppCommande(idCommande);
                resetDGV();
            }

        }

        private void FormCommandes_Activated(object sender, EventArgs e)
        {
            resetDGV();
        }
    }
}
