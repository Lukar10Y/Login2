using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDockUp
{
    public partial class FormVender : Form
    {
        public FormVender()
        {
            InitializeComponent();
        }

        private void FormVender_Load(object sender, EventArgs e)
        {
            cbCategoria.SelectedIndex = 0;
            dgvProductos.Rows.Add(9);
            Random NumeroRandom= new Random();
            List<Software> list = new List<Software>();
            Funcion.LlenarValores(NumeroRandom, list, 10);
            for(int i = 0; i<dgvProductos.Rows.Count; i++)
            {
                for(int j = 0; j<dgvProductos.Columns.Count; j++)
                {
                    dgvProductos[j,i].Value = list[i].Nombre;
                }
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
