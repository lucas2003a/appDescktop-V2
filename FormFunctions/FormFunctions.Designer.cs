namespace appDescktop_V2.FormFunctions
{
    partial class FormFunctions
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
            TxtName = new TextBox();
            BtnGreet = new Button();
            BtnGreetWithName = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 39);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(29, 57);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(224, 23);
            TxtName.TabIndex = 1;
            // 
            // BtnGreet
            // 
            BtnGreet.Location = new Point(29, 99);
            BtnGreet.Name = "BtnGreet";
            BtnGreet.Size = new Size(75, 23);
            BtnGreet.TabIndex = 2;
            BtnGreet.Text = "Saludar";
            BtnGreet.UseVisualStyleBackColor = true;
            BtnGreet.Click += BtnGreet_Click;
            // 
            // BtnGreetWithName
            // 
            BtnGreetWithName.Location = new Point(110, 99);
            BtnGreetWithName.Name = "BtnGreetWithName";
            BtnGreetWithName.Size = new Size(143, 23);
            BtnGreetWithName.TabIndex = 2;
            BtnGreetWithName.Text = "Saludar con nombre";
            BtnGreetWithName.UseVisualStyleBackColor = true;
            BtnGreetWithName.Click += BtnGreetWithName_Click;
            // 
            // FormFunctions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 173);
            Controls.Add(BtnGreetWithName);
            Controls.Add(BtnGreet);
            Controls.Add(TxtName);
            Controls.Add(label1);
            Name = "FormFunctions";
            Text = "Formulario de funciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtName;
        private Button BtnGreet;
        private Button BtnGreetWithName;
    }
}