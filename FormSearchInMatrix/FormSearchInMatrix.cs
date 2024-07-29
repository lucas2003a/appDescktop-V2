using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDescktop_V2.FormSearchInMatrix
{
    public partial class FormSearchInMatrix : Form
    {
        private string[,] products { get; set; }
        public FormSearchInMatrix()
        {
            InitializeComponent();
        }

        private void FormSearchInMatrix_Load(object sender, EventArgs e)
        {
            InicitalizeMatrix();
        }


        private void BtnSearchCode_Click(object sender, EventArgs e)
        {
            string code = TxtCode.Text;
            ValidateTextCode(code);
        }

        /// <summary>
        /// Inicializa los valores de la matriz
        /// </summary>
        private void InicitalizeMatrix()
        {
            this.products = new string[4, 3];

            products[0, 0] = "Código";
            products[0, 1] = "Producto";
            products[0, 2] = "Precio(S/)";

            products[1, 0] = "PR001";
            products[1, 1] = "Arroz";
            products[1, 2] = "3.50";

            products[2, 0] = "PR002";
            products[2, 1] = "Aceite";
            products[2, 2] = "3.80";

            products[3, 0] = "PR003";
            products[3, 1] = "Leche";
            products[3, 2] = "4.00";
        }

        private void ValidateTextCode(string code)
        {
            try
            {
                string TextCode = code.ToUpper();
                Product product = SearchInMatrix(TextCode, this.products); //Crea la instancia del objeto obtenido del método

                if (product != null)
                {
                    TxtProduct.Text = product.Name;
                    TxtPrice.Text = product.Price;
                }
                else
                {
                    ShowMessage("El código no existe en la matriz", "El código no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                ShowMessage(
                    $"{e.Message}\n {e.StackTrace}",
                    $"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        /// <summary>
        /// Busca el código en la matriz y devuelve un objeto
        /// </summary>
        /// <param name="code"></param>
        /// <param name="matrix"></param>
        /// <returns></returns>
        private Product SearchInMatrix(string code, string[,] matrix)
        {
            bool isFind = false;
            int index = 1;
            int lenghRow = matrix.GetLength(0);
            
            for(int i = 1; i < lenghRow; i++)
            {
                if (code.Equals(matrix[i, 0]))
                {
                    isFind = true;
                    index = i;
                    break;
                }

            }

            if (isFind) 
            { 
                string name = matrix[index, 1];
                string price = matrix[index, 2];

                return new Product(code, name, price); //Retorna un objeto (instancia de producto)
            }
            else
            {
                
                return null;
            }
        }

        private void ShowMessage(string messge, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(messge, title, buttons, icon);
        }

        private class Product
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }

            public Product(string code, string name, string price) 
            {
            
                this.Code = code;
                this.Name = name;
                this.Price = price;
            }

        }

    }
}
