namespace Prueba1
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
            this.Cargar_Button = new System.Windows.Forms.Button();
            this.Exportar_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Calcular_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Cargar_Button
            // 
            this.Cargar_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargar_Button.Location = new System.Drawing.Point(28, 12);
            this.Cargar_Button.Name = "Cargar_Button";
            this.Cargar_Button.Size = new System.Drawing.Size(152, 47);
            this.Cargar_Button.TabIndex = 0;
            this.Cargar_Button.Text = "Cargar Archivos";
            this.Cargar_Button.UseVisualStyleBackColor = true;
            this.Cargar_Button.Click += new System.EventHandler(this.Cargar_Button_Click);
            // 
            // Exportar_Button
            // 
            this.Exportar_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exportar_Button.Location = new System.Drawing.Point(28, 118);
            this.Exportar_Button.Name = "Exportar_Button";
            this.Exportar_Button.Size = new System.Drawing.Size(152, 47);
            this.Exportar_Button.TabIndex = 1;
            this.Exportar_Button.Text = "Exportar Excel";
            this.Exportar_Button.UseVisualStyleBackColor = true;
            this.Exportar_Button.Click += new System.EventHandler(this.Exportar_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(213, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Calcular_Button
            // 
            this.Calcular_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular_Button.Location = new System.Drawing.Point(28, 65);
            this.Calcular_Button.Name = "Calcular_Button";
            this.Calcular_Button.Size = new System.Drawing.Size(152, 47);
            this.Calcular_Button.TabIndex = 3;
            this.Calcular_Button.Text = "Calcular";
            this.Calcular_Button.UseVisualStyleBackColor = true;
            this.Calcular_Button.Click += new System.EventHandler(this.Calcular_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ruta,
            this.Volumen});
            this.dataGridView1.Location = new System.Drawing.Point(72, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 300);
            this.dataGridView1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(561, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 240);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Ruta
            // 
            this.Ruta.FillWeight = 200F;
            this.Ruta.HeaderText = "Ruta de la Imagen";
            this.Ruta.Name = "Ruta";
            this.Ruta.Width = 350;
            // 
            // Volumen
            // 
            this.Volumen.FillWeight = 200F;
            this.Volumen.HeaderText = "Volumen perdido";
            this.Volumen.Name = "Volumen";
            this.Volumen.Width = 350;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 599);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Calcular_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exportar_Button);
            this.Controls.Add(this.Cargar_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cargar_Button;
        private System.Windows.Forms.Button Exportar_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Calcular_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volumen;
    }
}

