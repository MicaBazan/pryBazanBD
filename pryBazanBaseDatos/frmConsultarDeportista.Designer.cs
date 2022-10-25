namespace pryBazanBaseDatos
{
    partial class frmConsultarDeportista
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
            this.dgvDeportista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeportista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeportista
            // 
            this.dgvDeportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeportista.Location = new System.Drawing.Point(12, 33);
            this.dgvDeportista.Name = "dgvDeportista";
            this.dgvDeportista.RowHeadersWidth = 51;
            this.dgvDeportista.RowTemplate.Height = 24;
            this.dgvDeportista.Size = new System.Drawing.Size(920, 300);
            this.dgvDeportista.TabIndex = 0;
            // 
            // frmConsultarDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 368);
            this.Controls.Add(this.dgvDeportista);
            this.Name = "frmConsultarDeportista";
            this.Text = "Consultar Deportista";
            this.Load += new System.EventHandler(this.frmConsultarDeportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeportista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeportista;
    }
}