using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerProyecto
{
    public partial class FormDocente : Form
    {
        public FormDocente()
        {
            InitializeComponent();
        }
        Conexion1 objConexion1 = new Conexion1();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objConexion1.obtenerDatos();
            objDt = objDs.Tables["Docentes"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idDocente"] };
            grdDocentes.DataSource = objDt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idDocente.Text = objDt.Rows[posicion]["idDocente"].ToString();
                txtCodigoDocentes.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreDocentes.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionDocentes.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoDocentes.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblnRegistrosDocentes.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }
        private void FormDocente_Load(object sender, EventArgs e)
        {
            actualizarDs();
        private void btnUltimoAlumno_Click_1(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnSiguienteAlumno_Click_1(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (btnAgregarDocentes.Text == "Nuevo")
            {
                btnAgregarDocentes.Text = "Guardar";
                btnModificarDocentes.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] Docentes = {
                    idDocente.Text, txtCodigoDocentes.Text, txtNombreDocentes.Text, txtDireccionDocentes.Text,
                    txtTelefonoDocentes.Text
                };
                String respuesta = objConexion1.administrarDatosAlumnos(Docentes, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarDocentes.Text = "Nuevo";
                    btnModificarDocentes.Text = "Modificar";
                    actualizarDs();
                }
            }

        }

        private void btnEliminarDocentes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreDocentes.Text,
               "Eliminando Docentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion1.administrarDatosAlumnos(
                    new String[] { idDocente.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar Docentes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (btnModificarDocentes.Text == "Modificar")
            {
                btnAgregarDocentes.Text = "Guardar";
                btnModificarDocentes.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarDocentes.Text = "Nuevo";
                btnModificarDocentes.Text = "Modificar";
            }
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosDocentes.Enabled = estado;
            grbNavegacionDocentes.Enabled = !estado;
            btnEliminarDocentes.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idDocente.Text = "";
            txtCodigoDocentes.Text = "";
            txtNombreDocentes.Text = "";
            txtDireccionDocentes.Text = "";
            txtTelefonoDocentes.Text = "";
        }

        private void txtBuscarAlumno_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarDocentes.Text);
        }
        private void filtrarDatos(String valor)
        {
            DataView objDv = objDt.DefaultView;
            objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '%" + valor + "%'";
            grdDocentes.DataSource = objDv;
            seleccionarAlumno();
        }
        private void seleccionarAlumno()
        {
            posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grdDocentes.CurrentRow.Cells["id"].Value));
            mostrarDatos();
        }
        private void grdAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarAlumno();
        }
    }
}