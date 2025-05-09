using System.IO;
using Newtonsoft.Json;

namespace TareaPrograApi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            txtbusqueda = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnlimpiar = new Button();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Harlow Solid Italic", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(55, 19);
            label1.Name = "label1";
            label1.Size = new Size(831, 75);
            label1.TabIndex = 0;
            label1.Text = "Tabla Periodica de los Elementos";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(753, 406);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(670, 373);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(151, 27);
            txtbusqueda.TabIndex = 2;
            txtbusqueda.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(670, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 187);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Elephant", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(221, 129);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Elephant", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(221, 164);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Elephant", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(222, 196);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 4;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Elephant", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(222, 230);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(55, 287);
            label6.MaximumSize = new Size(550, 300);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(0, 23);
            label6.TabIndex = 4;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(55, 129);
            label7.Name = "label7";
            label7.Size = new Size(146, 19);
            label7.TabIndex = 4;
            label7.Text = "Nombre del Elemento:";
            label7.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Impact", 9F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(55, 164);
            label8.Name = "label8";
            label8.Size = new Size(134, 19);
            label8.TabIndex = 4;
            label8.Text = "Grupo del Elemento:";
            label8.Click += label5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Impact", 9F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(55, 196);
            label9.Name = "label9";
            label9.Size = new Size(100, 19);
            label9.TabIndex = 4;
            label9.Text = "Masa Atomica:";
            label9.Click += label5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Impact", 9F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(55, 230);
            label10.Name = "label10";
            label10.Size = new Size(85, 19);
            label10.TabIndex = 4;
            label10.Text = "Descubridor";
            label10.Click += label5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Impact", 9F);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(170, 468);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(223, 19);
            label11.TabIndex = 4;
            label11.Text = "Descripcion e Historia del Elmento";
            label11.Click += label5_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(653, 406);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(94, 29);
            btnlimpiar.TabIndex = 1;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Impact", 6F);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(281, 498);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(356, 14);
            label12.TabIndex = 4;
            label12.Text = "\"Descripciones de los elementos unicamente en ingles, buscar elementos en ingles\"";
            label12.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 521);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(txtbusqueda);
            Controls.Add(btnlimpiar);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtbusqueda;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnlimpiar;
        private Label label12;
    }
}
