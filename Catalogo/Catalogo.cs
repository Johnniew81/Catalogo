using System;
using System.Windows.Forms;
using System.IO;

namespace Catalogo
{
    public partial class Catalogo : Form
    {
        string ruta1,ruta2,rutaphp,ruta,sinenom;
        public Catalogo()
        {
            InitializeComponent();            
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            nombrese();
            ruta1 = txtarchivo.Text.ToString();
            ruta2 = ruta+"\\";
            ruta2 += sinenom;
            ruta2 += ".pdf";
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Nombre de archivo vacío", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
                if (File.Exists(ruta1)) {                    
                    File.Move(ruta1, ruta2);
                    rutaphp = ruta + "\\" + sinenom + ".php";
                    using (StreamWriter php = File.CreateText(rutaphp))
                    {
                        php.WriteLine("<?php");
                        php.WriteLine("header('Content-type: application/pdf');");
                        php.WriteLine("header('Content-Disposition: inline; filename=documento.pdf');");
                        php.WriteLine("readfile('"+ sinenom + ".pdf');");
                        php.WriteLine("?>");
                    }
                    resetear();
                    MessageBox.Show("Trabajo realizado");
                }
                else
                {
                    MessageBox.Show("Ruta de archivo vacía", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnexaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog catalogo = new OpenFileDialog();

            if (catalogo.ShowDialog() == DialogResult.OK) { 
                txtarchivo.Text = catalogo.FileName;
                ruta = Path.GetDirectoryName(catalogo.FileName);
            }
        }
        private void resetear()
        {
            ruta = ruta1 = ruta2 = rutaphp = "";
            txtnombre.Text = txtarchivo.Text = "";            
        }
        private void nombrese()
        {
            sinenom = txtnombre.Text;
            sinenom = sinenom.Replace(" ", "-");
        }
    }
}
