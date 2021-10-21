
namespace EncriptadoraWindowsForms
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblMensajeTexto = new System.Windows.Forms.Label();
            this.lblMensajeClaveDes = new System.Windows.Forms.Label();
            this.txtClaveDes = new System.Windows.Forms.TextBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(89, 12);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(286, 30);
            this.txtTexto.TabIndex = 0;
            // 
            // lblMensajeTexto
            // 
            this.lblMensajeTexto.AutoSize = true;
            this.lblMensajeTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeTexto.Location = new System.Drawing.Point(12, 12);
            this.lblMensajeTexto.Name = "lblMensajeTexto";
            this.lblMensajeTexto.Size = new System.Drawing.Size(68, 25);
            this.lblMensajeTexto.TabIndex = 1;
            this.lblMensajeTexto.Text = "Texto:";
            // 
            // lblMensajeClaveDes
            // 
            this.lblMensajeClaveDes.AutoSize = true;
            this.lblMensajeClaveDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeClaveDes.Location = new System.Drawing.Point(167, 53);
            this.lblMensajeClaveDes.Name = "lblMensajeClaveDes";
            this.lblMensajeClaveDes.Size = new System.Drawing.Size(208, 25);
            this.lblMensajeClaveDes.TabIndex = 2;
            this.lblMensajeClaveDes.Text = "Clave Desencriptacion";
            // 
            // txtClaveDes
            // 
            this.txtClaveDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveDes.Location = new System.Drawing.Point(17, 48);
            this.txtClaveDes.Name = "txtClaveDes";
            this.txtClaveDes.Size = new System.Drawing.Size(144, 30);
            this.txtClaveDes.TabIndex = 3;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.BackColor = System.Drawing.Color.Green;
            this.btnEncriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncriptar.Location = new System.Drawing.Point(17, 84);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(173, 53);
            this.btnEncriptar.TabIndex = 4;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = false;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.BackColor = System.Drawing.Color.Red;
            this.btnDesencriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesencriptar.Location = new System.Drawing.Point(196, 84);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(179, 53);
            this.btnDesencriptar.TabIndex = 5;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = false;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // txtPantalla
            // 
            this.txtPantalla.Enabled = false;
            this.txtPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.Location = new System.Drawing.Point(17, 143);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(358, 30);
            this.txtPantalla.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 189);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtClaveDes);
            this.Controls.Add(this.lblMensajeClaveDes);
            this.Controls.Add(this.lblMensajeTexto);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblMensajeTexto;
        private System.Windows.Forms.Label lblMensajeClaveDes;
        private System.Windows.Forms.TextBox txtClaveDes;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.TextBox txtPantalla;
    }
}

