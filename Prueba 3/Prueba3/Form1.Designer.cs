namespace Prueba3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Cargar_Button = new System.Windows.Forms.Button();
            this.Procesar_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VelocidadTXT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 305);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(475, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(452, 305);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Cargar_Button
            // 
            this.Cargar_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargar_Button.Location = new System.Drawing.Point(8, 323);
            this.Cargar_Button.Name = "Cargar_Button";
            this.Cargar_Button.Size = new System.Drawing.Size(175, 62);
            this.Cargar_Button.TabIndex = 2;
            this.Cargar_Button.Text = "Cargar";
            this.Cargar_Button.UseVisualStyleBackColor = true;
            this.Cargar_Button.Click += new System.EventHandler(this.Cargar_Button_Click);
            // 
            // Procesar_Button
            // 
            this.Procesar_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procesar_Button.Location = new System.Drawing.Point(8, 402);
            this.Procesar_Button.Name = "Procesar_Button";
            this.Procesar_Button.Size = new System.Drawing.Size(175, 62);
            this.Procesar_Button.TabIndex = 3;
            this.Procesar_Button.Text = "Procesar";
            this.Procesar_Button.UseVisualStyleBackColor = true;
            this.Procesar_Button.Click += new System.EventHandler(this.Procesar_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Velocidad:";
            // 
            // VelocidadTXT
            // 
            this.VelocidadTXT.AutoSize = true;
            this.VelocidadTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VelocidadTXT.Location = new System.Drawing.Point(653, 342);
            this.VelocidadTXT.Name = "VelocidadTXT";
            this.VelocidadTXT.Size = new System.Drawing.Size(89, 25);
            this.VelocidadTXT.TabIndex = 6;
            this.VelocidadTXT.Text = "-----------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 472);
            this.Controls.Add(this.VelocidadTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Procesar_Button);
            this.Controls.Add(this.Cargar_Button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Cargar_Button;
        private System.Windows.Forms.Button Procesar_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VelocidadTXT;
    }
}

