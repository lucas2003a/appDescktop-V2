namespace appDescktop_V2.FormStringFunctions
{
    partial class FormStringFunctions
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
            TxtOriginal = new TextBox();
            TextResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnSubstring = new Button();
            BtnTrim = new Button();
            BtnToLower = new Button();
            BtnToUpper = new Button();
            GrtTexts = new GroupBox();
            GrpFunctions = new GroupBox();
            GrtTexts.SuspendLayout();
            GrpFunctions.SuspendLayout();
            SuspendLayout();
            // 
            // TxtOriginal
            // 
            TxtOriginal.Location = new Point(6, 37);
            TxtOriginal.Name = "TxtOriginal";
            TxtOriginal.Size = new Size(188, 23);
            TxtOriginal.TabIndex = 0;
            // 
            // TextResult
            // 
            TextResult.Location = new Point(6, 82);
            TextResult.Name = "TextResult";
            TextResult.ReadOnly = true;
            TextResult.Size = new Size(188, 23);
            TextResult.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Texto original :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Resultado :";
            // 
            // BtnSubstring
            // 
            BtnSubstring.Location = new Point(18, 32);
            BtnSubstring.Name = "BtnSubstring";
            BtnSubstring.Size = new Size(75, 23);
            BtnSubstring.TabIndex = 2;
            BtnSubstring.Text = "Subcadena";
            BtnSubstring.UseVisualStyleBackColor = true;
            BtnSubstring.Click += BtnSubstring_Click;
            // 
            // BtnTrim
            // 
            BtnTrim.Location = new Point(18, 61);
            BtnTrim.Name = "BtnTrim";
            BtnTrim.Size = new Size(75, 23);
            BtnTrim.TabIndex = 4;
            BtnTrim.Text = "Trim";
            BtnTrim.UseVisualStyleBackColor = true;
            BtnTrim.Click += BtnTrim_Click;
            // 
            // BtnToLower
            // 
            BtnToLower.Location = new Point(99, 61);
            BtnToLower.Name = "BtnToLower";
            BtnToLower.Size = new Size(95, 23);
            BtnToLower.TabIndex = 5;
            BtnToLower.Text = "Minúsculas";
            BtnToLower.UseVisualStyleBackColor = true;
            BtnToLower.Click += BtnToLower_Click;
            // 
            // BtnToUpper
            // 
            BtnToUpper.Location = new Point(99, 32);
            BtnToUpper.Name = "BtnToUpper";
            BtnToUpper.Size = new Size(95, 23);
            BtnToUpper.TabIndex = 3;
            BtnToUpper.Text = "Mayúsculas";
            BtnToUpper.UseVisualStyleBackColor = true;
            BtnToUpper.Click += BtnToUpper_Click;
            // 
            // GrtTexts
            // 
            GrtTexts.Controls.Add(label1);
            GrtTexts.Controls.Add(TxtOriginal);
            GrtTexts.Controls.Add(TextResult);
            GrtTexts.Controls.Add(label2);
            GrtTexts.Location = new Point(29, 27);
            GrtTexts.Name = "GrtTexts";
            GrtTexts.Size = new Size(200, 111);
            GrtTexts.TabIndex = 3;
            GrtTexts.TabStop = false;
            GrtTexts.Text = "Cadenas de texto";
            // 
            // GrpFunctions
            // 
            GrpFunctions.Controls.Add(BtnSubstring);
            GrpFunctions.Controls.Add(BtnTrim);
            GrpFunctions.Controls.Add(BtnToUpper);
            GrpFunctions.Controls.Add(BtnToLower);
            GrpFunctions.Location = new Point(29, 144);
            GrpFunctions.Name = "GrpFunctions";
            GrpFunctions.Size = new Size(200, 100);
            GrpFunctions.TabIndex = 4;
            GrpFunctions.TabStop = false;
            GrpFunctions.Text = "Funciones";
            // 
            // FormStringFunctions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 280);
            Controls.Add(GrpFunctions);
            Controls.Add(GrtTexts);
            Name = "FormStringFunctions";
            Text = "Formulario - Funciones de cadenas";
            GrtTexts.ResumeLayout(false);
            GrtTexts.PerformLayout();
            GrpFunctions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxtOriginal;
        private TextBox TextResult;
        private Label label1;
        private Label label2;
        private Button BtnSubstring;
        private Button BtnTrim;
        private Button BtnToLower;
        private Button BtnToUpper;
        private GroupBox GrtTexts;
        private GroupBox GrpFunctions;
    }
}