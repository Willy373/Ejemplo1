using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Aplicacion : Form
    {
        public Aplicacion()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btb_suma_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(txt_entrada1.Text);
            int x2 = Convert.ToInt32(txt_entrada2.Text);
            int suma = x1 + x2;
            lbl_resultado.Text = suma.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
