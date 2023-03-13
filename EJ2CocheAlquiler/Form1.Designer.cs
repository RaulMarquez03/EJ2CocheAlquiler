namespace EJ2CocheAlquiler
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
            this.kmInicio = new System.Windows.Forms.NumericUpDown();
            this.kmFin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kmInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmFin)).BeginInit();
            this.SuspendLayout();
            // 
            // kmInicio
            // 
            this.kmInicio.Location = new System.Drawing.Point(359, 115);
            this.kmInicio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.kmInicio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kmInicio.Name = "kmInicio";
            this.kmInicio.Size = new System.Drawing.Size(150, 27);
            this.kmInicio.TabIndex = 0;
            this.kmInicio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kmFin
            // 
            this.kmFin.Location = new System.Drawing.Point(359, 157);
            this.kmFin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.kmFin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kmFin.Name = "kmFin";
            this.kmFin.Size = new System.Drawing.Size(150, 27);
            this.kmFin.TabIndex = 1;
            this.kmFin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kilometraje Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kilometraje Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad Obtenida";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(419, 235);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(17, 20);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "€";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.messagePrice);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Mostrar Kilometraje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.kmMessage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kmFin);
            this.Controls.Add(this.kmInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kmInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmFin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown kmInicio;
        private NumericUpDown kmFin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelPrice;
        private Button button1;
        private Button button2;
    }
}