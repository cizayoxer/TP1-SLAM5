namespace TP1_SLAM5
{
    partial class FormGestionCommandes
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
            tbMontant = new TextBox();
            dtpCommande = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbCliComm = new ComboBox();
            label4 = new Label();
            btnAjouterComm = new Button();
            bsClients = new BindingSource(components);
            btnModifComm = new Button();
            ((System.ComponentModel.ISupportInitialize)bsClients).BeginInit();
            SuspendLayout();
            // 
            // tbMontant
            // 
            tbMontant.Location = new Point(595, 216);
            tbMontant.MaxLength = 7;
            tbMontant.Name = "tbMontant";
            tbMontant.Size = new Size(181, 27);
            tbMontant.TabIndex = 0;
            // 
            // dtpCommande
            // 
            dtpCommande.Location = new Point(295, 214);
            dtpCommande.Name = "dtpCommande";
            dtpCommande.Size = new Size(250, 27);
            dtpCommande.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(595, 180);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 2;
            label1.Text = "Montant de la commande";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 180);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 180);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "Client";
            // 
            // cbCliComm
            // 
            cbCliComm.FormattingEnabled = true;
            cbCliComm.Location = new Point(12, 214);
            cbCliComm.Name = "cbCliComm";
            cbCliComm.Size = new Size(254, 28);
            cbCliComm.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(333, 54);
            label4.Name = "label4";
            label4.Size = new Size(158, 35);
            label4.TabIndex = 6;
            label4.Text = "COMMANDE";
            // 
            // btnAjouterComm
            // 
            btnAjouterComm.Location = new Point(373, 318);
            btnAjouterComm.Name = "btnAjouterComm";
            btnAjouterComm.Size = new Size(94, 29);
            btnAjouterComm.TabIndex = 7;
            btnAjouterComm.Text = "Ajouter";
            btnAjouterComm.UseVisualStyleBackColor = true;
            btnAjouterComm.Visible = false;
            btnAjouterComm.Click += btnValidComm_Click;
            // 
            // btnModifComm
            // 
            btnModifComm.Location = new Point(373, 353);
            btnModifComm.Name = "btnModifComm";
            btnModifComm.Size = new Size(94, 29);
            btnModifComm.TabIndex = 8;
            btnModifComm.Text = "Modifier";
            btnModifComm.UseVisualStyleBackColor = true;
            btnModifComm.Visible = false;
            // 
            // FormGestionCommandes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModifComm);
            Controls.Add(btnAjouterComm);
            Controls.Add(label4);
            Controls.Add(cbCliComm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpCommande);
            Controls.Add(tbMontant);
            Name = "FormGestionCommandes";
            Text = "FormGestionCommandes";
            Load += FormGestionCommandes_Load;
            ((System.ComponentModel.ISupportInitialize)bsClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMontant;
        private DateTimePicker dtpCommande;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbCliComm;
        private Label label4;
        private Button btnAjouterComm;
        private BindingSource bsClients;
        private Button btnModifComm;
    }
}