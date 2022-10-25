namespace pryBazanBaseDatos
{
    partial class frmConsultarEntrenador
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
            this.dgvEntrenador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntrenador
            // 
            this.dgvEntrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenador.Location = new System.Drawing.Point(12, 12);
            this.dgvEntrenador.Name = "dgvEntrenador";
            this.dgvEntrenador.RowHeadersWidth = 51;
            this.dgvEntrenador.RowTemplate.Height = 24;
            this.dgvEntrenador.Size = new System.Drawing.Size(891, 354);
            this.dgvEntrenador.TabIndex = 0;
            // 
            // frmConsultarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 396);
            this.Controls.Add(this.dgvEntrenador);
            this.Name = "frmConsultarEntrenador";
            this.Text = "Consultar Entrenador";
            this.Load += new System.EventHandler(this.frmConsultarEntrenador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntrenador;
    }
}