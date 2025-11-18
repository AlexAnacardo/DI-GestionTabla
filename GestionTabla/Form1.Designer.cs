namespace GestionTabla
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_ClienteLabel;
            System.Windows.Forms.Label nombre_ClienteLabel;
            System.Windows.Forms.Label apellidos_ClienteLabel;
            System.Windows.Forms.Label fecha_NacimientoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correo_ElectronicoLabel;
            System.Windows.Forms.Label imagenLabel;
            this.id_ClienteLabel1 = new System.Windows.Forms.Label();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new GestionTabla.ClientesDataSet();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacTimePicker = new System.Windows.Forms.DateTimePicker();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.DatosCliente = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clientesTableAdapter = new GestionTabla.ClientesDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new GestionTabla.ClientesDataSetTableAdapters.TableAdapterManager();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.labelPaginacion = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.botonImprimir = new System.Windows.Forms.Button();
            this.botonFinal = new System.Windows.Forms.Button();
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.botonAnterior = new System.Windows.Forms.Button();
            this.botonInicio = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.botonAniadir = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            id_ClienteLabel = new System.Windows.Forms.Label();
            nombre_ClienteLabel = new System.Windows.Forms.Label();
            apellidos_ClienteLabel = new System.Windows.Forms.Label();
            fecha_NacimientoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correo_ElectronicoLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            this.DatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Location = new System.Drawing.Point(107, 38);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(54, 13);
            id_ClienteLabel.TabIndex = 1;
            id_ClienteLabel.Text = "Id Cliente:";
            // 
            // nombre_ClienteLabel
            // 
            nombre_ClienteLabel.AutoSize = true;
            nombre_ClienteLabel.Location = new System.Drawing.Point(107, 83);
            nombre_ClienteLabel.Name = "nombre_ClienteLabel";
            nombre_ClienteLabel.Size = new System.Drawing.Size(51, 13);
            nombre_ClienteLabel.TabIndex = 3;
            nombre_ClienteLabel.Text = "Nombre *";
            // 
            // apellidos_ClienteLabel
            // 
            apellidos_ClienteLabel.AutoSize = true;
            apellidos_ClienteLabel.Location = new System.Drawing.Point(107, 118);
            apellidos_ClienteLabel.Name = "apellidos_ClienteLabel";
            apellidos_ClienteLabel.Size = new System.Drawing.Size(49, 13);
            apellidos_ClienteLabel.TabIndex = 5;
            apellidos_ClienteLabel.Text = "Apellidos";
            // 
            // fecha_NacimientoLabel
            // 
            fecha_NacimientoLabel.AutoSize = true;
            fecha_NacimientoLabel.Location = new System.Drawing.Point(107, 151);
            fecha_NacimientoLabel.Name = "fecha_NacimientoLabel";
            fecha_NacimientoLabel.Size = new System.Drawing.Size(93, 13);
            fecha_NacimientoLabel.TabIndex = 7;
            fecha_NacimientoLabel.Text = "Fecha Nacimiento";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(107, 191);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(59, 13);
            direccionLabel.TabIndex = 9;
            direccionLabel.Text = "Direccion *";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(106, 228);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(56, 13);
            telefonoLabel.TabIndex = 11;
            telefonoLabel.Text = "Telefono *";
            // 
            // correo_ElectronicoLabel
            // 
            correo_ElectronicoLabel.AutoSize = true;
            correo_ElectronicoLabel.Location = new System.Drawing.Point(107, 262);
            correo_ElectronicoLabel.Name = "correo_ElectronicoLabel";
            correo_ElectronicoLabel.Size = new System.Drawing.Size(94, 13);
            correo_ElectronicoLabel.TabIndex = 13;
            correo_ElectronicoLabel.Text = "Correo Electronico";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.Location = new System.Drawing.Point(451, 58);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(42, 13);
            imagenLabel.TabIndex = 15;
            imagenLabel.Text = "Imagen";
            // 
            // id_ClienteLabel1
            // 
            this.id_ClienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Id_Cliente", true));
            this.id_ClienteLabel1.Location = new System.Drawing.Point(167, 38);
            this.id_ClienteLabel1.Name = "id_ClienteLabel1";
            this.id_ClienteLabel1.Size = new System.Drawing.Size(200, 23);
            this.id_ClienteLabel1.TabIndex = 2;
            this.id_ClienteLabel1.Text = "label1";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.clientesDataSet;
            this.clientesBindingSource.CurrentChanged += new System.EventHandler(this.clientesBindingSource_PositionChanged);
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "ClientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nombre_Cliente", true));
            this.nombreTextBox.Location = new System.Drawing.Point(206, 83);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 4;
            this.nombreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreTextBox_Validating);
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Apellidos_Cliente", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(206, 118);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidosTextBox.TabIndex = 6;
            // 
            // fechaNacTimePicker
            // 
            this.fechaNacTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "Fecha_Nacimiento", true));
            this.fechaNacTimePicker.Location = new System.Drawing.Point(206, 151);
            this.fechaNacTimePicker.Name = "fechaNacTimePicker";
            this.fechaNacTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacTimePicker.TabIndex = 8;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(206, 191);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 10;
            this.direccionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.direccionTextBox_Validating);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(206, 228);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 12;
            this.telefonoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telefonoTextBox_Validating);
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Correo_Electronico", true));
            this.correoTextBox.Location = new System.Drawing.Point(206, 262);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(200, 20);
            this.correoTextBox.TabIndex = 14;
            this.correoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.correoTextBox_Validating);
            // 
            // DatosCliente
            // 
            this.DatosCliente.Controls.Add(this.botonCancelar);
            this.DatosCliente.Controls.Add(this.botonAceptar);
            this.DatosCliente.Controls.Add(id_ClienteLabel);
            this.DatosCliente.Controls.Add(this.imagenPictureBox);
            this.DatosCliente.Controls.Add(this.id_ClienteLabel1);
            this.DatosCliente.Controls.Add(imagenLabel);
            this.DatosCliente.Controls.Add(nombre_ClienteLabel);
            this.DatosCliente.Controls.Add(this.correoTextBox);
            this.DatosCliente.Controls.Add(this.nombreTextBox);
            this.DatosCliente.Controls.Add(correo_ElectronicoLabel);
            this.DatosCliente.Controls.Add(apellidos_ClienteLabel);
            this.DatosCliente.Controls.Add(this.telefonoTextBox);
            this.DatosCliente.Controls.Add(this.apellidosTextBox);
            this.DatosCliente.Controls.Add(telefonoLabel);
            this.DatosCliente.Controls.Add(fecha_NacimientoLabel);
            this.DatosCliente.Controls.Add(this.direccionTextBox);
            this.DatosCliente.Controls.Add(this.fechaNacTimePicker);
            this.DatosCliente.Controls.Add(direccionLabel);
            this.DatosCliente.Location = new System.Drawing.Point(12, 68);
            this.DatosCliente.Name = "DatosCliente";
            this.DatosCliente.Size = new System.Drawing.Size(989, 322);
            this.DatosCliente.TabIndex = 17;
            this.DatosCliente.TabStop = false;
            this.DatosCliente.Text = "Datos cliente";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestionTabla.ClientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1013, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(814, 42);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(121, 20);
            this.textBoxFiltro.TabIndex = 9;
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Id cliente",
            "Nombre",
            "Apellidos",
            "Fecha nacimiento",
            "Direccion",
            "Telefono",
            "Correo electrónico"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(814, 8);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltro.TabIndex = 8;
            // 
            // labelPaginacion
            // 
            this.labelPaginacion.AutoSize = true;
            this.labelPaginacion.Location = new System.Drawing.Point(140, 30);
            this.labelPaginacion.Name = "labelPaginacion";
            this.labelPaginacion.Size = new System.Drawing.Size(70, 13);
            this.labelPaginacion.TabIndex = 26;
            this.labelPaginacion.Text = "Cliente x de x";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // botonImprimir
            // 
            this.botonImprimir.BackgroundImage = global::GestionTabla.Properties.Resources.botonImprimirE;
            this.botonImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonImprimir.Location = new System.Drawing.Point(715, 9);
            this.botonImprimir.Name = "botonImprimir";
            this.botonImprimir.Size = new System.Drawing.Size(60, 54);
            this.botonImprimir.TabIndex = 27;
            this.botonImprimir.UseVisualStyleBackColor = true;
            this.botonImprimir.Click += new System.EventHandler(this.botonImprimir_Click);
            // 
            // botonFinal
            // 
            this.botonFinal.BackgroundImage = global::GestionTabla.Properties.Resources.botonFinalE;
            this.botonFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonFinal.Location = new System.Drawing.Point(287, 21);
            this.botonFinal.Name = "botonFinal";
            this.botonFinal.Size = new System.Drawing.Size(50, 30);
            this.botonFinal.TabIndex = 3;
            this.botonFinal.UseVisualStyleBackColor = true;
            this.botonFinal.Click += new System.EventHandler(this.botonFinal_Click);
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.BackgroundImage = global::GestionTabla.Properties.Resources.botonSiguienteE;
            this.botonSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSiguiente.Location = new System.Drawing.Point(231, 21);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(50, 30);
            this.botonSiguiente.TabIndex = 2;
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // botonAnterior
            // 
            this.botonAnterior.BackgroundImage = global::GestionTabla.Properties.Resources.botonAnteriorE;
            this.botonAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAnterior.Location = new System.Drawing.Point(68, 21);
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.Size = new System.Drawing.Size(50, 30);
            this.botonAnterior.TabIndex = 1;
            this.botonAnterior.UseVisualStyleBackColor = true;
            this.botonAnterior.Click += new System.EventHandler(this.botonAnterior_Click);
            // 
            // botonInicio
            // 
            this.botonInicio.BackgroundImage = global::GestionTabla.Properties.Resources.botonPrincipioE;
            this.botonInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonInicio.Location = new System.Drawing.Point(12, 21);
            this.botonInicio.Name = "botonInicio";
            this.botonInicio.Size = new System.Drawing.Size(50, 30);
            this.botonInicio.TabIndex = 0;
            this.botonInicio.UseVisualStyleBackColor = true;
            this.botonInicio.Click += new System.EventHandler(this.botonInicio_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackgroundImage = global::GestionTabla.Properties.Resources.botonBuscarE;
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscar.Location = new System.Drawing.Point(941, 8);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(60, 54);
            this.botonBuscar.TabIndex = 10;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.BackgroundImage = global::GestionTabla.Properties.Resources.botonEliminarE;
            this.botonBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBorrar.Location = new System.Drawing.Point(443, 9);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(60, 54);
            this.botonBorrar.TabIndex = 5;
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // botonAniadir
            // 
            this.botonAniadir.BackgroundImage = global::GestionTabla.Properties.Resources.botonAniadirE;
            this.botonAniadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAniadir.Location = new System.Drawing.Point(377, 9);
            this.botonAniadir.Name = "botonAniadir";
            this.botonAniadir.Size = new System.Drawing.Size(60, 54);
            this.botonAniadir.TabIndex = 4;
            this.botonAniadir.UseVisualStyleBackColor = true;
            this.botonAniadir.Click += new System.EventHandler(this.botonAniadir_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.BackgroundImage = global::GestionTabla.Properties.Resources.botonGuardarE;
            this.botonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonGuardar.Location = new System.Drawing.Point(612, 9);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(60, 54);
            this.botonGuardar.TabIndex = 7;
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.BackgroundImage = global::GestionTabla.Properties.Resources.botonEditarE;
            this.botonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonEditar.Location = new System.Drawing.Point(509, 9);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(60, 54);
            this.botonEditar.TabIndex = 6;
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.BackgroundImage = global::GestionTabla.Properties.Resources.botonCancelarE;
            this.botonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonCancelar.Location = new System.Drawing.Point(831, 133);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(60, 54);
            this.botonCancelar.TabIndex = 18;
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.BackgroundImage = global::GestionTabla.Properties.Resources.botonConfirmarE;
            this.botonAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAceptar.Location = new System.Drawing.Point(735, 133);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(60, 54);
            this.botonAceptar.TabIndex = 17;
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clientesBindingSource, "Imagen", true));
            this.imagenPictureBox.Location = new System.Drawing.Point(503, 58);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(155, 221);
            this.imagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPictureBox.TabIndex = 16;
            this.imagenPictureBox.TabStop = false;
            this.imagenPictureBox.Click += new System.EventHandler(this.imagenPictureBox_Click);
            this.imagenPictureBox.MouseEnter += new System.EventHandler(this.imagenPictureBox_MouseEnter);
            this.imagenPictureBox.MouseLeave += new System.EventHandler(this.imagenPictureBox_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 426);
            this.Controls.Add(this.botonImprimir);
            this.Controls.Add(this.labelPaginacion);
            this.Controls.Add(this.botonFinal);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.botonAnterior);
            this.Controls.Add(this.botonInicio);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonAniadir);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DatosCliente);
            this.Name = "Form1";
            this.Text = "Gestion clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            this.DatosCliente.ResumeLayout(false);
            this.DatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClientesDataSet clientesDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ClientesDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private ClientesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label id_ClienteLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacTimePicker;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.PictureBox imagenPictureBox;
        private System.Windows.Forms.GroupBox DatosCliente;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Button botonAniadir;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.Button botonFinal;
        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.Button botonAnterior;
        private System.Windows.Forms.Button botonInicio;
        private System.Windows.Forms.Label labelPaginacion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button botonImprimir;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

