namespace appDescktop_V2.FormFunctionsReturn
{
    partial class FormFunctionsReturn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtTotalPurchase = new TextBox();
            TxtDiscount = new TextBox();
            TxtNetTotal = new TextBox();
            BtnCalculate = new Button();
            GrpInput = new GroupBox();
            GrpData = new GroupBox();
            GrpInput.SuspendLayout();
            GrpData.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Total de la compra :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 19);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 0;
            label2.Text = "Descuento :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 63);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 0;
            label3.Text = "Total neto :";
            // 
            // TxtTotalPurchase
            // 
            TxtTotalPurchase.Location = new Point(13, 41);
            TxtTotalPurchase.Name = "TxtTotalPurchase";
            TxtTotalPurchase.Size = new Size(100, 23);
            TxtTotalPurchase.TabIndex = 1;
            // 
            // TxtDiscount
            // 
            TxtDiscount.Location = new Point(19, 37);
            TxtDiscount.Name = "TxtDiscount";
            TxtDiscount.ReadOnly = true;
            TxtDiscount.Size = new Size(100, 23);
            TxtDiscount.TabIndex = 1;
            // 
            // TxtNetTotal
            // 
            TxtNetTotal.Location = new Point(19, 81);
            TxtNetTotal.Name = "TxtNetTotal";
            TxtNetTotal.ReadOnly = true;
            TxtNetTotal.Size = new Size(100, 23);
            TxtNetTotal.TabIndex = 1;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(119, 41);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(75, 23);
            BtnCalculate.TabIndex = 2;
            BtnCalculate.Text = "Calcular";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // GrpInput
            // 
            GrpInput.Controls.Add(BtnCalculate);
            GrpInput.Controls.Add(label1);
            GrpInput.Controls.Add(TxtTotalPurchase);
            GrpInput.Location = new Point(33, 12);
            GrpInput.Name = "GrpInput";
            GrpInput.Size = new Size(200, 81);
            GrpInput.TabIndex = 3;
            GrpInput.TabStop = false;
            GrpInput.Text = "Monto a calcular";
            // 
            // GrpData
            // 
            GrpData.Controls.Add(label2);
            GrpData.Controls.Add(label3);
            GrpData.Controls.Add(TxtNetTotal);
            GrpData.Controls.Add(TxtDiscount);
            GrpData.Location = new Point(33, 121);
            GrpData.Name = "GrpData";
            GrpData.Size = new Size(200, 124);
            GrpData.TabIndex = 4;
            GrpData.TabStop = false;
            GrpData.Text = "Datos de la compra";
            // 
            // FormFunctionsReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 257);
            Controls.Add(GrpData);
            Controls.Add(GrpInput);
            Name = "FormFunctionsReturn";
            Text = "Formulario - funciones de retorno";
            Load += FormFunctionsReturn_Load;
            GrpInput.ResumeLayout(false);
            GrpInput.PerformLayout();
            GrpData.ResumeLayout(false);
            GrpData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtTotalPurchase;
        private TextBox TxtDiscount;
        private TextBox TxtNetTotal;
        private Button BtnCalculate;
        private GroupBox GrpInput;
        private GroupBox GrpData;
    }
}