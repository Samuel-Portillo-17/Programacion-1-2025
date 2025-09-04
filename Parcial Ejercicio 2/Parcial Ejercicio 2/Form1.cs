using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        String[][] etiquetas = new string[][] {
             new string[]{"Metro cuadrado", "Pie cuadrado", "Vara cuadrada", "Yarda cuadrada", "Tareas", "Manzana", "Hectarea" }
        };
        double[][] valores = new double[][] {
             new double []{1, 10.7636, 0.705012, 1.19599, 437.5, 6988, 1000 } //Area
        };
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double cantidad = double.Parse(txtCantidadConversor.Text);

            int tipo = cboTipoConversor.SelectedIndex;
            int de = cboDeConversor.SelectedIndex;
            int a = cboAConversor.SelectedIndex;

            double respuesta = cantidad * valores[tipo][a] / valores[tipo][de];

            lblRespuestaConversor.Text = "Respuesta: " + respuesta.ToString("N2");
        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDeConversor.Items.Clear();
            cboAConversor.Items.Clear();
            cboDeConversor.Items.AddRange(etiquetas[cboTipoConversor.SelectedIndex]);
            cboAConversor.Items.AddRange(etiquetas[cboTipoConversor.SelectedIndex]);
        }
    }
}
