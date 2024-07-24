namespace appDescktop_V2.FormArrays
{
    partial class FormArrays
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
            LiCourses = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // LiCourses
            // 
            LiCourses.FormattingEnabled = true;
            LiCourses.ItemHeight = 15;
            LiCourses.Location = new Point(34, 62);
            LiCourses.Name = "LiCourses";
            LiCourses.Size = new Size(233, 364);
            LiCourses.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 37);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Cursos :";
            // 
            // FormArrays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 450);
            Controls.Add(label1);
            Controls.Add(LiCourses);
            Name = "FormArrays";
            Text = "Formulario de cursos";
            Load += FormArrays_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LiCourses;
        private Label label1;
    }
}