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

        
        }
    }

