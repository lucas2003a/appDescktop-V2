using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDescktop_V2.FormFunctionsReturn
{
    public partial class FormFunctionsReturn : Form
    {
        public FormFunctionsReturn()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            ValidateTextBox();
        }

        private void ValidateTextBox()
        {
            try
            {
                double TotalPurchase = double.Parse(TxtTotalPurchase.Text);
                double Discount = CalculateDiscount(TotalPurchase);
                double NetTotal = TotalPurchase - Discount;

                TxtDiscount.Text = Discount.ToString();
                TxtNetTotal.Text = NetTotal.ToString();

            }
            catch (Exception e)
            {
                ShowMessage(
                    $"{e.Message}\n {e.StackTrace}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                throw;
            }
        }

        /// <summary>
        /// Calcula el descuento devolviendo un número de tipo double
        /// </summary>
        /// <param name="TotalPurchase"></param>
        /// <returns></returns>

        private double CalculateDiscount(double TotalPurchase)
        {
            double Discount = 0;

            try
            {

                if (TotalPurchase > 100 && TotalPurchase <= 200)
                    //5/100 = 0.05 => Descuento del 5%
                    Discount = TotalPurchase * 0.05;
                else if (TotalPurchase > 200 && TotalPurchase <= 300)
                    //10/100 = 0.10 => Descuento del 10%
                    Discount = TotalPurchase * 0.1;
                else if (TotalPurchase > 300)
                    //20/100 = 0.20 => Descuento del 20%
                    Discount = TotalPurchase * 0.2;

                return Discount; //Retorna un Discount (un tipo de dato double)

            }
            catch (Exception e)
            {
                ShowMessage(
                    $"{e.Message}\n {e.StackTrace}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                throw;
            }
        }

        private void ShowMessage(string messge, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(messge, title, buttons, icon);
        }

        private void FormFunctionsReturn_Load(object sender, EventArgs e)
        {

        }
    }
}
