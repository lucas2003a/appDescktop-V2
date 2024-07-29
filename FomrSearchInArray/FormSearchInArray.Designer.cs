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
            BtnArrayNames = new Button();
            BtnArrayAges = new Button();
            GrpArrays = new GroupBox();
            GrpSearchArray = new GroupBox();
            GrpArrays.SuspendLayout();
            GrpSearchArray.SuspendLayout();
            SuspendLayout();
            // 
            // LiDataArray
            // 
            LiDataArray.FormattingEnabled = true;
            LiDataArray.ItemHeight = 15;
            LiDataArray.Location = new Point(36, 235);
            LiDataArray.Name = "LiDataArray";
            LiDataArray.Size = new Size(168, 94);
            LiDataArray.TabIndex = 0;
            // 
            // TxtDataArray
            // 
            TxtDataArray.Location = new Point(47, 37);
            TxtDataArray.Name = "TxtDataArray";
            TxtDataArray.Size = new Size(100, 23);
            TxtDataArray.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(56, 66);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 4;
            BtnSearch.Text = "Buscar";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 19);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 3;
            label1.Text = "Dato a buscar :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 217);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Datos del array :";
            // 
            // BtnArrayNames
            // 
            BtnArrayNames.Location = new Point(15, 33);
            BtnArrayNames.Name = "BtnArrayNames";
            BtnArrayNames.Size = new Size(75, 23);
            BtnArrayNames.TabIndex = 1;
            BtnArrayNames.Text = "Nombres";
            BtnArrayNames.UseVisualStyleBackColor = true;
            BtnArrayNames.Click += BtnArrayNames_Click;
            // 
            // BtnArrayAges
            // 
            BtnArrayAges.Location = new Point(96, 33);
            BtnArrayAges.Name = "BtnArrayAges";
            BtnArrayAges.Size = new Size(75, 23);
            BtnArrayAges.TabIndex = 2;
            BtnArrayAges.Text = "Edades";
            BtnArrayAges.UseVisualStyleBackColor = true;
            BtnArrayAges.Click += BtnArrayAges_Click;
            // 
            // GrpArrays
            // 
            GrpArrays.Controls.Add(BtnArrayNames);
            GrpArrays.Controls.Add(BtnArrayAges);
            GrpArrays.Location = new Point(21, 12);
            GrpArrays.Name = "GrpArrays";
            GrpArrays.Size = new Size(200, 75);
            GrpArrays.TabIndex = 6;
            GrpArrays.TabStop = false;
            GrpArrays.Text = "Arrays";
            // 
            // GrpSearchArray
            // 
            GrpSearchArray.Controls.Add(label1);
            GrpSearchArray.Controls.Add(TxtDataArray);
            GrpSearchArray.Controls.Add(BtnSearch);
            GrpSearchArray.Location = new Point(21, 106);
            GrpSearchArray.Name = "GrpSearchArray";
            GrpSearchArray.Size = new Size(200, 97);
            GrpSearchArray.TabIndex = 6;
            GrpSearchArray.TabStop = false;
            GrpSearchArray.Text = "Busqueda de arrays";
            // 
            // FormSearchInArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 347);
            Controls.Add(GrpSearchArray);
            Controls.Add(GrpArrays);
            Controls.Add(label2);
            Controls.Add(LiDataArray);
            Name = "FormSearchInArray";
            Text = "Buscar datos - array";
            Load += FormSearchInArray_Load;
            GrpArrays.ResumeLayout(false);
            GrpSearchArray.ResumeLayout(false);
            GrpSearchArray.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LiDataArray;
        private TextBox TxtDataArray;
        private Button BtnSearch;
        private Label label1;
        private Label label2;
        private Button BtnArrayNames;
        private Button BtnArrayAges;
        private GroupBox GrpArrays;
        private GroupBox GrpSearchArray;
    }
}