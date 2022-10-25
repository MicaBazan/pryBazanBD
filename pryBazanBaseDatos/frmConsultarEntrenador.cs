using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBazanBaseDatos
{
    public partial class frmConsultarEntrenador : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\\Users\\marti\\Desktop\\pryBazanBaseDatos\\bin\\Debug\\DEPORTE.accdb";

        public frmConsultarEntrenador()
        {
            InitializeComponent();
        }

        private void frmConsultarEntrenador_Load(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection conexion = new OleDbConnection(ruta);
                conexion.Open();
                DataTable dt = new DataTable();
                string select = @"SELECT * FROM ENTRENADORES";
                OleDbCommand cmd = new OleDbCommand(select, conexion);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.SelectCommand = cmd;
                da.Fill(dt);
                dgvEntrenador.DataSource = dt;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
