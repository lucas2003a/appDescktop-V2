namespace appDescktop_V2.FormSearchInMatrix
{
    partial class FormSearchInMatrix
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
            TxtCode = new TextBox();
            TxtProduct = new TextBox();
            TxtPrice = new TextBox();
            BtnSearchCode = new Button();
            GrpCodeSearch = new GroupBox();
            GrpDataProduct = new GroupBox();
            GrpCodeSearch.SuspendLayout();
            GrpDataProduct.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 19);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Código :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 19);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Producto :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 63);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Precio (S/)";
            // 
            // TxtCode
            // 
            TxtCode.Location = new Point(23, 37);
            TxtCode.Name = "TxtCode";
            TxtCode.Size = new Size(171, 23);
            TxtCode.TabIndex = 1;
            // 
            // TxtProduct
            // 
            TxtProduct.Location = new Point(20, 37);
            TxtProduct.Name = "TxtProduct";
            TxtProduct.ReadOnly = true;
            TxtProduct.Size = new Size(168, 23);
            TxtProduct.TabIndex = 1;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(20, 81);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.ReadOnly = true;
            TxtPrice.Size = new Size(168, 23);
            TxtPrice.TabIndex = 1;
            // 
            // BtnSearchCode
            // 
            BtnSearchCode.Location = new Point(20, 66);
            BtnSearchCode.Name = "BtnSearchCode";
            BtnSearchCode.Size = new Size(75, 23);
            BtnSearchCode.TabIndex = 2;
            BtnSearchCode.Text = "Buscar";
            BtnSearchCode.UseVisualStyleBackColor = true;
            BtnSearchCode.Click += BtnSearchCode_Click;
            // 
            // GrpCodeSearch
            // 
            GrpCodeSearch.Controls.Add(label1);
            GrpCodeSearch.Controls.Add(BtnSearchCode);
            GrpCodeSearch.Controls.Add(TxtCode);
            GrpCodeSearch.Location = new Point(24, 12);
            GrpCodeSearch.Name = "GrpCodeSearch";
            GrpCodeSearch.Size = new Size(210, 100);
            GrpCodeSearch.TabIndex = 3;
            GrpCodeSearch.TabStop = false;
            GrpCodeSearch.Text = "Búsqueda";
            // 
            // GrpDataProduct
            // 
            GrpDataProduct.Controls.Add(label2);
            GrpDataProduct.Controls.Add(label3);
            GrpDataProduct.Controls.Add(TxtPrice);
            GrpDataProduct.Controls.Add(TxtProduct);
            GrpDataProduct.Location = new Point(24, 128);
            GrpDataProduct.Name = "GrpDataProduct";
            GrpDataProduct.Size = new Size(210, 113);
            GrpDataProduct.TabIndex = 4;
            GrpDataProduct.TabStop = false;
            GrpDataProduct.Text = "Datos del producto";
            // 
            // FormSearchInMatrix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 253);
            Controls.Add(GrpDataProduct);
            Controls.Add(GrpCodeSearch);
            Name = "FormSearchInMatrix";
            Text = "Formulario de busqueda - Matriz";
            Load += FormSearchInMatrix_Load;
            GrpCodeSearch.ResumeLayout(false);
            GrpCodeSearch.PerformLayout();
            GrpDataProduct.ResumeLayout(false);
            GrpDataProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtCode;
        private TextBox TxtProduct;
        private TextBox TxtPrice;
        private Button BtnSearchCode;
        private GroupBox GrpCodeSearch;
        private GroupBox GrpDataProduct;
    }
}