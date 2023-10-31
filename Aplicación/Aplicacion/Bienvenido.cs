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
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string registro;
            try
            {
                registro = comboBox1.Text;
                if (registro.Equals("Estudiantes"))
                {
                    FormaEstudiantes home = new FormaEstudiantes();
                    home.Show();
                }
                if (registro.Equals("Empleados"))
                {
                    DatosEmpleados home = new DatosEmpleados();
                    home.Show();
                }
                if (registro.Equals("Productos"))
                {
                    Productos home = new Productos();
                    home.Show();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("");
            }
        }
    }
}
