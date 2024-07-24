namespace appDescktop_V2.FormMatrices
{
    partial class FormMatrices
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
            LiData = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos de la matríz :";
            // 
            // LiData
            // 
            LiData.FormattingEnabled = true;
            LiData.ItemHeight = 15;
            LiData.Location = new Point(33, 54);
            LiData.Name = "LiData";
            LiData.ScrollAlwaysVisible = true;
            LiData.Size = new Size(336, 259);
            LiData.TabIndex = 1;
            LiData.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FormMatrices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 358);
            Controls.Add(LiData);
            Controls.Add(label1);
            Name = "FormMatrices";
            Text = "Formulario Matrices";
            Load += FormMatrices_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox LiData;
    }
}