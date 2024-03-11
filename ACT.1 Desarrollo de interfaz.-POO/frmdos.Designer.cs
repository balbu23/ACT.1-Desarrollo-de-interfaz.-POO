
namespace ACT._1_Desarrollo_de_interfaz._POO
{
    partial class frmdos
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
            this.btnregresar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnverificar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.texval1 = new System.Windows.Forms.TextBox();
            this.textval2 = new System.Windows.Forms.TextBox();
            this.cboelige = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.select1 = new System.Windows.Forms.CheckBox();
            this.select2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblopcionelegida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.Location = new System.Drawing.Point(803, 291);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(110, 36);
            this.btnregresar.TabIndex = 0;
            this.btnregresar.Text = "regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            this.btnregresar.MouseHover += new System.EventHandler(this.btnregresar_MouseHover);
            this.btnregresar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnregresar_MouseMove);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Location = new System.Drawing.Point(673, 292);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(108, 34);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            this.btnsalir.MouseHover += new System.EventHandler(this.btnsalir_MouseHover);
            this.btnsalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnsalir_MouseMove);
            // 
            // btnverificar
            // 
            this.btnverificar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnverificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverificar.Location = new System.Drawing.Point(352, 292);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(115, 36);
            this.btnverificar.TabIndex = 2;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = false;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Location = new System.Drawing.Point(518, 290);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(105, 36);
            this.btnlimpiar.TabIndex = 3;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // texval1
            // 
            this.texval1.Location = new System.Drawing.Point(135, 29);
            this.texval1.Name = "texval1";
            this.texval1.Size = new System.Drawing.Size(165, 30);
            this.texval1.TabIndex = 4;
            this.texval1.TextChanged += new System.EventHandler(this.texval1_TextChanged);
            // 
            // textval2
            // 
            this.textval2.Location = new System.Drawing.Point(131, 89);
            this.textval2.Name = "textval2";
            this.textval2.Size = new System.Drawing.Size(165, 30);
            this.textval2.TabIndex = 5;
            this.textval2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textval2_KeyPress);
            // 
            // cboelige
            // 
            this.cboelige.FormattingEnabled = true;
            this.cboelige.Items.AddRange(new object[] {
            "------------",
            "Primer Valor",
            "Segundo Valor",
            "Tercer Valor",
            "Cuarto Valor"});
            this.cboelige.Location = new System.Drawing.Point(135, 142);
            this.cboelige.Name = "cboelige";
            this.cboelige.Size = new System.Drawing.Size(165, 33);
            this.cboelige.TabIndex = 6;
            this.cboelige.SelectedIndexChanged += new System.EventHandler(this.cboelige_SelectedIndexChanged);
            this.cboelige.SelectedValueChanged += new System.EventHandler(this.textval3_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // select1
            // 
            this.select1.AutoSize = true;
            this.select1.Location = new System.Drawing.Point(182, 268);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(118, 29);
            this.select1.TabIndex = 8;
            this.select1.Text = "Femenino";
            this.select1.UseVisualStyleBackColor = true;
            // 
            // select2
            // 
            this.select2.AutoSize = true;
            this.select2.Location = new System.Drawing.Point(12, 268);
            this.select2.Name = "select2";
            this.select2.Size = new System.Drawing.Size(120, 29);
            this.select2.TabIndex = 9;
            this.select2.Text = "Masculino";
            this.select2.UseVisualStyleBackColor = true;
            this.select2.CheckedChanged += new System.EventHandler(this.select2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "seleccione una casilla";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblopcionelegida
            // 
            this.lblopcionelegida.AutoSize = true;
            this.lblopcionelegida.ForeColor = System.Drawing.Color.Red;
            this.lblopcionelegida.Location = new System.Drawing.Point(479, 142);
            this.lblopcionelegida.Name = "lblopcionelegida";
            this.lblopcionelegida.Size = new System.Drawing.Size(0, 25);
            this.lblopcionelegida.TabIndex = 11;
            this.lblopcionelegida.Click += new System.EventHandler(this.lblopcionelegida_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "opción elegida";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Número:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Valores:";
            // 
            // frmdos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(977, 326);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblopcionelegida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.select2);
            this.Controls.Add(this.select1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboelige);
            this.Controls.Add(this.textval2);
            this.Controls.Add(this.texval1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnregresar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmdos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formularioDos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmdos_FormClosing);
            this.Load += new System.EventHandler(this.frmdos_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmdos_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox texval1;
        private System.Windows.Forms.TextBox textval2;
        private System.Windows.Forms.ComboBox cboelige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox select1;
        private System.Windows.Forms.CheckBox select2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblopcionelegida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}