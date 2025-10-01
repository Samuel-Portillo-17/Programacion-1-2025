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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_academicaDataSet);

        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.dnotas' Puede moverla o quitarla según sea necesario.
            this.dnotasTableAdapter.dnotas(this.db_academicaDataSet.dnotas);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.Table' Puede moverla o quitarla según sea necesario.
            this.tableTableAdapter.Table(this.db_academicaDataSet.Table);

        }
    }
}
