namespace TP1_SLAM5
{
    public partial class Clients : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {


            bsClients.DataSource = Modele.listeClients(); // appel de la m�thode listeClients
            dgvClients.DataSource = bsClients;

            dgvClients.Columns[0].Visible = false;
            dgvClients.Columns[1].HeaderText = "Nom";
            dgvClients.Columns[2].HeaderText = "Pr�nom";
            dgvClients.Columns[3].HeaderText = "Adresse";
            dgvClients.Columns[4].HeaderText = "N� T�l�phone";

        }
        public Clients()
        {
            InitializeComponent();

        }



        private void btnCommandes_Click_1(object sender, EventArgs e)
        {
            FormCommandes formCommandes = new FormCommandes();
            formCommandes.Show();
        }

        private void btn_partition_Click(object sender, EventArgs e)
        {
            FormPartitions formPartitions = new FormPartitions();
            formPartitions.Show();
        }
    }
}