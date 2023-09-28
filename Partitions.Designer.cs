namespace TP1_SLAM5
{
    partial class FormPartitions
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
            btn_allPart = new Button();
            cbStyles = new ComboBox();
            dgvPartitions = new DataGridView();
            bsPartition = new BindingSource(components);
            bsStyles = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvPartitions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPartition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyles).BeginInit();
            SuspendLayout();
            // 
            // btn_allPart
            // 
            btn_allPart.Location = new Point(449, 48);
            btn_allPart.Name = "btn_allPart";
            btn_allPart.Size = new Size(187, 29);
            btn_allPart.TabIndex = 5;
            btn_allPart.Text = "Toutes les partitions";
            btn_allPart.UseVisualStyleBackColor = true;
            btn_allPart.Click += btn_allPart_Click;
            // 
            // cbStyles
            // 
            cbStyles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStyles.FormattingEnabled = true;
            cbStyles.Location = new Point(180, 48);
            cbStyles.Name = "cbStyles";
            cbStyles.Size = new Size(219, 28);
            cbStyles.TabIndex = 4;
            // 
            // dgvPartitions
            // 
            dgvPartitions.AllowUserToAddRows = false;
            dgvPartitions.AllowUserToDeleteRows = false;
            dgvPartitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartitions.Location = new Point(61, 108);
            dgvPartitions.Name = "dgvPartitions";
            dgvPartitions.ReadOnly = true;
            dgvPartitions.RowHeadersWidth = 51;
            dgvPartitions.RowTemplate.Height = 29;
            dgvPartitions.Size = new Size(678, 295);
            dgvPartitions.TabIndex = 3;
            // 
            // bsStyles
            // 
            bsStyles.CurrentChanged += bsStyles_CurrentChanged;
            // 
            // FormPartitions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_allPart);
            Controls.Add(cbStyles);
            Controls.Add(dgvPartitions);
            Name = "FormPartitions";
            Text = "Partitions";
            Load += FormPartitions_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPartitions).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPartition).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_allPart;
        private ComboBox cbStyles;
        private DataGridView dgvPartitions;
        private BindingSource bsPartition;
        private BindingSource bsStyles;
    }
}