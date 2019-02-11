using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class Lookup_Provincias : Form
    {
        public int IDProvincia { get; set; }
        public Lookup_Provincias()
        {
            InitializeComponent();
        }


        private void Lookup_Provincias_Load(object sender, EventArgs e)
        {
            
            this.provinciasTableAdapter.Fill(this.dS_Provincias.provincias);

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "")
                this.provinciasTableAdapter.FillByProvincia(this.dS_Provincias.provincias, tbNombre.Text);
        }

        private void provinciasDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int posicion = provinciasBindingSource.Position;
            IDProvincia = dS_Provincias.provincias[posicion].id_pro;
            this.Close();

        }
    }
}
