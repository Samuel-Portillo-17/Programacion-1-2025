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
    public partial class frmMaterias : Form
    {
        public frmMaterias()
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
            objDt = objDs.Tables["Materias"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idMateria"] };
            grdMateria.DataSource = objDt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idMateria.Text = objDt.Rows[posicion]["idMateria"].ToString();
                txtCodigoMateria.Text = objDt.Rows[posicion]["Codigo"].ToString();
                txtNombreMateria.Text = objDt.Rows[posicion]["Nombre"].ToString();
                txtUvMateria.Text = objDt.Rows[posicion]["Unidad"].ToString();
               

                lblnRegistrosMateria.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            actualizarDs();
            cboBuscarMateria.SelectedIndex = 1; //buscar por materia
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosMateria.Enabled = estado;
            grbNavegacionAlumno.Enabled = !estado;
            btnEliminarMateria.Enabled = !estado;
        }

        private void limpiarControles()
        {
            idMateria.Text = "";
            txtCodigoMateria.Text = "";
            txtNombreMateria.Text = "";
            txtUvMateria.Text = "";
        }

        private void filtrarDatos(String valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;
                switch (cboBuscarMateria.SelectedIndex)
                {
                    case 0: //codigo
                        objDv.RowFilter = "codigo = " + valor;
                        break;

                    case 1: //nombre
                        objDv.RowFilter = "nombre like '%" + valor + "%'";
                        break;
                }
                grdMateria.DataSource = objDv;
                seleccionarMaterias();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void grbDatosMateria_Enter(object sender, EventArgs e)
        {

        }
        private void seleccionarMaterias()
        {
            try
            {
                if (grdMateria.CurrentRow == null)
                {
                   // MessageBox.Show("No hay filas");
                    return;
                }
                string id = grdMateria.CurrentRow.Cells["id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnPrimeroMateria_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnAnteriorMateria_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguienteMateria_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoMateria_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            if (btnAgregarMateria.Text == "Nuevo")
            {
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] Materia = {
                    idMateria.Text, txtCodigoMateria.Text, txtNombreMateria.Text,
                    txtUvMateria.Text
                };
                String respuesta = objConexion1.administrarDatosMaterias(Materia, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar Materia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarMateria.Text = "Nuevo";
                    btnModificarMateria.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            if (btnModificarMateria.Text == "Modificar")
            {
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarMateria.Text = "Nuevo";
                btnModificarMateria.Text = "Modificar";
            }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreMateria.Text,
            "Eliminando Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion1.administrarDatosAlumnos(
                    new String[] { idMateria.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar Materia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void txtBuscarMateria_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarMateria.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarMaterias();
        }

        private void txtBuscarMateria_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

