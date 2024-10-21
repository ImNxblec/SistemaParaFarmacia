using SistemaParaFarmacia.Clases;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private bool CamposEstanVacios()
        {
            if (txtNombre.Text == "Nombre" || txtApellido.Text == "Apellido" || txtCedula.Text == "0999999999" ||
                txtCorreo.Text == "Ejemplo@gmail.com" || txtContrasena.Text == "🔑 Contrasena" ||
                txtRepetirContrasena.Text == "🔑 Contrasena")
            {
                return true; // Hay campos vacíos o con placeholders
            }
            return false; // Todos los campos están completos
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            ValidarEmail validador = new ValidarEmail();

            string correo = txtCorreo.Text; // Obtener el texto del TextBox del correo electrónico

            if (!validador.ValidarCorreo(correo))
            {
                MessageBox.Show("El correo electrónico no es válido.");
            }

            ComprarContrasena validarContrasena = new ComprarContrasena();

            string contrasena1 = txtContrasena.Text;        // Obtener la primera contraseña del TextBox
            string contrasena2 = txtRepetirContrasena.Text; // Obtener la segunda contraseña del TextBox de confirmación

            if (!validarContrasena.SonIguales(contrasena1, contrasena2))
            {
                MessageBox.Show("Las contraseñas no coinciden.");
            }

            if (CamposEstanVacios())
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ValidarEmail validador = new ValidarEmail();

            string correo = txtCorreo.Text; // Obtener el texto del TextBox del correo electrónico

            if (!validador.ValidarCorreo(correo))
            {
                MessageBox.Show("El correo electrónico no es válido.");
            }
            
            ComprarContrasena validarContrasena = new ComprarContrasena();

            string contrasena1 = txtContrasena.Text;        // Obtener la primera contraseña del TextBox
            string contrasena2 = txtRepetirContrasena.Text; // Obtener la segunda contraseña del TextBox de confirmación

            if (!validarContrasena.SonIguales(contrasena1, contrasena2))
            {
                MessageBox.Show("Las contraseñas no coinciden.");
            }

            if (CamposEstanVacios())
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar.");
            }
            else
            {
                // Código para registrar
                MessageBox.Show("Registro exitoso.");
            }
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chkMostrarContrasena.Checked)
                {
                    txtContrasena.UseSystemPasswordChar = false;
                    txtRepetirContrasena.UseSystemPasswordChar=false;
                }
                else
                {
                    txtContrasena.UseSystemPasswordChar = true;
                    txtRepetirContrasena.UseSystemPasswordChar = true;
                }
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Gray;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.Silver;
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "0999999999")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.Gray;
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "0999999999";
                txtCedula.ForeColor = Color.Silver;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "📩 Ejemplo@gmail.com")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Gray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "📩 Ejemplo@gmail.com";
                txtCorreo.ForeColor = Color.Silver;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "🔑 Contrasena")
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

        private void txtRepetirContrasena_Enter(object sender, EventArgs e)
        {
            if (txtRepetirContrasena.Text == "🔑 Contrasena")
            {
                txtRepetirContrasena.Text = "";
                txtRepetirContrasena.ForeColor = Color.Silver;
            }
        }

        private void txtRepetirContrasena_Leave(object sender, EventArgs e)
        {
            if (txtRepetirContrasena.Text == "")
            {
                txtRepetirContrasena.Text = "🔑 Contrasena";
                txtRepetirContrasena.ForeColor = Color.Silver;
            }
        }
    }
}
