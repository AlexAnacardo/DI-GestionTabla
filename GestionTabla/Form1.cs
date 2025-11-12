using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.clientesDataSet.Clientes);

            //Al cargar el formulario se entra por defecto en modo consulta
            this.DatosCliente.Enabled = false;
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientesDataSet);

        }

        private void imagenPictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagenPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                imagenPictureBox.Image = null;
            }
        }

        private void imagenPictureBox_MouseEnter(object sender, EventArgs e)
        {
             imagenPictureBox.Cursor = Cursors.Hand;
        }

        private void imagenPictureBox_MouseLeave(object sender, EventArgs e)
        {
            imagenPictureBox.Cursor = Cursors.Default;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text.Equals("") | telefonoTextBox.Text.Equals("") | direccionTextBox.Text.Equals(""))
            {
                MessageBox.Show("Debe introducir todos los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (nombreTextBox.Text.Equals(""))
                {
                    errorProvider1.SetError(nombreTextBox, "Debe introducir el nombre");
                }
                else if(telefonoTextBox.Text.Equals(""))
                {
                    errorProvider1.SetError(telefonoTextBox, "Debe introducir el isbn");
                }
                else
                {
                    errorProvider1.SetError(direccionTextBox, "Debe introducir la dirección");
                }
            }
            else
            {
                clientesBindingSource.EndEdit();
                botonAniadir.Enabled = true;
                this.botonBorrar.Enabled = true;
                this.botonEditar.Enabled = true;
                this.botonGuardar.Enabled = true;
                this.DatosCliente.Enabled = false;
                statusStrip1.Text = "Terminado";
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.CancelEdit();
            botonAniadir.Enabled = true;
            this.botonBorrar.Enabled = true;
            this.botonEditar.Enabled = true;
            this.botonGuardar.Enabled = true;
            this.DatosCliente.Enabled = false;
            errorProvider1.Clear();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            this.DatosCliente.Enabled = true;
            this.botonAniadir.Enabled = false;
            this.botonBorrar.Enabled = false;
            this.botonEditar.Enabled = false;
            this.botonGuardar.Enabled = false;
        }

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nombreTextBox.Text.Equals(""))
            {
                errorProvider1.SetError(nombreTextBox, "Debe introducir el titulo");
            }
            else
            {
                errorProvider1.SetError(nombreTextBox, "");
            }
        }

        private void direccionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (direccionTextBox.Text.Equals(""))
            {
                errorProvider1.SetError(direccionTextBox, "Debe introducir la direccion");
            }
            else
            {
                errorProvider1.SetError(direccionTextBox, "");
            }
        }

        private void telefonoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (telefonoTextBox.Text.Equals(""))
            {
                errorProvider1.SetError(telefonoTextBox, "Debe introducir el telefono");
            }
            else
            {
                errorProvider1.SetError(telefonoTextBox, "");
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(clientesDataSet);

            statusStrip1.Text = "Datos guardados";
        }

        private void botonAniadir_Click(object sender, EventArgs e)
        {
            clientesBindingSource.AddNew();
            this.DatosCliente.Enabled = true;
            this.botonAniadir.Enabled = false;
            this.botonBorrar.Enabled = false;
            this.botonEditar.Enabled = false;
            this.botonGuardar.Enabled = false;
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Borrar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                clientesBindingSource.RemoveCurrent();

                statusStrip1.Text = "Libro borrado";
            }   
        }
    }
}
