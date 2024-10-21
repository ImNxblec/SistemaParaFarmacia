using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParaFarmacia
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtCorreoElectronico_Enter(object sender, EventArgs e)
        {
            if (txtCorreoElectronico.Text == "📩 Ejemplo@gmail.com")
            {
                txtCorreoElectronico.Text = "";
                txtCorreoElectronico.ForeColor = Color.Gray;
            }
        }

        private void txtCorreoElectronico_Leave(object sender, EventArgs e)
        {
            if (txtCorreoElectronico.Text == "")
            {
                txtCorreoElectronico.Text = "📩 Ejemplo@gmail.com";
                txtCorreoElectronico.ForeColor = Color.Silver;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if(txtContrasena.Text == "🔑 Contrasena")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Gray;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "🔑 Contrasena";
                txtContrasena.ForeColor = Color.Silver;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContrasena.Checked)
            {
                txtContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

    }
}
