using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDescktop_V2.FormStringFunctions
{
    public partial class FormStringFunctions : Form
    {
        public FormStringFunctions()
        {
            InitializeComponent();
        }
        
        //Funciones básicas para el tipo string//
        private void BtnSubstring_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtOriginal.Text)) 
            { 
                ShowMessage("Debes ingresar un texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                if (TxtOriginal.Text.Length <= 4) 
                {
                    ShowMessage("El texto debe tener una longitud mayor a 4 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    TextResult.Text = TxtOriginal.Text.Substring(0, 4); // 0 es la posición en que inicia, 4 indica la longitud de caracteres
                }

            }
        }

        private void BtnToUpper_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtOriginal.Text))
                ShowMessage("Debes ingresar un texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
                TextResult.Text = TxtOriginal.Text.ToUpper().Trim(); //Transforma el texto a mayúsculas y elimina los espacios en blanco a los extremos.
        }

        private void BtnTrim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtOriginal.Text))
                ShowMessage("Debes ingresar un texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                TextResult.Text = TxtOriginal.Text.Trim(); //Elimina los espacios a los lados
        }

        private void BtnToLower_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtOriginal.Text))
                ShowMessage("Debes ingresar un texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                TextResult.Text = TxtOriginal.Text.ToLower().Trim(); //Transforma el texto a minúsculas y elimina los espacios en blanco a los extremos.
        }

        private void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, buttons, icon);
        }
    }
}
