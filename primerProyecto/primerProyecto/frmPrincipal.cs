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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPractica_Load(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos objAlumnos = new frmAlumnos(); 
            objAlumnos.MdiParent = this;
            objAlumnos.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias objMaterias = new frmMaterias();
            objMaterias.MdiParent = this;
            objMaterias.Show();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDocente objDocentes = new FormDocente();
            objDocentes.MdiParent = this;
            objDocentes.Show();
        }
    }
}
