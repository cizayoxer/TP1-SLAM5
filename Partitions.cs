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
    public partial class FormPartitions : Form
    {
        public FormPartitions()
        {
            InitializeComponent();
        }

        private void FormPartitions_Load(object sender, EventArgs e)
        {

            cbStyles.ValueMember = "Numstyle";
            cbStyles.DisplayMember = "Libstyle";
            // nomComplet est la concaténation du nom et prénom issu de la requête suivante
            bsStyles.DataSource = (Modele.listeStyle()).Select(x => new
            {
                x.Numstyle,
                x.Libstyle
            });
            cbStyles.DataSource = bsStyles;



            bsPartition.DataSource = Modele.listePartitions().Select(x => new
            {
                x.Numpart,
                x.Libpart,
                x.Prixpart,
                x.NumstyleNavigation.Libstyle

            });
            dgvPartitions.DataSource = bsPartition;
        }

        private void btn_allPart_Click(object sender, EventArgs e)
        {
            bsPartition.DataSource = Modele.listePartitions().Select(x => new
            {
                x.Numpart,
                x.Libpart,
                x.Prixpart,
                x.NumstyleNavigation.Libstyle

            });
            dgvPartitions.DataSource = bsPartition;
        }

        private void bsStyles_CurrentChanged(object sender, EventArgs e)
        {
            int IdStyle = Convert.ToInt32(cbStyles.SelectedValue);
            bsPartition.DataSource = Modele.listePartitionsParStyle(IdStyle).Select(x => new
            {
                x.Numpart,
                x.Libpart,
                x.Prixpart,
                x.NumstyleNavigation.Libstyle

            });
            dgvPartitions.DataSource = bsPartition;
        }
    }
}
