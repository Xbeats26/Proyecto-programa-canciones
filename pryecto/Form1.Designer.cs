namespace pryecto
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
            this.btnenviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcancion = new System.Windows.Forms.TextBox();
            this.listcanciones = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(951, 428);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(197, 38);
            this.btnenviar.TabIndex = 1;
            this.btnenviar.Text = "enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(837, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "No encuentras tu cancion?";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(856, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Envianos su nombre para que aparezca en la siguiente fiesta";
            // 
            // txtcancion
            // 
            this.txtcancion.Location = new System.Drawing.Point(951, 402);
            this.txtcancion.Name = "txtcancion";
            this.txtcancion.Size = new System.Drawing.Size(302, 20);
            this.txtcancion.TabIndex = 4;
            // 
            // listcanciones
            // 
            this.listcanciones.FormattingEnabled = true;
            this.listcanciones.Location = new System.Drawing.Point(117, 128);
            this.listcanciones.Name = "listcanciones";
            this.listcanciones.Size = new System.Drawing.Size(120, 95);
            this.listcanciones.TabIndex = 5;
            this.listcanciones.SelectedIndexChanged += new System.EventHandler(this.listcanciones_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(629, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Escoge aqui tu cancion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 590);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listcanciones);
            this.Controls.Add(this.txtcancion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnenviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcancion;
        private System.Windows.Forms.ListBox listcanciones;
        private System.Windows.Forms.Label label3;
    }
}

