using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Lectores : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Lectores()
        {
            InitializeComponent();
        }
        private void ModoBusqueda()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }
        private void ModoEdición()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            this.nombre_lecTextBox.Focus();
        }

        public FM_Lectores(UsuarioActual usuarioActual)
        {
            
            this.usuarioActual = usuarioActual;
            InitializeComponent();
            ModoBusqueda();
        }

      

        private void FM_Lectores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);

        }

        private void bBuscarId_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                int n = 0;
                this.lectoresTableAdapter.FillById(this.dS_Lectores.lectores, int.TryParse(textBox1.Text, out n) ? n : 0);
            }
            else
            {
                this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);
            }
        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            if (textBox2.Text !="")
            {
                
                this.lectoresTableAdapter.FillByNombre(this.dS_Lectores.lectores,textBox2.Text);
            }
            else
            {
                this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);
            }
        }

        private void bInsertar_Click(object sender, EventArgs e)
        {
            this.lectoresBindingSource.AddNew();
            fecha_penalizacion_lecDateTimePicker.Hide();
            ModoEdición();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?",
                "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    lectoresBindingSource.RemoveCurrent();
                    this.lectoresTableAdapter.Update(dS_Lectores.lectores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el borrado" + ex.Message);
                }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            ModoEdición();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                lectoresBindingSource.EndEdit();
                this.lectoresTableAdapter.Update(dS_Lectores.lectores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la escritura de la base de datos." + ex.Message);
            }
            ModoBusqueda();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            lectoresBindingSource.CancelEdit();
            ModoBusqueda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lookup_Provincias lp = new Lookup_Provincias();
            lp.ShowDialog();
            provincia_lecTextBox.Text = lp.IDProvincia.ToString();
        }
    }
}
