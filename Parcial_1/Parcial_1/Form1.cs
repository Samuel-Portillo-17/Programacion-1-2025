using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        { }

        private double[][] tbl = {
            new Double[] {0.01, 500, 1.5, 0 },
            new Double[] {550.01,1000, 1.5, 3 },
            new Double[] {1000.01, 2000, 3, 3},
            new Double[] {2000.01, 3000, 6, 3},
            new Double[] {3000.01, 6000, 9, 2},
            new Double[] {8000.01, 18000, 15, 2},
            new Double[] {18000.01, 30000, 39, 2} 
        };
        private object txtMonto;

        private double Calcular(double Monto)
        {
            for (int i = 0; i < tbl.Length; i++)
            {

                double Desde = tbl[i][0];
                double Hasta = tbl[i][1];
                double Precio = tbl[i][2];
                double Adicional = tbl[i][3];
                if (Monto >= Desde && Monto <= Hasta)
                {
                    double Cantidadex = Monto - Desde;
                    double CantidadM = Cantidadex / 1000;
                    return (CantidadM * Adicional) + Precio;
                }

            }
            return 0;
        }

        private void btnCalcularImp_Click(object sender, EventArgs e)
        {
            try
            {
                double Monto = double.Parse(txtM.Text);
                double impuesto = Calcular(Monto);
                lblResultado.Text = "Impuesto: $" + impuesto.ToString("N2");
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }


        }

       
    }
    
}

        


        
       

    

    

