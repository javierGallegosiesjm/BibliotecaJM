namespace BibliotecaJM
{
    partial class Lookup_Provincias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.provinciasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Provincias = new BibliotecaJM.DS_Provincias();
            this.provinciasTableAdapter = new BibliotecaJM.DS_ProvinciasTableAdapters.provinciasTableAdapter();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).BeginInit();
            this.SuspendLayout();
            // 
            // provinciasDataGridView
            // 
            this.provinciasDataGridView.AllowUserToResizeRows = false;
            this.provinciasDataGridView.AutoGenerateColumns = false;
            this.provinciasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provinciasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.provinciasDataGridView.DataSource = this.provinciasBindingSource;
            this.provinciasDataGridView.Location = new System.Drawing.Point(0, 58);
            this.provinciasDataGridView.MultiSelect = false;
            this.provinciasDataGridView.Name = "provinciasDataGridView";
            this.provinciasDataGridView.RowHeadersVisible = false;
            this.provinciasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.provinciasDataGridView.Size = new System.Drawing.Size(197, 460);
            this.provinciasDataGridView.TabIndex = 1;
            this.provinciasDataGridView.DoubleClick += new System.EventHandler(this.provinciasDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_pro";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_pro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "provincia_pro";
            this.dataGridViewTextBoxColumn2.HeaderText = "provincia_pro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.dS_Provincias;
            // 
            // dS_Provincias
            // 
            this.dS_Provincias.DataSetName = "DS_Provincias";
            this.dS_Provincias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(31, 13);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(137, 10);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(60, 23);
            this.bBuscar.TabIndex = 3;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // Lookup_Provincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 515);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.provinciasDataGridView);
            this.Name = "Lookup_Provincias";
            this.Text = "Lookup_Provincias";
            this.Load += new System.EventHandler(this.Lookup_Provincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provinciasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_Provincias dS_Provincias;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private DS_ProvinciasTableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private System.Windows.Forms.DataGridView provinciasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button bBuscar;
    }
}