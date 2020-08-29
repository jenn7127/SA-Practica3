namespace Restaurante
{
    partial class Resturante
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
            this.lbEnviarOrden = new System.Windows.Forms.Label();
            this.btnSendOrden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbEnviarOrden
            // 
            this.lbEnviarOrden.AutoSize = true;
            this.lbEnviarOrden.Location = new System.Drawing.Point(121, 169);
            this.lbEnviarOrden.Name = "lbEnviarOrden";
            this.lbEnviarOrden.Size = new System.Drawing.Size(0, 17);
            this.lbEnviarOrden.TabIndex = 5;
            // 
            // btnSendOrden
            // 
            this.btnSendOrden.Location = new System.Drawing.Point(409, 85);
            this.btnSendOrden.Name = "btnSendOrden";
            this.btnSendOrden.Size = new System.Drawing.Size(110, 23);
            this.btnSendOrden.TabIndex = 4;
            this.btnSendOrden.Text = "Enviar Orden";
            this.btnSendOrden.UseVisualStyleBackColor = true;
            this.btnSendOrden.Click += new System.EventHandler(this.btnSendOrden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Presione el boton para enviar orden";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // Resturante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbEnviarOrden);
            this.Controls.Add(this.btnSendOrden);
            this.Controls.Add(this.label1);
            this.Name = "Resturante";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnviarOrden;
        private System.Windows.Forms.Button btnSendOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

