using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryBazanBaseDatos
{
    public partial class frmEliminarDeportista : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=DEPORTE.accdb";

        public frmEliminarDeportista()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoBuscar.Text;
            //string nombre = txtNombre.Text;
            //string apellido = txtApellido.Text;
            //string direccion = txtDireccion.Text;
            //int telefono = int.Parse(txtTelefono.Text);
            //int edad = int.Parse(txtEdad.Text);
            //string deporte = txtDeporte.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);
            conexion.Open();

            string delete = "DELETE FROM DEPORTISTA WHERE [CODIGO DEPORTISTA] = " + codigo;

            OleDbCommand cmd = new OleDbCommand(delete, conexion);


            conexion.Close();
        }
    }
}
