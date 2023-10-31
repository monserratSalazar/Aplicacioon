using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación.Aplicacion
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellidos;
            string correo;
            string sexo;
            int edad;
            string diaNacimiento;
            string Contraseña;
            string confirma;

            nombre = textNombre.Text;
            apellidos = textApellido.Text;
            correo = textCorreo.Text;
            sexo = comboBoxSexo.Text;
            edad = int.Parse(textEdad.Text);
            diaNacimiento = dateTimePickerNacimiento.Text;
            Contraseña = textContraseña.Text;
            confirma = textConfContraseña.Text;

            try
            {
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidos) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(sexo) || string.IsNullOrEmpty(diaNacimiento) || string.IsNullOrEmpty(Contraseña) || string.IsNullOrEmpty(confirma))
                {
                    MessageBox.Show("Falta de Datos");
                    return;
                }
                if (edad < 0)
                {
                    MessageBox.Show("Error de Datos");
                    return;
                }
                if (Contraseña.Equals(confirma))
                {
                    Bienvenido home = new Bienvenido();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
