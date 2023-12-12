namespace Hagamos_un_Fork
{
    partial class Hagamos_un_Fork
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtIntro = new System.Windows.Forms.TextBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(24, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(394, 59);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "¡Hagamos un Fork!";
            // 
            // btnAccion
            // 
            this.btnAccion.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAccion.Location = new System.Drawing.Point(34, 93);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(144, 42);
            this.btnAccion.TabIndex = 1;
            this.btnAccion.Text = "Acción";
            this.btnAccion.UseVisualStyleBackColor = false;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(27, 208);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(674, 42);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Estoy esperando el merge de quien haga un fork";
            // 
            // txtIntro
            // 
            this.txtIntro.Location = new System.Drawing.Point(196, 98);
            this.txtIntro.Name = "txtIntro";
            this.txtIntro.Size = new System.Drawing.Size(396, 47);
            this.txtIntro.TabIndex = 2;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.Color.White;
            this.lblIntro.Location = new System.Drawing.Point(27, 153);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(41, 39);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "...";
            // 
            // Hagamos_un_Fork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(643, 303);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.txtIntro);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Hagamos_un_Fork";
            this.Text = "¡Hagamos un Fork!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtIntro;
        private System.Windows.Forms.Label lblIntro;
    }
}


