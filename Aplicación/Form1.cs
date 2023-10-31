using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicación.Aplicacion;

namespace Aplicación
{
    public partial class Form1 : Form
    {
        private int intentos = 0;
        private const int intentosLimite = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contraseña;
            
            try
            {
                usuario = textUsuario.Text;
                contraseña = textContraseña.Text;
                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Se requiere dato en usuario y/o contraseña");
                    return;
                }else if(textUsuario.TextLength < 4 && textContraseña.TextLength < 4)
                {
                    MessageBox.Show("No puede tener menos de tres caracteres ", "Intenta de nuevo");
                }

                if (usuario.Equals("Monserrat") && contraseña.Equals("monse"))
                {
                    Bienvenido home = new Bienvenido();
                    home.Show();
                }
                else
                {
                    intentos++;
                    if (intentos < intentosLimite)
                    {
                        string message = "Datos Incorrectos" + "\n" +
                        "Intentalo de nuevo ";
                        MessageBox.Show(message);
                    }
                    else
                    {
                        MessageBox.Show("Haz alcanzado el limite de intentos");
                        Application.Exit();
                    }


                }

            }
            catch (Exception error)
            {
               
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse home = new Registrarse();
            home.Show();
        }
    }
}
