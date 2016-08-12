using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoProAtitlan
{
    public partial class Seleccion_Mapas : Form
    {
        Dir_Mapas direccion;
        public Seleccion_Mapas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //direccion.direccion =
            Mapas n = new Mapas();
            n.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login n = new Login();
            n.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login n = new Login();
            n.Show();
            this.Close();
        }
        }
}
