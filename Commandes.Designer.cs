namespace TP1_SLAM5
{
    partial class FormCommandes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvCommandes = new DataGridView();
            bsCommandes = new BindingSource(components);
            cbClients = new ComboBox();
            bsClients2 = new BindingSource(components);
            btn_allCli = new Button();
            btnNvComm = new Button();
            btnModifComm = new Button();
            btnSupprComm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).BeginInit();
            SuspendLayout();
            // 
            // dgvCommandes
            // 
            dgvCommandes.AllowUserToAddRows = false;
            dgvCommandes.AllowUserToDeleteRows = false;
            dgvCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommandes.Location = new Point(63, 93);
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.ReadOnly = true;
            dgvCommandes.RowHeadersWidth = 51;
            dgvCommandes.RowTemplate.Height = 29;
            dgvCommandes.Size = new Size(678, 295);
            dgvCommandes.TabIndex = 0;
            // 
            // cbClients
            // 
            cbClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(182, 33);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(219, 28);
            cbClients.TabIndex = 1;
            // 
            // bsClients2
            // 
            bsClients2.CurrentChanged += bsClients2_CurrentChanged;
            // 
            // btn_allCli
            // 
            btn_allCli.Location = new Point(451, 33);
            btn_allCli.Name = "btn_allCli";
            btn_allCli.Size = new Size(187, 29);
            btn_allCli.TabIndex = 2;
            btn_allCli.Text = "Tous les clients";
            btn_allCli.UseVisualStyleBackColor = true;
            btn_allCli.Click += btn_allCli_Click;
            // 
            // btnNvComm
            // 
            btnNvComm.Location = new Point(101, 409);
            btnNvComm.Name = "btnNvComm";
            btnNvComm.Size = new Size(193, 29);
            btnNvComm.TabIndex = 3;
            btnNvComm.Text = "Nouvelle commande";
            btnNvComm.UseVisualStyleBackColor = true;
            btnNvComm.Click += btnNvComm_Click;
            // 
            // btnModifComm
            // 
            btnModifComm.Location = new Point(361, 409);
            btnModifComm.Name = "btnModifComm";
            btnModifComm.Size = new Size(132, 29);
            btnModifComm.TabIndex = 4;
            btnModifComm.Text = "Modifier";
            btnModifComm.UseVisualStyleBackColor = true;
            btnModifComm.Click += btnModifComm_Click;
            // 
            // btnSupprComm
            // 
            btnSupprComm.Location = new Point(552, 409);
            btnSupprComm.Name = "btnSupprComm";
            btnSupprComm.Size = new Size(122, 29);
            btnSupprComm.TabIndex = 5;
            btnSupprComm.Text = "Supprimer";
            btnSupprComm.UseVisualStyleBackColor = true;
            btnSupprComm.Click += btnSupprComm_Click;
            // 
            // FormCommandes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSupprComm);
            Controls.Add(btnModifComm);
            Controls.Add(btnNvComm);
            Controls.Add(btn_allCli);
            Controls.Add(cbClients);
            Controls.Add(dgvCommandes);
            Name = "FormCommandes";
            Text = "Commandes";
            Activated += FormCommandes_Activated;
            Load += Commandes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCommandes;
        private BindingSource bsCommandes;
        private ComboBox cbClients;
        private BindingSource bsClients2;
        private Button btn_allCli;
        private Button btnNvComm;
        private Button btnModifComm;
        private Button btnSupprComm;
    }
}