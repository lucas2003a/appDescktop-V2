using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDescktop_V2.FormSortingArrays
{
    public partial class FormSortingArrays : Form
    {
        private object listData; // T es un dato genérico (flexible)

        public void Setlist(object array)
        {
            this.listData = array;
            FormSortingArrays_Load(null, EventArgs.Empty);
        }
        public FormSortingArrays()
        {
            InitializeComponent();
            this.listData = null; //Inicializa el array como vacío
        }

        private void FormSortingArrays_Load(object sender, EventArgs e)
        {
            
            
        }

        private void BtnSortedArrays_Click(object sender, EventArgs e)
        {
            if(this.listData is string[])
            {
                SortingArray((string[])this.listData); //Conversion directa del "listData" del tipo objeto a un array de strings
                MessageBox.Show($"El tipo de datos de la propiedad listData es: {this.listData.GetType()}");
            }
            else if(this.listData is int[])
            {

                SortingArray((int[])this.listData); //Conversion directa del "listData" del tipo objeto a un array de enteros
                MessageBox.Show($"El tipo de datos de la propiedad listData es: {this.listData.GetType()}");
            }

            //Hasta este punto el tipo de dato de la propiedad "listData" que antes era object, ahora es string[] o int[]
        }

        private void BtnArrayAges_Click(object sender, EventArgs e)
        {
            this.listData = new int[] { 1, 3, 30, 23, 16, 68, 16, 46, 76, 34, 32, 34, 12, 95, 22, 10, 18 };

            if(this.listData is int[])
            {
                RenderArray((int[])this.listData, LiArrayUnSorted);
            }
        }

        private void BtnArrayNames_Click(object sender, EventArgs e)
        {
            this.listData = new string[] 
            {
                "Lu", "Ana", "Luis", "Marta", "Carlos", "Sofia", "Javier", "Isabel",
                "Pedro", "Laura", "Alejandro", "Carmen", "Antonio", "Paula", "Jorge",
                "María", "Francisco", "Elena", "David", "Silvia"
            };

            if (this.listData is string[])
            {
                RenderArray((string[])this.listData, LiArrayUnSorted);
            }
        }

        private void RenderArray(int[] array, ListBox list)
        {
            list.Items.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                list.Items.Add(array[i]);

            }
        }
        private void RenderArray(string[] array, ListBox list)
        {
            list.Items.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                list.Items.Add(array[i]);

            }
        }

        private void SortingArray(int[] array)
        {
            int[] sortedArray = (int[])array.Clone();
            Array.Sort(sortedArray);

            RenderArray(sortedArray, LiArraySorted);
        }
        private void SortingArray(string[] array)
        {
            string[] sortedArray = (string[])array.Clone();
            Array.Sort(sortedArray);

            RenderArray(sortedArray, LiArraySorted);
        }

        
    }
}
