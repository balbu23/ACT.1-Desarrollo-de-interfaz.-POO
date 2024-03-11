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
    public partial class frmdos : Form
    {
        public frmdos()
        {
            InitializeComponent();
        }

        private void frmdos_MouseMove(object sender, MouseEventArgs e)
        {
            btnsalir.BackColor = Color.LightSteelBlue;
            btnregresar.BackColor = Color.LightSteelBlue; 
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            FormUno objFormuno = new FormUno();
            this.Hide();
            objFormuno.Show();
        }

        private void btnregresar_MouseMove(object sender, MouseEventArgs e)
        {
            btnregresar.BackColor = Color.Cyan;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnsalir.BackColor = Color.Cyan;
        }

        private void btnsalir_MouseHover(object sender, EventArgs e)
        {
            ToolTip totpista = new ToolTip();
            totpista.SetToolTip(btnsalir, "Haz click para salir");
        }

        private void btnregresar_MouseHover(object sender, EventArgs e)
        {
            ToolTip totpista = new ToolTip();
            totpista.SetToolTip(btnregresar, "Haz click para regresar");
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
           
            texval1.Text = "";
            textval2.Text = "";
            cboelige.Text = "";
            select1.Checked = false;
            select2.Checked = false;
            lblopcionelegida.Text = "";
            texval1.Focus();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            String opcion = null;
            if(select1.Checked ==true )
            {
                opcion = "Femenino";
            }
            else
            {
                opcion = "Masculino";
            }
            MessageBox.Show("Nombre:" + texval1.Text + Environment.NewLine +
                "Numero:" + textval2.Text + Environment.NewLine +
                "combo:" + cboelige.SelectedItem.ToString() + Environment.NewLine + "Opción:"
                + opcion , "Mensaje de la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);


            btnverificar.BackColor = Color.Cyan;
        }

        private void frmdos_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textval3_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cboelige_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboelige.SelectedIndex >0)
            {
                lblopcionelegida.Text = cboelige.SelectedItem.ToString(); ;  
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void select2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmdos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Abandonar la aplicación","Mensaje de la aplicación", MessageBoxButtons.OKCancel ,
                MessageBoxIcon.Question )==DialogResult.OK )
            {
                Application.Exit();  
            }
            else
            {
                e.Cancel = true; 
            }
        }

        private void texval1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textval2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar ))
            {
                e.Handled = false;
            }
            else 
                if (char.IsControl (e.KeyChar ) )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lblopcionelegida_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
