using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDescktop_V2.FormFunctions
{
    public partial class FormFunctions : Form
    {
        public FormFunctions()
        {
            InitializeComponent();
        }

        private void BtnGreet_Click(object sender, EventArgs e)
        {
            Greet();
        }

        private void BtnGreetWithName_Click(object sender, EventArgs e)
        {
            string TextName = TxtName.Text;
            Greet(TextName); //TextName es enviado como argumento al método Greet que recibe como parámetro un string
        }

        //Función sin retorno
        //Void indica que no tiene retorno
        //No tiene ningún parámetro
        private void Greet()
        {
            MessageBox.Show("Hola como estás?","Saludo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //Tiene como parámetro name del tipo string
        private void Greet(string name) //name es un parámetro
        {
            if (string.IsNullOrWhiteSpace(name)) {
                MessageBox.Show($"Necesitas ingresar el nombre", "Sin nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

               MessageBox.Show($"Hola {name}, como estás?", "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
