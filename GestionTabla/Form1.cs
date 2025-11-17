using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            toolStripStatusLabel1.Text = "";

            comboBoxFiltro.SelectedIndex = 0;
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
                if (nombreTextBox.Text.Equals(""))
                {
                    errorProvider1.SetError(nombreTextBox, "Debe introducir el nombre");
                }
                if(telefonoTextBox.Text.Equals(""))
                {
                    errorProvider1.SetError(telefonoTextBox, "Debe introducir el isbn");
                }
                if(direccionTextBox.Text.Equals(""))
                {
                    errorProvider1.SetError(direccionTextBox, "Debe introducir la dirección");
                }            
                MessageBox.Show("Debe introducir todos los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel1.Text = "Hay 1 o mas campos erroneos";
            }
            else if (correoTextBox.Text != "" && !correoTextBox.Text.EndsWith("@gmail.com") && !correoTextBox.Text.EndsWith("@gmail.es") && !correoTextBox.Text.EndsWith("@outlook.com") && !correoTextBox.Text.EndsWith("@outlook.es"))
            {
                errorProvider1.SetError(correoTextBox, "El correo electrónico debe acabar en @gmail.com / @gmail.es / @outlook.es / @outlook.com");
                toolStripStatusLabel1.Text = "Hay 1 o mas campos erroneos";
            }
            if (!Regex.IsMatch(telefonoTextBox.Text, "[0-9]9", RegexOptions.IgnoreCase))
            {
                errorProvider1.SetError(telefonoTextBox, "Formato de telefono invalido, debe seguir un formato 123456789");
            }
            else
            {
                clientesBindingSource.EndEdit();
                botonAniadir.Enabled = true;
                this.botonBorrar.Enabled = true;
                this.botonEditar.Enabled = true;
                this.botonGuardar.Enabled = true;
                this.DatosCliente.Enabled = false;
                errorProvider1.Clear();

                toolStripStatusLabel1.Text = "Cliente añadido";
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
            toolStripStatusLabel1.Text = "Cancelada creacion de cliente";
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
            else if (!Regex.IsMatch(telefonoTextBox.Text, "[0-9]9", RegexOptions.IgnoreCase))
            {
                errorProvider1.SetError(telefonoTextBox, "Formato de telefono invalido, debe seguir un formato 123456789");
            }
            else
            {
                errorProvider1.SetError(telefonoTextBox, "");
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(clientesDataSet);

            toolStripStatusLabel1.Text = "Datos guardados";
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
            if (clientesBindingSource.Count > 0)
            {
                if (MessageBox.Show("Borrar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    clientesBindingSource.RemoveCurrent();

                    toolStripStatusLabel1.Text = "Cliente borrado";
                }
            }  
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(clientesDataSet.GetChanges() is null))
            {
                if (MessageBox.Show("¿Guardar las modificaciones pendientes antes de salir?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.clientesBindingSource.CancelEdit();
                    this.tableAdapterManager.UpdateAll(this.clientesDataSet);
                }
            }
        }

        private void correoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (correoTextBox.Text != "" && !correoTextBox.Text.EndsWith("@gmail.com") && !correoTextBox.Text.EndsWith("@gmail.es") && !correoTextBox.Text.EndsWith("@outlook.com") && !correoTextBox.Text.EndsWith("@outlook.es"))
            {
                errorProvider1.SetError(correoTextBox, "El correo electrónico debe acabar en @gmail.com / @gmail.es / @outlook.es / @outlook.com");
            }
            else
            {
                errorProvider1.SetError(correoTextBox, "");
            }
        }

        private void botonInicio_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveFirst();
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MovePrevious();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveNext();
        }

        private void botonFinal_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveLast();
        }

        private void clientesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void clientesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            labelPaginacion.Text = "Cliente " + (clientesBindingSource.Position + 1) + " de " + clientesBindingSource.Count;
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            String campoBusqueda = textBoxFiltro.Text;
            String filtroBusqueda = comboBoxFiltro.Text;


            int indice = -1;

            switch (filtroBusqueda)
            {
                case "Id cliente":
                    try
                    {
                        indice = clientesBindingSource.Find("Id_Cliente", campoBusqueda);
                    }
                    catch(System.FormatException ex)
                    {
                        MessageBox.Show("El formato de ID de cliente introducido es incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                break;

                case "Nombre":
                    indice = clientesBindingSource.Find("Nombre_Cliente", campoBusqueda);
                break;

                case "Apellidos":
                    indice = clientesBindingSource.Find("Apellidos_Cliente", campoBusqueda);
                break;

                case "Fecha nacimiento":
                    indice = clientesBindingSource.Find("Fecha_Nacimiento", campoBusqueda);
                break;

                case "Direccion":
                    indice = clientesBindingSource.Find("Direccion", campoBusqueda);
                break;

                case "Telefono":
                    indice = clientesBindingSource.Find("Telefono", campoBusqueda);
                break;

                case "Correo electronico":
                    indice = clientesBindingSource.Find("Correo_Electronico", campoBusqueda);
                break;

                default:
                    
                break;
            }

            if (indice >= 0)
            {
                clientesBindingSource.Position = indice;
            }
            else
            {
                MessageBox.Show("No se encontró ningún registro con el campo especificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
