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
    public partial class frmRegistrarDeportista : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=DEPORTE.accdb";

        public frmRegistrarDeportista()
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
                string insert = @"INSERT INTO DEPORTISTA([CODIGO DEPORTISTA],NOMBRE,APELLIDO,DIRECCION,TELEFONO,EDAD,DEPORTE)
                                VALUES([@CODIGO DEPORTISTA], @NOMBRE, @APELLIDO, @DIRECCION, @TELEFONO, @EDAD, @DEPORTE)";

                //Para inserte los registros seleccionados, conexion: los busque en la ruta
                OleDbCommand cmd = new OleDbCommand(insert, conexion);

                //AddWhithValue: Agrega el valor al final de la tabla
                //Los parametros puestos en VALUE se les asigna la caja de texto
                //ToUpper: para que que se guarde el texto en mayuscula
                cmd.Parameters.AddWithValue("[@CODIGO DEPORTISTA]", lstCodigo.Text.ToUpper());
                cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text.ToUpper());
                cmd.Parameters.AddWithValue("@APELLIDO", txtApellido.Text.ToUpper());
                cmd.Parameters.AddWithValue("@DIRECCION", txtDireccion.Text.ToUpper());
                cmd.Parameters.AddWithValue("@TELEFONO", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@EDAD", lstEdad.Text);
                cmd.Parameters.AddWithValue("@DEPORTE", lstDeporte.Text.ToUpper());

                //Devuelve el numero de filas
                cmd.ExecuteNonQuery();
                

                MessageBox.Show("Deportista Registrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);


                limpiar();


                conexion.Close();
                
            }
            catch(Exception ex)
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
            txtTelefono.Text = "";
            lstEdad.Text = "";
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
