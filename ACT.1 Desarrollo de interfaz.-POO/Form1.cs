using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT._1_Desarrollo_de_interfaz._POO
{
    public partial class FormUno : Form
    {
        public FormUno()
        {
            InitializeComponent();
        }

        private void FormUno_MouseMove(object sender, MouseEventArgs e)
        {
            btninicio.BackColor = Color.LightSteelBlue;
            btnsalir.BackColor = Color.LightSteelBlue;

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            frmdos objfrmdos = new frmdos();
            this.Hide();
            objfrmdos.Show(); 
        }

        private void btninicio_MouseMove(object sender, MouseEventArgs e)
        {
            btninicio.BackColor = Color.Cyan;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnsalir.BackColor = Color.Cyan;
        }
    }
}
