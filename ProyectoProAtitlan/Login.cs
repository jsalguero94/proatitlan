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
    public partial class Login : Form
    {
        Point FormPosition;
        Boolean mouseAction;
        public Login()
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
         //NO USAR   
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //NO USAR
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seleccion_Mapas n = new Seleccion_Mapas();
            n.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea salir del programa", "Advertencia", MessageBoxButtons.OKCancel)==DialogResult.OK)

            {
                Application.Exit();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                label1.Text = DateTime.Now.ToLongTimeString();
            
            }
    }
}
