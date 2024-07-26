namespace appDescktop_V2.FormSortingArrays
{
    partial class FormSortingArrays
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
            LiArrayUnSorted = new ListBox();
            LiArraySorted = new ListBox();
            BtnSortedArrays = new Button();
            BtnArrayAges = new Button();
            BtnArrayNames = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 19);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Ordenamiento de arrays";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 83);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 0;
            label2.Text = "Arrray desordenado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 83);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 0;
            label3.Text = "Arrray ordenado:";
            // 
            // LiArrayUnSorted
            // 
            LiArrayUnSorted.FormattingEnabled = true;
            LiArrayUnSorted.ItemHeight = 15;
            LiArrayUnSorted.Location = new Point(21, 101);
            LiArrayUnSorted.Name = "LiArrayUnSorted";
            LiArrayUnSorted.ScrollAlwaysVisible = true;
            LiArrayUnSorted.Size = new Size(166, 199);
            LiArrayUnSorted.TabIndex = 1;
            // 
            // LiArraySorted
            // 
            LiArraySorted.FormattingEnabled = true;
            LiArraySorted.ItemHeight = 15;
            LiArraySorted.Location = new Point(274, 101);
            LiArraySorted.Name = "LiArraySorted";
            LiArraySorted.ScrollAlwaysVisible = true;
            LiArraySorted.Size = new Size(166, 199);
            LiArraySorted.TabIndex = 1;
            // 
            // BtnSortedArrays
            // 
            BtnSortedArrays.Location = new Point(193, 168);
            BtnSortedArrays.Name = "BtnSortedArrays";
            BtnSortedArrays.Size = new Size(75, 23);
            BtnSortedArrays.TabIndex = 2;
            BtnSortedArrays.Text = ">";
            BtnSortedArrays.UseVisualStyleBackColor = true;
            BtnSortedArrays.Click += BtnSortedArrays_Click;
            // 
            // BtnArrayAges
            // 
            BtnArrayAges.Location = new Point(116, 46);
            BtnArrayAges.Name = "BtnArrayAges";
            BtnArrayAges.Size = new Size(95, 23);
            BtnArrayAges.TabIndex = 3;
            BtnArrayAges.Text = "Edades";
            BtnArrayAges.UseVisualStyleBackColor = true;
            BtnArrayAges.Click += BtnArrayAges_Click;
            // 
            // BtnArrayNames
            // 
            BtnArrayNames.Location = new Point(217, 46);
            BtnArrayNames.Name = "BtnArrayNames";
            BtnArrayNames.Size = new Size(95, 23);
            BtnArrayNames.TabIndex = 3;
            BtnArrayNames.Text = "Nombres";
            BtnArrayNames.UseVisualStyleBackColor = true;
            BtnArrayNames.Click += BtnArrayNames_Click;
            // 
            // FormSortingArrays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 320);
            Controls.Add(BtnArrayNames);
            Controls.Add(BtnArrayAges);
            Controls.Add(BtnSortedArrays);
            Controls.Add(LiArraySorted);
            Controls.Add(LiArrayUnSorted);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSortingArrays";
            Text = "Ordenamiento de arrays";
            Load += FormSortingArrays_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox LiArrayUnSorted;
        private ListBox LiArraySorted;
        private Button BtnSortedArrays;
        private Button BtnArrayAges;
        private Button BtnArrayNames;
    }
}