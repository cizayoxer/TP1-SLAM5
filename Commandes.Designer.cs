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
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).BeginInit();
            SuspendLayout();
            // 
            // dgvCommandes
            // 
            dgvCommandes.AllowUserToAddRows = false;
            dgvCommandes.AllowUserToDeleteRows = false;
            dgvCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommandes.Location = new Point(67, 30);
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.ReadOnly = true;
            dgvCommandes.RowHeadersWidth = 51;
            dgvCommandes.RowTemplate.Height = 29;
            dgvCommandes.Size = new Size(678, 295);
            dgvCommandes.TabIndex = 0;
            // 
            // FormCommandes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCommandes);
            Name = "FormCommandes";
            Text = "Commandes";
            Load += Commandes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCommandes;
        private BindingSource bsCommandes;
    }
}