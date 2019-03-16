namespace Playlist
{
    partial class Form1
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
            this.Canciones = new System.Windows.Forms.ListBox();
            this.Inicio = new System.Windows.Forms.Button();
            this.Fin = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            this.Anterior = new System.Windows.Forms.Button();
            this.Metadatos1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buscaCanciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Canciones
            // 
            this.Canciones.FormattingEnabled = true;
            this.Canciones.Location = new System.Drawing.Point(12, 12);
            this.Canciones.Name = "Canciones";
            this.Canciones.Size = new System.Drawing.Size(172, 238);
            this.Canciones.TabIndex = 0;
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(198, 150);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(53, 23);
            this.Inicio.TabIndex = 1;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // Fin
            // 
            this.Fin.Location = new System.Drawing.Point(386, 150);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(53, 23);
            this.Fin.TabIndex = 2;
            this.Fin.Text = "Fin";
            this.Fin.UseVisualStyleBackColor = true;
            this.Fin.Click += new System.EventHandler(this.Fin_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(316, 150);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(64, 23);
            this.Siguiente.TabIndex = 3;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Anterior
            // 
            this.Anterior.Location = new System.Drawing.Point(257, 150);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(53, 23);
            this.Anterior.TabIndex = 4;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // Metadatos1
            // 
            this.Metadatos1.Enabled = false;
            this.Metadatos1.Location = new System.Drawing.Point(222, 40);
            this.Metadatos1.Multiline = true;
            this.Metadatos1.Name = "Metadatos1";
            this.Metadatos1.Size = new System.Drawing.Size(201, 93);
            this.Metadatos1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cancion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Artista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Album";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buscaCanciones
            // 
            this.buscaCanciones.Location = new System.Drawing.Point(238, 253);
            this.buscaCanciones.Name = "buscaCanciones";
            this.buscaCanciones.Size = new System.Drawing.Size(173, 52);
            this.buscaCanciones.TabIndex = 13;
            this.buscaCanciones.Text = "Buscar canciones";
            this.buscaCanciones.UseVisualStyleBackColor = true;
            this.buscaCanciones.Click += new System.EventHandler(this.buscaCanciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 328);
            this.Controls.Add(this.buscaCanciones);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Metadatos1);
            this.Controls.Add(this.Anterior);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.Canciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Canciones;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Fin;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.TextBox Metadatos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buscaCanciones;
    }
}

