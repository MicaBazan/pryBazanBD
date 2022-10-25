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
    public partial class frmRegistrarEntrenador : Form
    {
        //Ruta para conectar
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\\Users\\marti\\Desktop\\pryBazanBaseDatos\\bin\\Debug\\DEPORTE.accdb";

        public frmRegistrarEntrenador()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conexion = new OleDbConnection(ruta);
                conexion.Open();

                //Variable para inertar datos
                string insert = @"INSERT INTO ENTRENADORES([CODIGO DEPORTISTA],NOMBRE,APELLIDO,DIRECCION,PROVINCIA,DEPORTE)
                                VALUES([@CODIGO DEPORTISTA], @NOMBRE, @APELLIDO, @DIRECCION, @PROVINCIA, @DEPORTE)";

                //Para inserte los registros seleccionados, conexion: los busque en la ruta
                OleDbCommand cmd = new OleDbCommand(insert, conexion);

                //AddWhithValue: Agrega el valor al final de la tabla
                //Los parametros puestos en VALUE se les asigna la caja de texto
                cmd.Parameters.AddWithValue("[@CODIGO DEPORTISTA]", lstCodigo.Text);
                cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                cmd.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
                cmd.Parameters.AddWithValue("@DIRECCION", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@PROVINCIA", txtProvincia.Text);
                cmd.Parameters.AddWithValue("@DEPORTE", lstDeporte.Text);


                //Si el numero de filas de la tabla es mayor a cero 
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Entrenador Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiar();
                }

                conexion.Close();
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpiar()
        {
            lstCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtProvincia.Text = "";
            lstDeporte.Text = "";

            lstCodigo.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
