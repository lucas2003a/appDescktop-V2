using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDescktop_V2.FomrSearchInArray
{
    public partial class FormSearchInArray : Form
    {
        public string[] Names { get; set; }
        public FormSearchInArray()
        {
            this.Names = new string[]
            {
                "Lu", "Ana", "Luis", "Marta", "Carlos", "Sofia", "Javier", "Isabel",
                "Pedro", "Laura", "Alejandro", "Carmen", "Antonio", "Paula", "Jorge",
                "María", "Francisco", "Elena", "David", "Silvia"
            };
            InitializeComponent();
        }

        private void FormSearchInArray_Load(object sender, EventArgs e)
        {
            RenderArray(this.Names);
        }

        

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string name = TxtDataArray.Text;
            ValidateTextName(name);
        }

        /**
         *Renderiza los datos del array en el listBox
         */
        private void RenderArray(string[] array)
        {
            LiDataArray.Items.Clear();

            foreach (string name in array)
            {
                LiDataArray.Items.Add(name);
            }
        }

        /**
         * Valida el nombre ingresado desde el TextBox
         */
        private void ValidateTextName(string nameInput)
        {
            try
            {
                string name = nameInput;
                SearchNameInArray(name);
            }
            catch (Exception ex) { 
                ShowMessage(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         *Busca el nombre en el array
         */
        private void SearchNameInArray(string name)
        {
            string[] array = this.Names;
            bool isFind = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (name.Equals(array[i]))
                {
                    isFind = true;
                    break;
                }

            }

            if (isFind) 
                ShowMessage($"El nombre {name} ha sido encontrado", "Nombre encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ShowMessage($"El nombre {name} no ha sido encontrado", "Nombre no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*
         *Muestra un mensaje personalizado
         */
        private void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, buttons, icon);
        }
    }
}