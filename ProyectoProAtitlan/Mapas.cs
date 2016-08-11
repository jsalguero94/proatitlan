using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CefSharp;
//using CefSharp.WinForms;


namespace ProyectoProAtitlan
{
    public partial class Mapas : Form
    {
       // public ChromiumWebBrowser chromeBrowser;
        public Mapas()
        {
            InitializeComponent();
            this.webBrowser1.Navigate("https://www.google.com.gt/maps/place/Lago+de+Atitl%C3%A1n,+Guatemala/data=!4m2!3m1!1s0x85894ac7c083b493:0xa6e33f7d6b54910?sa=X&ved=0ahUKEwi5rY3JxLXOAhWFPxoKHWY5CRAQ8gEIHTAA");
            //https://www.google.com.gt/maps/place/Santa+Cruz+la+Laguna/@14.7430263,-91.2131043,15z/data=!3m1!4b1!4m5!3m4!1s0x85894b514cc739fd:0xfb096e57fe425f01!8m2!3d14.7424299!4d-91.205492
            //https://www.google.com.gt/maps/place/Lago+de+Atitl%C3%A1n,+Guatemala/data=!4m2!3m1!1s0x85894ac7c083b493:0xa6e33f7d6b54910?sa=X&ved=0ahUKEwi5rY3JxLXOAhWFPxoKHWY5CRAQ8gEIHTAA
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cef.Shutdown();
           // this.webBrowser1.
            Form1 n = new Form1();
            n.Show();
            this.Close();
        }
        public void InitializeChromium()
        {
            //try
            //{
            //    CefSettings settings = new CefSettings();
            //    // Initialize cef with the provided settings
            //    Cef.Initialize(settings);
            //    // Create a browser component
            //    chromeBrowser = new ChromiumWebBrowser("http://ourcodeworld.com");
            //    // Add it to the form and fill it to the form window.
            //    this.Controls.Add(chromeBrowser);
            //    chromeBrowser.Dock = DockStyle.Fill;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());

            //}
        }

        private void Mapas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cef.Shutdown();
        }

        private void Mapas_Load(object sender, EventArgs e)
        {
          //  InitializeChromium();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seleccion_Mapas n = new Seleccion_Mapas();
            n.Show();
            this.Close();
        }
    }
}
