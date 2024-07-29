using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appDescktop_V2.FomrSearchInArray
{
    public partial class FormSearchInArray : Form
    {
        private string[] Names { get; set; }
        private int[] Ages { get; set; }

        private bool IsNumber { get; set; }
        public FormSearchInArray()
        {
            this.Names = new string[]
            {
                "Lu", "Ana", "Luis", "Marta", "Carlos", "Sofia", "Javier", "Isabel",
                "Pedro", "Laura", "Alejandro", "Carmen", "Antonio", "Paula", "Jorge",
                "María", "Francisco", "Elena", "David", "Silvia"
            };

            this.Ages = new int[]
            {
                1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11,
                21,32, 53, 64, 85, 16, 27, 88, 79,
                10, 11
            };
            InitializeComponent();
        }

        private void FormSearchInArray_Load(object sender, EventArgs e)
        {
            
        }



        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (this.IsNumber)
            {
                int age = int.Parse(TxtDataArray.Text);
                ValidateTextName(age);
            }
            else
            {

                string name = TxtDataArray.Text;
                ValidateTextName(name);
            }
        }

        private void BtnArrayNames_Click(object sender, EventArgs e)
        {
            this.IsNumber = false;
            RenderArray(this.Names);
        }

        private void BtnArrayAges_Click(object sender, EventArgs e)
        {
            this.IsNumber = true;
            RenderArray(this.Ages);
        }

        /// <summary>
        /// Renderiza los datos del array en el ListBox
        /// </summary>
        /// <param name="array"></param>
        private void RenderArray(string[] array)
        {
            LiDataArray.Items.Clear();

            foreach (string name in array)
            {
                LiDataArray.Items.Add(name);
            }
        }
        
        /// <summary>
        /// Renderiza los datos del array en el ListBox
        /// </summary>
        /// <param name="array"></param>
        private void RenderArray(int[] array)
        {
            LiDataArray.Items.Clear();

            foreach (int age in array)
            {
                string AgeString = age.ToString();
                LiDataArray.Items.Add(AgeString);
            }
        }

        /// <summary>
        /// Valida el nombre ingresado desde el TextBox
        /// </summary>
        /// <param name="nameInput"></param>
        private void ValidateTextName(string NameInput)
        {
            try
            {
                string name = NameInput;
                SearchNameInArray(name);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Valida la edad ingresada desde el TextBox
        /// </summary>
        /// <param name="AgeInput"></param>
        private void ValidateTextName(int AgeInput)
        {
            try
            {
                int age = AgeInput;
                SearchNameInArray(age);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Busca el nombre en el array
        /// </summary>
        /// <param name="name"></param>
        private void SearchNameInArray(string value)
        {
            string[] array = this.Names;

            bool isFind = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (value.Equals(array[i]))
                {
                    isFind = true;
                    break;
                }

            }

            if (isFind)
                ShowMessage($"{value} ha sido encontrado", "Dato encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ShowMessage($"{value} no ha sido encontrado", "Dato no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        /// <summary>
        /// Busca la edad en el array
        /// </summary>
        /// <param name="value"></param>
        private void SearchNameInArray(int value)
        {
            int[] array = this.Ages;

            bool isFind = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (value.Equals(array[i]))
                {
                    isFind = true;
                    break;
                }

            }

            if (isFind)
                ShowMessage($"{value} ha sido encontrado", "Dato encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ShowMessage($"{value} no ha sido encontrado", "Dato no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Muestra un mensaje personalizado
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="buttons"></param>
        /// <param name="icon"></param>
        private void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, buttons, icon);
        }

        
    }
}