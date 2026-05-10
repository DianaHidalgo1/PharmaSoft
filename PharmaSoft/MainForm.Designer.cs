namespace PharmaSoft
{
    partial class PharmaSoft
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PharmaSoft
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 650);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(292, 70);
            label1.TabIndex = 0;
            label1.Text = "PharmaSoft";
            // 
            // button1
            // 
            button1.Location = new Point(21, 127);
            button1.Name = "button1";
            button1.Size = new Size(127, 34);
            button1.TabIndex = 1;
            button1.Text = "🏠Inicio";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(21, 181);
            button2.Name = "button2";
            button2.Size = new Size(127, 34);
            button2.TabIndex = 2;
            button2.Text = "📦Inventario";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(21, 240);
            button3.Name = "button3";
            button3.Size = new Size(127, 34);
            button3.TabIndex = 3;
            button3.Text = "\U0001f6d2Ventas";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(21, 299);
            button4.Name = "button4";
            button4.Size = new Size(127, 34);
            button4.TabIndex = 4;
            button4.Text = "👨‍💼Clientes";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(21, 356);
            button5.Name = "button5";
            button5.Size = new Size(127, 34);
            button5.TabIndex = 5;
            button5.Text = "📃Recetas";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(21, 410);
            button6.Name = "button6";
            button6.Size = new Size(127, 34);
            button6.TabIndex = 6;
            button6.Text = "\U0001f6d2Compras";
            button6.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "PharmaSoft";
            Text = "PharmaSoft";
            ClientSize = new Size(1143, 750);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button6;
        private Button button5;
        private Button button4;
    }
}
