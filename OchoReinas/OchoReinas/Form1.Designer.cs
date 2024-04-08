namespace OchoReinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.pnlTablero = new System.Windows.Forms.Panel();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSolucion = new System.Windows.Forms.Button();
            this.btnResolver = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.btnRespuesta = new System.Windows.Forms.Button();
            this.Soluciones = new System.Windows.Forms.ListBox();
            this.pnlBase.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.ForeColor = System.Drawing.Color.Thistle;
            this.btnEmpezar.Location = new System.Drawing.Point(70, 407);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(113, 41);
            this.btnEmpezar.TabIndex = 0;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Thistle;
            this.btnSalir.Location = new System.Drawing.Point(665, 403);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 48);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlBase
            // 
            this.pnlBase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBase.BackgroundImage")));
            this.pnlBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBase.Controls.Add(this.pnlTablero);
            this.pnlBase.Location = new System.Drawing.Point(190, 12);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(421, 407);
            this.pnlBase.TabIndex = 2;
            // 
            // pnlTablero
            // 
            this.pnlTablero.Location = new System.Drawing.Point(38, 39);
            this.pnlTablero.Name = "pnlTablero";
            this.pnlTablero.Size = new System.Drawing.Size(340, 329);
            this.pnlTablero.TabIndex = 0;
            this.pnlTablero.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTablero_Paint);
            // 
            // gbOpciones
            // 
            this.gbOpciones.BackColor = System.Drawing.Color.Transparent;
            this.gbOpciones.Controls.Add(this.btnLimpiar);
            this.gbOpciones.Controls.Add(this.btnSolucion);
            this.gbOpciones.Controls.Add(this.btnResolver);
            this.gbOpciones.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.ForeColor = System.Drawing.Color.Thistle;
            this.gbOpciones.Location = new System.Drawing.Point(12, 12);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(171, 243);
            this.gbOpciones.TabIndex = 3;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(27, 98);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 37);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSolucion
            // 
            this.btnSolucion.Location = new System.Drawing.Point(27, 141);
            this.btnSolucion.Name = "btnSolucion";
            this.btnSolucion.Size = new System.Drawing.Size(120, 37);
            this.btnSolucion.TabIndex = 5;
            this.btnSolucion.Text = "Solución";
            this.btnSolucion.UseVisualStyleBackColor = true;
            this.btnSolucion.Click += new System.EventHandler(this.btnSolucion_Click);
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(27, 184);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(120, 41);
            this.btnResolver.TabIndex = 4;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(665, 69);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(81, 22);
            this.txtRespuesta.TabIndex = 7;
            this.txtRespuesta.Text = "Respuesta";
            // 
            // btnRespuesta
            // 
            this.btnRespuesta.Location = new System.Drawing.Point(633, 12);
            this.btnRespuesta.Name = "btnRespuesta";
            this.btnRespuesta.Size = new System.Drawing.Size(135, 50);
            this.btnRespuesta.TabIndex = 7;
            this.btnRespuesta.Text = "Oro parece, plata no es...";
            this.btnRespuesta.UseVisualStyleBackColor = true;
            this.btnRespuesta.Click += new System.EventHandler(this.btnRespuesta_Click);
            // 
            // Soluciones
            // 
            this.Soluciones.FormattingEnabled = true;
            this.Soluciones.ItemHeight = 16;
            this.Soluciones.Location = new System.Drawing.Point(608, 108);
            this.Soluciones.Name = "Soluciones";
            this.Soluciones.Size = new System.Drawing.Size(213, 260);
            this.Soluciones.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 487);
            this.Controls.Add(this.Soluciones);
            this.Controls.Add(this.btnRespuesta);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEmpezar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OCHO REINAS ♛";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBase.ResumeLayout(false);
            this.gbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Panel pnlTablero;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Button btnSolucion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button btnRespuesta;
        private System.Windows.Forms.ListBox Soluciones;
    }
}

