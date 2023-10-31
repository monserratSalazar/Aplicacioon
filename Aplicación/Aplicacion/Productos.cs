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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //Referencia a un renglon DataGridView
                DataGridViewRow renglon = (DataGridViewRow)dataEstudiante.Rows[0].Clone();
                renglon.Cells[0].Value = textBox1.Text; //Primera Columna
                renglon.Cells[1].Value = textBox2.Text; //Segunda columna
                renglon.Cells[2].Value = textBox3.Text;//Tercera Columna
                renglon.Cells[3].Value = textBox4.Text;//Tercera Columna
                renglon.Cells[4].Value = dateTimePicker1.Text;//Cuarta Columna
                renglon.Cells[5].Value = dateTimePicker2.Text;//Quinta Columna
                renglon.Cells[6].Value = dateTimePicker3.Text;//Quinta Columna
                dataEstudiante.Rows.Add(renglon); //Agregando renglon
            }
            catch (Exception ex) //En caso que ocurra un error
            {
                MessageBox.Show(ex.Message,
                "Agregando Estudiante",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Deseas eliminar el registro?";
            string titulo = "Eliminando el registro"; //título del cuadro de diálogo
            if (!(dataEstudiante.CurrentRow is null)) ; //En caso que no exista renglón seleccionado DataridVien
            {
                //Cuadro de diálogo con botónes Si o No
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataEstudiante.Rows.Remove(dataEstudiante.CurrentRow);//Eliminarelrenglón
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Eliminado Estudiante",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un renglón", "Eliminando estudiante",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataEstudiante.SelectedRows.Count < -0)//En caso que no exista renglón seleccionado
            {
                MessageBox.Show("Debes seleccionar un renglón", "Modificando Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Copiar los valores de datagridview a las cajas de texto
                textBox1.Text = dataEstudiante.CurrentRow.Cells["NombreProducto"].Value.ToString();
                textBox2.Text = dataEstudiante.CurrentRow.Cells["Material"].Value.ToString();
                textBox3.Text = dataEstudiante.CurrentRow.Cells["Lugar"].Value.ToString();
                textBox4.Text = dataEstudiante.CurrentRow.Cells["Ingrediente"].Value.ToString();
                dateTimePicker1.Text = dataEstudiante.CurrentRow.Cells["FechaElaboracion"].Value.ToString();
                dateTimePicker2.Text = dataEstudiante.CurrentRow.Cells["FechaCaducidad"].Value.ToString();
                dateTimePicker3.Text = dataEstudiante.CurrentRow.Cells["FechaLanzamiento"].Value.ToString();
            }
        }
    }
}
