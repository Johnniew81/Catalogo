namespace Catalogo
{
    partial class Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            this.txtarchivo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnexaminar = new System.Windows.Forms.Button();
            this.btncambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtarchivo
            // 
            this.txtarchivo.Location = new System.Drawing.Point(12, 12);
            this.txtarchivo.Name = "txtarchivo";
            this.txtarchivo.Size = new System.Drawing.Size(240, 20);
            this.txtarchivo.TabIndex = 0;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(12, 38);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(240, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // btnexaminar
            // 
            this.btnexaminar.Location = new System.Drawing.Point(258, 12);
            this.btnexaminar.Name = "btnexaminar";
            this.btnexaminar.Size = new System.Drawing.Size(105, 20);
            this.btnexaminar.TabIndex = 2;
            this.btnexaminar.Text = "Examinar";
            this.btnexaminar.UseVisualStyleBackColor = true;
            this.btnexaminar.Click += new System.EventHandler(this.btnexaminar_Click);
            // 
            // btncambiar
            // 
            this.btncambiar.Location = new System.Drawing.Point(258, 38);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(105, 20);
            this.btncambiar.TabIndex = 3;
            this.btncambiar.Text = "Generar";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 68);
            this.Controls.Add(this.btncambiar);
            this.Controls.Add(this.btnexaminar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtarchivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Catalogo";
            this.Text = "Catálogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtarchivo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnexaminar;
        private System.Windows.Forms.Button btncambiar;
    }
}

