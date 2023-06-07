using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Catalogo
{
    public partial class Form1 : Form
    {
        string ruta1,ruta2;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {

            ruta1 = txtarchivo.Text.ToString();
            ruta2 += txtnombre.Text.ToString();

            if (File.Exists(ruta2))
                    File.Delete(ruta2);
                File.Move(ruta1, ruta2);
                Console.WriteLine("{0} fue movido a {1}.", ruta1, ruta2);
                if (File.Exists(ruta1))
                {
                    Console.WriteLine("El archivo original sigue existiendo.");
                }
                else
                {
                    Console.WriteLine("El archivo original ya no existe.");
                }
            
        }

        private void btnexaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog catalogo = new OpenFileDialog();

            if (catalogo.ShowDialog() == DialogResult.OK) { 
                txtarchivo.Text = catalogo.FileName;
                ruta2 = Path.GetDirectoryName(catalogo.FileName);
            }
        }
    }
}
