
namespace ACT._1_Desarrollo_de_interfaz._POO
{
    partial class FormUno
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
            this.btninicio = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninicio.Location = new System.Drawing.Point(240, 81);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(101, 33);
            this.btninicio.TabIndex = 0;
            this.btninicio.Text = "avanzar";
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            this.btninicio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btninicio_MouseMove);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Location = new System.Drawing.Point(456, 81);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(103, 33);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            this.btnsalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnsalir_MouseMove);
            // 
            // FormUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(977, 297);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btninicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormUno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mi primera aplicación";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormUno_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Button btnsalir;
    }
}

