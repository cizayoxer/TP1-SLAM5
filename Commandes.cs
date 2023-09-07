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
            bsCommandes.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde
            });
            dgvCommandes.DataSource = bsCommandes;
        }
    }
}
