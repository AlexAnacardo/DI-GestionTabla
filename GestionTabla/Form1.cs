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

            this.botonAceptar.BackgroundImage = GestionTabla.Properties.Resources.botonConfirmarD;
            this.botonCancelar.BackgroundImage = GestionTabla.Properties.Resources.botonCancelarD;

            toolStripStatusLabel1.Text = "";

            comboBoxFiltro.SelectedIndex = 0;

            toolTip1.SetToolTip(this.botonInicio, "Ir al primer registro de la tabla");
            toolTip1.SetToolTip(this.botonAnterior, "Ir al anterior registro de la tabla");
            toolTip1.SetToolTip(this.botonSiguiente, "Ir al siguiente registro de la tabla");
            toolTip1.SetToolTip(this.botonFinal, "Ir al último registro de la tabla");
            toolTip1.SetToolTip(this.botonAniadir, "Añadir un registro a la tabla");
            toolTip1.SetToolTip(this.botonBorrar, "Elimina el registro actual de la tabla");
            toolTip1.SetToolTip(this.botonEditar, "Edita el registro actual de la tabla");
            toolTip1.SetToolTip(this.botonGuardar, "Guarda los cambios realizados");
            toolTip1.SetToolTip(this.comboBoxFiltro, "Campo que se usará para filtrar la busqueda");
            toolTip1.SetToolTip(this.textBoxFiltro, "Cadena de texto a buscar en el campo especificado");
            toolTip1.SetToolTip(this.botonBuscar, "Buscar un registro en la tabla mediante la cadena y campo especificado");
            toolTip1.SetToolTip(this.id_ClienteLabel1, "ID Único del usuario");
            toolTip1.SetToolTip(this.nombreTextBox, "Campo nombre del usuario (Obligatorio)");
            toolTip1.SetToolTip(this.apellidosTextBox, "Campo apellidos del usuario");
            toolTip1.SetToolTip(this.fechaNacTimePicker, "Campo fecha de nacimiento del usuario");
            toolTip1.SetToolTip(this.direccionTextBox, "Campo dirección del usuario (Obligatorio)");
            toolTip1.SetToolTip(this.telefonoTextBox, "Campo télefono del usuario (Campo obligatorio, debe consistir de 9 números enteros)");
            toolTip1.SetToolTip(this.correoTextBox, "Campo correo electrónico del usuario (Opcional, pero de introducirse debe terminar en @gmail.com/@gmail.es/@outlook.com/@outlook.es");
            toolTip1.SetToolTip(this.imagenPictureBox, "Campo imagen del usuario");
            toolTip1.SetToolTip(this.botonAceptar, "Añade los datos introducidos a la tabla de usuarios (Si pasan la validación)");
            toolTip1.SetToolTip(this.botonCancelar, "Cancela la operación de añadir un usuario a la tabla");
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
            if (!Regex.IsMatch(telefonoTextBox.Text, @"^[0-9]{9}$", RegexOptions.IgnoreCase))
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
                this.comboBoxFiltro.Enabled = true;               
                this.textBoxFiltro.Enabled = true;
                this.botonBuscar.Enabled = true;                
                this.botonInicio.Enabled = true;                
                this.botonAnterior.Enabled = true;                
                this.botonSiguiente.Enabled = true;                
                this.botonFinal.Enabled = true;

                this.DatosCliente.Enabled = false;

                this.botonAceptar.BackgroundImage = GestionTabla.Properties.Resources.botonConfirmarD;
                this.botonCancelar.BackgroundImage = GestionTabla.Properties.Resources.botonCancelarD;
                this.botonAniadir.BackgroundImage = GestionTabla.Properties.Resources.botonAniadirE;
                this.botonBorrar.BackgroundImage = GestionTabla.Properties.Resources.botonEliminarE;
                this.botonEditar.BackgroundImage = GestionTabla.Properties.Resources.botonEditarE;
                this.botonGuardar.BackgroundImage = GestionTabla.Properties.Resources.botonGuardarE;
                this.botonBuscar.BackgroundImage = GestionTabla.Properties.Resources.botonBuscarE;
                this.botonInicio.BackgroundImage = GestionTabla.Properties.Resources.botonPrincipioE;
                this.botonAnterior.BackgroundImage = GestionTabla.Properties.Resources.botonAnteriorE;
                this.botonSiguiente.BackgroundImage = GestionTabla.Properties.Resources.botonSiguienteE;
                this.botonFinal.BackgroundImage = GestionTabla.Properties.Resources.botonFinalE;
                this.botonImprimir.BackgroundImage = GestionTabla.Properties.Resources.botonImprimirE;

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
            this.comboBoxFiltro.Enabled = true;
            this.textBoxFiltro.Enabled = true;
            this.botonBuscar.Enabled = true;
            this.botonInicio.Enabled = true;
            this.botonAnterior.Enabled = true;
            this.botonSiguiente.Enabled = true;
            this.botonFinal.Enabled = true;

            this.DatosCliente.Enabled = false;

            this.botonAceptar.BackgroundImage = GestionTabla.Properties.Resources.botonConfirmarD;
            this.botonCancelar.BackgroundImage = GestionTabla.Properties.Resources.botonCancelarD;
            this.botonAniadir.BackgroundImage = GestionTabla.Properties.Resources.botonAniadirE;
            this.botonBorrar.BackgroundImage = GestionTabla.Properties.Resources.botonEliminarE;
            this.botonEditar.BackgroundImage = GestionTabla.Properties.Resources.botonEditarE;
            this.botonGuardar.BackgroundImage = GestionTabla.Properties.Resources.botonGuardarE;
            this.botonBuscar.BackgroundImage = GestionTabla.Properties.Resources.botonBuscarE;
            this.botonInicio.BackgroundImage = GestionTabla.Properties.Resources.botonPrincipioE;
            this.botonAnterior.BackgroundImage = GestionTabla.Properties.Resources.botonAnteriorE;
            this.botonSiguiente.BackgroundImage = GestionTabla.Properties.Resources.botonSiguienteE;
            this.botonFinal.BackgroundImage = GestionTabla.Properties.Resources.botonFinalE;
            this.botonImprimir.BackgroundImage = GestionTabla.Properties.Resources.botonImprimirE;
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
            this.comboBoxFiltro.Enabled = false;
            this.textBoxFiltro.Enabled = false;
            this.botonBuscar.Enabled = false;
            this.botonInicio.Enabled = false;
            this.botonAnterior.Enabled = false;
            this.botonSiguiente.Enabled = false;
            this.botonFinal.Enabled = false;

            this.botonAceptar.BackgroundImage = GestionTabla.Properties.Resources.botonConfirmarE;
            this.botonCancelar.BackgroundImage = GestionTabla.Properties.Resources.botonCancelarE;
            this.botonAniadir.BackgroundImage = GestionTabla.Properties.Resources.botonAniadirD;
            this.botonBorrar.BackgroundImage = GestionTabla.Properties.Resources.botonEliminarD;
            this.botonEditar.BackgroundImage = GestionTabla.Properties.Resources.botonEditarD;
            this.botonGuardar.BackgroundImage = GestionTabla.Properties.Resources.botonGuardarD;
            this.botonBuscar.BackgroundImage = GestionTabla.Properties.Resources.botonBuscarD;
            this.botonInicio.BackgroundImage = GestionTabla.Properties.Resources.botonPrincipioD;
            this.botonAnterior.BackgroundImage = GestionTabla.Properties.Resources.botonAnteriorD;
            this.botonSiguiente.BackgroundImage = GestionTabla.Properties.Resources.botonSiguienteD;
            this.botonFinal.BackgroundImage = GestionTabla.Properties.Resources.botonFinalD;
            this.botonImprimir.BackgroundImage = GestionTabla.Properties.Resources.botonImprimirD;
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
            else if (!Regex.IsMatch(telefonoTextBox.Text, @"^[0-9]{9}$", RegexOptions.IgnoreCase))
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
            this.comboBoxFiltro.Enabled = false;
            this.textBoxFiltro.Enabled = false;
            this.botonBuscar.Enabled = false;
            this.botonInicio.Enabled = false;
            this.botonAnterior.Enabled = false;
            this.botonSiguiente.Enabled = false;
            this.botonFinal.Enabled = false;

            this.botonAceptar.BackgroundImage = GestionTabla.Properties.Resources.botonConfirmarE;
            this.botonCancelar.BackgroundImage = GestionTabla.Properties.Resources.botonCancelarE;
            this.botonAniadir.BackgroundImage = GestionTabla.Properties.Resources.botonAniadirD;
            this.botonBorrar.BackgroundImage = GestionTabla.Properties.Resources.botonEliminarD;
            this.botonEditar.BackgroundImage = GestionTabla.Properties.Resources.botonEditarD;
            this.botonGuardar.BackgroundImage = GestionTabla.Properties.Resources.botonGuardarD;
            this.botonBuscar.BackgroundImage = GestionTabla.Properties.Resources.botonBuscarD;
            this.botonInicio.BackgroundImage = GestionTabla.Properties.Resources.botonPrincipioD;
            this.botonAnterior.BackgroundImage = GestionTabla.Properties.Resources.botonAnteriorD;
            this.botonSiguiente.BackgroundImage = GestionTabla.Properties.Resources.botonSiguienteD;
            this.botonFinal.BackgroundImage = GestionTabla.Properties.Resources.botonFinalD;
            this.botonImprimir.BackgroundImage = GestionTabla.Properties.Resources.botonImprimirD;
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

        private void botonImprimir_Click(object sender, EventArgs e)
        {
            printDialog1.AllowPrintToFile = false;
            printDialog1.AllowSelection = false;
            printDialog1.AllowSomePages = false;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;

                try
                {
                    printDocument1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de impresion", "Imprimir imagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("Nombre: "+this.nombreTextBox.Text, this.Font, Brushes.Black, 0, 0);
            e.Graphics.DrawString("Apellidos: " + this.apellidosTextBox.Text, this.Font, Brushes.Black, 0, 20);
            e.Graphics.DrawString("Fecha nacimiento: " + this.fechaNacTimePicker.Text, this.Font, Brushes.Black, 0, 40);
            e.Graphics.DrawString("Direccion: " + this.direccionTextBox.Text, this.Font, Brushes.Black, 0, 60);
            e.Graphics.DrawString("Telefono: " + this.telefonoTextBox.Text, this.Font, Brushes.Black, 0, 80);
            e.Graphics.DrawString("Correo: " + this.correoTextBox.Text, this.Font, Brushes.Black, 0, 100);
              

            if (imagenPictureBox.Image != null)
            {
                e.Graphics.DrawImage(imagenPictureBox.Image, 20, 120, 200, 400);
            }
            
            
        }
    }
}
