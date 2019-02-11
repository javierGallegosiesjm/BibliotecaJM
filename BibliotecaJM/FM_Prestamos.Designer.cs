namespace BibliotecaJM
{
    partial class FM_Prestamos
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
            System.Windows.Forms.Label id_lec_preLabel;
            System.Windows.Forms.Label id_lib_preLabel;
            System.Windows.Forms.Label fecha_presta_preLabel;
            System.Windows.Forms.Label fecha_devol_preLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dS_LibrosPrestados = new BibliotecaJM.DS_LibrosPrestados();
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbIDLec = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bId = new System.Windows.Forms.Button();
            this.bNombre = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bIdentificador = new System.Windows.Forms.Button();
            this.bTitulo = new System.Windows.Forms.Button();
            this.bAutor = new System.Windows.Forms.Button();
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPrestamo = new System.Windows.Forms.Button();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.librosPrestadosTableAdapter = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager();
            this.dS_Prestamos = new BibliotecaJM.DS_Prestamos();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new BibliotecaJM.DS_PrestamosTableAdapters.prestamosTableAdapter();
            this.tableAdapterManager1 = new BibliotecaJM.DS_PrestamosTableAdapters.TableAdapterManager();
            this.id_lec_preTextBox = new System.Windows.Forms.TextBox();
            this.id_lib_preTextBox = new System.Windows.Forms.TextBox();
            this.fecha_presta_preDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_devol_preDateTimePicker = new System.Windows.Forms.DateTimePicker();
            id_lec_preLabel = new System.Windows.Forms.Label();
            id_lib_preLabel = new System.Windows.Forms.Label();
            fecha_presta_preLabel = new System.Windows.Forms.Label();
            fecha_devol_preLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Prestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_lec_preLabel);
            this.groupBox1.Controls.Add(this.id_lec_preTextBox);
            this.groupBox1.Controls.Add(id_lib_preLabel);
            this.groupBox1.Controls.Add(this.id_lib_preTextBox);
            this.groupBox1.Controls.Add(fecha_presta_preLabel);
            this.groupBox1.Controls.Add(this.fecha_presta_preDateTimePicker);
            this.groupBox1.Controls.Add(fecha_devol_preLabel);
            this.groupBox1.Controls.Add(this.fecha_devol_preDateTimePicker);
            this.groupBox1.Controls.Add(this.bNombre);
            this.groupBox1.Controls.Add(this.bId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.tbIDLec);
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dS_LibrosPrestados
            // 
            this.dS_LibrosPrestados.DataSetName = "DS_LibrosPrestados";
            this.dS_LibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.dS_LibrosPrestados;
            // 
            // librosPrestadosDataGridView
            // 
            this.librosPrestadosDataGridView.AllowUserToResizeRows = false;
            this.librosPrestadosDataGridView.AutoGenerateColumns = false;
            this.librosPrestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosPrestadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(51, 314);
            this.librosPrestadosDataGridView.MultiSelect = false;
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.RowHeadersVisible = false;
            this.librosPrestadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(415, 293);
            this.librosPrestadosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_lib";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.HeaderText = "titulo_lib";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.HeaderText = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bPrestamo);
            this.groupBox2.Controls.Add(this.librosDataGridView);
            this.groupBox2.Controls.Add(this.bAutor);
            this.groupBox2.Controls.Add(this.bTitulo);
            this.groupBox2.Controls.Add(this.bIdentificador);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(472, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 633);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tbIDLec
            // 
            this.tbIDLec.Location = new System.Drawing.Point(122, 18);
            this.tbIDLec.Name = "tbIDLec";
            this.tbIDLec.Size = new System.Drawing.Size(171, 20);
            this.tbIDLec.TabIndex = 0;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(122, 53);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(171, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 20);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(173, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(173, 147);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(229, 20);
            this.textBox5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Lector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // bId
            // 
            this.bId.Location = new System.Drawing.Point(319, 20);
            this.bId.Name = "bId";
            this.bId.Size = new System.Drawing.Size(96, 23);
            this.bId.TabIndex = 12;
            this.bId.Text = "Buscar";
            this.bId.UseVisualStyleBackColor = true;
            // 
            // bNombre
            // 
            this.bNombre.Location = new System.Drawing.Point(319, 50);
            this.bNombre.Name = "bNombre";
            this.bNombre.Size = new System.Drawing.Size(96, 23);
            this.bNombre.TabIndex = 13;
            this.bNombre.Text = "Buscar";
            this.bNombre.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Identificador";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Titulo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Autor";
            // 
            // bIdentificador
            // 
            this.bIdentificador.Location = new System.Drawing.Point(439, 19);
            this.bIdentificador.Name = "bIdentificador";
            this.bIdentificador.Size = new System.Drawing.Size(75, 23);
            this.bIdentificador.TabIndex = 6;
            this.bIdentificador.Text = "Buscar";
            this.bIdentificador.UseVisualStyleBackColor = true;
            // 
            // bTitulo
            // 
            this.bTitulo.Location = new System.Drawing.Point(439, 81);
            this.bTitulo.Name = "bTitulo";
            this.bTitulo.Size = new System.Drawing.Size(75, 23);
            this.bTitulo.TabIndex = 7;
            this.bTitulo.Text = "Buscar";
            this.bTitulo.UseVisualStyleBackColor = true;
            // 
            // bAutor
            // 
            this.bAutor.Location = new System.Drawing.Point(439, 150);
            this.bAutor.Name = "bAutor";
            this.bAutor.Size = new System.Drawing.Size(75, 23);
            this.bAutor.TabIndex = 8;
            this.bAutor.Text = "Buscar";
            this.bAutor.UseVisualStyleBackColor = true;
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToResizeRows = false;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(18, 205);
            this.librosDataGridView.MultiSelect = false;
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.RowHeadersVisible = false;
            this.librosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosDataGridView.Size = new System.Drawing.Size(508, 374);
            this.librosDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_lib";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn6.HeaderText = "titulo_lib";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn7.HeaderText = "autor_lib";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "seccion_lib";
            this.dataGridViewTextBoxColumn8.HeaderText = "seccion_lib";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn9.HeaderText = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // bPrestamo
            // 
            this.bPrestamo.Location = new System.Drawing.Point(164, 598);
            this.bPrestamo.Name = "bPrestamo";
            this.bPrestamo.Size = new System.Drawing.Size(264, 23);
            this.bPrestamo.TabIndex = 10;
            this.bPrestamo.Text = "REALIZAR PRESTAMO";
            this.bPrestamo.UseVisualStyleBackColor = true;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lectoresTableAdapter = this.lectoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_Prestamos
            // 
            this.dS_Prestamos.DataSetName = "DS_Prestamos";
            this.dS_Prestamos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "prestamos";
            this.prestamosBindingSource.DataSource = this.dS_Prestamos;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.prestamosTableAdapter = this.prestamosTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BibliotecaJM.DS_PrestamosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // id_lec_preLabel
            // 
            id_lec_preLabel.AutoSize = true;
            id_lec_preLabel.Location = new System.Drawing.Point(22, 103);
            id_lec_preLabel.Name = "id_lec_preLabel";
            id_lec_preLabel.Size = new System.Drawing.Size(53, 13);
            id_lec_preLabel.TabIndex = 13;
            id_lec_preLabel.Text = "id lec pre:";
            // 
            // id_lec_preTextBox
            // 
            this.id_lec_preTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "id_lec_pre", true));
            this.id_lec_preTextBox.Location = new System.Drawing.Point(115, 100);
            this.id_lec_preTextBox.Name = "id_lec_preTextBox";
            this.id_lec_preTextBox.Size = new System.Drawing.Size(281, 20);
            this.id_lec_preTextBox.TabIndex = 14;
            // 
            // id_lib_preLabel
            // 
            id_lib_preLabel.AutoSize = true;
            id_lib_preLabel.Location = new System.Drawing.Point(22, 129);
            id_lib_preLabel.Name = "id_lib_preLabel";
            id_lib_preLabel.Size = new System.Drawing.Size(49, 13);
            id_lib_preLabel.TabIndex = 15;
            id_lib_preLabel.Text = "id lib pre:";
            // 
            // id_lib_preTextBox
            // 
            this.id_lib_preTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "id_lib_pre", true));
            this.id_lib_preTextBox.Location = new System.Drawing.Point(115, 126);
            this.id_lib_preTextBox.Name = "id_lib_preTextBox";
            this.id_lib_preTextBox.Size = new System.Drawing.Size(281, 20);
            this.id_lib_preTextBox.TabIndex = 16;
            // 
            // fecha_presta_preLabel
            // 
            fecha_presta_preLabel.AutoSize = true;
            fecha_presta_preLabel.Location = new System.Drawing.Point(22, 156);
            fecha_presta_preLabel.Name = "fecha_presta_preLabel";
            fecha_presta_preLabel.Size = new System.Drawing.Size(87, 13);
            fecha_presta_preLabel.TabIndex = 17;
            fecha_presta_preLabel.Text = "fecha presta pre:";
            // 
            // fecha_presta_preDateTimePicker
            // 
            this.fecha_presta_preDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prestamosBindingSource, "fecha_presta_pre", true));
            this.fecha_presta_preDateTimePicker.Location = new System.Drawing.Point(115, 152);
            this.fecha_presta_preDateTimePicker.Name = "fecha_presta_preDateTimePicker";
            this.fecha_presta_preDateTimePicker.Size = new System.Drawing.Size(281, 20);
            this.fecha_presta_preDateTimePicker.TabIndex = 18;
            // 
            // fecha_devol_preLabel
            // 
            fecha_devol_preLabel.AutoSize = true;
            fecha_devol_preLabel.Location = new System.Drawing.Point(22, 182);
            fecha_devol_preLabel.Name = "fecha_devol_preLabel";
            fecha_devol_preLabel.Size = new System.Drawing.Size(84, 13);
            fecha_devol_preLabel.TabIndex = 19;
            fecha_devol_preLabel.Text = "fecha devol pre:";
            // 
            // fecha_devol_preDateTimePicker
            // 
            this.fecha_devol_preDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prestamosBindingSource, "fecha_devol_pre", true));
            this.fecha_devol_preDateTimePicker.Location = new System.Drawing.Point(115, 178);
            this.fecha_devol_preDateTimePicker.Name = "fecha_devol_preDateTimePicker";
            this.fecha_devol_preDateTimePicker.Size = new System.Drawing.Size(281, 20);
            this.fecha_devol_preDateTimePicker.TabIndex = 20;
            // 
            // FM_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.librosPrestadosDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FM_Prestamos";
            this.Load += new System.EventHandler(this.FM_Prestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Prestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DS_LibrosPrestados dS_LibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button bNombre;
        private System.Windows.Forms.Button bId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbIDLec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bAutor;
        private System.Windows.Forms.Button bTitulo;
        private System.Windows.Forms.Button bIdentificador;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private System.Windows.Forms.Button bPrestamo;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private DS_LectoresTableAdapters.TableAdapterManager tableAdapterManager;
        private DS_Prestamos dS_Prestamos;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private DS_PrestamosTableAdapters.prestamosTableAdapter prestamosTableAdapter;
        private DS_PrestamosTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox id_lec_preTextBox;
        private System.Windows.Forms.TextBox id_lib_preTextBox;
        private System.Windows.Forms.DateTimePicker fecha_presta_preDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_devol_preDateTimePicker;
    }
}
