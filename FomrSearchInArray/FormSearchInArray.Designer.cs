namespace appDescktop_V2.FomrSearchInArray
{
    partial class FormSearchInArray
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
            LiDataArray = new ListBox();
            TxtDataArray = new TextBox();
            BtnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // LiDataArray
            // 
            LiDataArray.FormattingEnabled = true;
            LiDataArray.ItemHeight = 15;
            LiDataArray.Location = new Point(36, 168);
            LiDataArray.Name = "LiDataArray";
            LiDataArray.Size = new Size(168, 94);
            LiDataArray.TabIndex = 0;
            // 
            // TxtDataArray
            // 
            TxtDataArray.Location = new Point(71, 74);
            TxtDataArray.Name = "TxtDataArray";
            TxtDataArray.Size = new Size(100, 23);
            TxtDataArray.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(80, 103);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Buscar";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 56);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 3;
            label1.Text = "Dato a buscar :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 150);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Datos del array :";
            // 
            // FormSearchInArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 294);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSearch);
            Controls.Add(TxtDataArray);
            Controls.Add(LiDataArray);
            Name = "FormSearchInArray";
            Text = "Buscar datos - array";
            Load += FormSearchInArray_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LiDataArray;
        private TextBox TxtDataArray;
        private Button BtnSearch;
        private Label label1;
        private Label label2;
    }
}