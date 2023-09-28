namespace TP1_SLAM5
{
    partial class Clients
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bsClients = new BindingSource(components);
            dgvClients = new DataGridView();
            btnCommandes = new Button();
            btn_partition = new Button();
            ((System.ComponentModel.ISupportInitialize)bsClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AllowUserToOrderColumns = true;
            dgvClients.AllowUserToResizeColumns = false;
            dgvClients.AllowUserToResizeRows = false;
            dgvClients.Anchor = AnchorStyles.None;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(56, 42);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 51;
            dgvClients.RowTemplate.Height = 29;
            dgvClients.Size = new Size(694, 333);
            dgvClients.TabIndex = 0;
            // 
            // btnCommandes
            // 
            btnCommandes.Location = new Point(231, 391);
            btnCommandes.Name = "btnCommandes";
            btnCommandes.Size = new Size(94, 29);
            btnCommandes.TabIndex = 1;
            btnCommandes.Text = "Commandes";
            btnCommandes.UseVisualStyleBackColor = true;
            btnCommandes.Click += btnCommandes_Click_1;
            // 
            // btn_partition
            // 
            btn_partition.Location = new Point(438, 391);
            btn_partition.Name = "btn_partition";
            btn_partition.Size = new Size(94, 29);
            btn_partition.TabIndex = 2;
            btn_partition.Text = "Partitions";
            btn_partition.UseVisualStyleBackColor = true;
            btn_partition.Click += btn_partition_Click;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_partition);
            Controls.Add(btnCommandes);
            Controls.Add(dgvClients);
            Name = "Clients";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bsClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsClients;
        private DataGridView dgvClients;
        private Button btnCommandes;
        private Button btn_partition;
    }
}