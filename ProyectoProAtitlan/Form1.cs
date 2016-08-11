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
    public partial class Form1 : Form
    {
        Point FormPosition;
        Boolean mouseAction;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction==true)
            {
                Location = new Point(Cursor.Position.X - FormPosition.X, Cursor.Position.Y - FormPosition.Y);
           
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            FormPosition = new Point(Cursor.Position.X -Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seleccion_Mapas n = new Seleccion_Mapas();
            n.Show();
            this.Hide();
        }
    }
}
