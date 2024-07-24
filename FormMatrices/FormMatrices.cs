using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDescktop_V2.FormMatrices
{
    public partial class FormMatrices : Form
    {
        public FormMatrices()
        {
            InitializeComponent();
        }

        private void FormMatrices_Load(object sender, EventArgs e)
        {
            //RenderMatrixTwoDimensional();
            RenderMatrixThreeDimensional();
        }

        private void RenderMatrixTwoDimensional()
        {
            //[,]   => Indica que es una matriz bi-dimensional
            //new string[4, 3] => Indica que la matriz se va a componer de 4 filas y 3 columnas

            string[,] products = new string[4, 3];

            //La forma de agregar o acceder a sus valores es similar a ubicar un punto en el plano cartesiano..
            //Indicando su posición en el eje Y(filas) y el eje X(columnas)

            products[0, 0] = "Código";
            products[0, 1] = "Producto";
            products[0, 2] = "Precio";

            products[1, 0] = "002";
            products[1, 1] = "Azúcar";
            products[1, 2] = "S/ 1600";

            products[2, 0] = "003";
            products[2, 1] = "Fideo";
            products[2, 2] = "S/ 1400";

            products[3, 0] = "004";
            products[3, 1] = "Leche";
            products[3, 2] = "S/ 1600";

            string value = products[3, 0];
            string dimenssions = (products.Rank).ToString(); //Dimensiones del la matriz = 2

            string message = $"El valor obtenido es {value}, y la matriz es de {dimenssions} dimensiones";

            ShowMessage(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IterateOverBiDimensionalMatrix(products);
            IterateOverMatrixForeach(products);

        }
        private void RenderMatrixThreeDimensional() 
        {

            //string[,,] => Indica una matriz tridimensional

            string[,,] sales = new string[4, 4, 5];

            sales[0, 0, 0] = ""; 
            sales[1, 0, 0] = "Febrero"; 
            sales[3, 0, 0] = "Marzo"; 
            
            sales[1, 2, 0] = "10"; 
            sales[1, 2, 3] = "12"; 
            sales[3, 3, 0] = "15"; 
            sales[3, 3, 3] = "16"; 
            
            sales[1, 0, 2] = "12"; 
            sales[3, 0, 3] = "18"; 
            
            sales[0, 1, 0] = "Leche"; 
            sales[0, 2, 0] = "Arroz"; 
            sales[0, 3, 0] = "Azúcar";

            string value = sales[1, 0, 2];
            string dimenssions = (sales.Rank).ToString(); //Dimensiones del la matriz = 3

            string message = $"El valor obtenido es {value}, y la matriz es de {dimenssions} dimensiones";

            ShowMessage(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IterateOverThreeDimensionalMatrix(sales);
        }

        private void IterateOverBiDimensionalMatrix(string[,] matrix)
        {
            int FirstDimession = matrix.GetLength(0); //Obtiene la primera dimensión (filas)
            int SecondDimession = matrix.GetLength(1); //Obtiene la segunda dimensión (columnas)

            LiData.Items.Clear();

            for (int row = 0; row < FirstDimession; row++) 
            {
                string dataRow = string.Empty;

                for(int col = 0; col < SecondDimession; col++)
                {
                    dataRow += $"{matrix[row, col]} ";
                }

                LiData.Items.Add(dataRow);
            }
        }

        private void IterateOverThreeDimensionalMatrix(string[,,] matrix)
        {
            int FirsDimession = matrix.GetLength(0);
            int SeconDimenssion = matrix.GetLength(1);
            int ThirdDimenssion = matrix.GetLength (2);

            for (int first = 0; first < FirsDimession; first++)
            {
                string RowData = string.Empty;

                for(int second = 0; second < SeconDimenssion; second++)
                {
                    for(int third = 0; third < ThirdDimenssion; third++)
                    {
                        RowData += $"{matrix[first, second, third]} ";
                    }
                }

                LiData.Items.Add(RowData);
            }
        }

        private void IterateOverMatrixForeach(string[,] matrix)
        {
            LiData.Items.Add("");
            LiData.Items.Add("Foreach");

            foreach (var row in matrix) 
            {
                LiData.Items.Add(row);
            }

        }
        private void IterateOverMatrixForeach(string[,,] matrix)
        {
           /* LiData.Items.Add("");
            LiData.Items.Add("Foreach");

            foreach (var row in matrix)
            {
                LiData.Items.Add(row);
            }
            Esto lanza una excepción ya que el bucle foreach esta diseñado para iterar sobre colecciones simples o unidimensionales
            */
        }
        private void ShowMessage(string message, string title, MessageBoxButtons buttons,MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, buttons, icon);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
