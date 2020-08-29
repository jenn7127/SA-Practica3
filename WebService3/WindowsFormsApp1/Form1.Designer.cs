namespace WindowsFormsApp1
{
    partial class Repartidor
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
            this.lblOrdenRep = new System.Windows.Forms.Label();
            this.txtOrdenRep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOrdenRep = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrdencam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncambiar = new System.Windows.Forms.Button();
            this.lblCambio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOrdenRep
            // 
            this.lblOrdenRep.AutoSize = true;
            this.lblOrdenRep.Location = new System.Drawing.Point(106, 126);
            this.lblOrdenRep.Name = "lblOrdenRep";
            this.lblOrdenRep.Size = new System.Drawing.Size(0, 17);
            this.lblOrdenRep.TabIndex = 19;
            // 
            // txtOrdenRep
            // 
            this.txtOrdenRep.Location = new System.Drawing.Point(186, 87);
            this.txtOrdenRep.Name = "txtOrdenRep";
            this.txtOrdenRep.Size = new System.Drawing.Size(100, 22);
            this.txtOrdenRep.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "No de Orden ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Obtener estado de Orden";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnOrdenRep
            // 
            this.btnOrdenRep.Location = new System.Drawing.Point(322, 87);
            this.btnOrdenRep.Name = "btnOrdenRep";
            this.btnOrdenRep.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenRep.TabIndex = 15;
            this.btnOrdenRep.Text = "Obtener ";
            this.btnOrdenRep.UseVisualStyleBackColor = true;
            this.btnOrdenRep.Click += new System.EventHandler(this.btnOrdenRep_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(608, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "___________________________________________________________________________";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtOrdencam
            // 
            this.txtOrdencam.Location = new System.Drawing.Point(212, 226);
            this.txtOrdencam.Name = "txtOrdencam";
            this.txtOrdencam.Size = new System.Drawing.Size(100, 22);
            this.txtOrdencam.TabIndex = 23;
            this.txtOrdencam.TextChanged += new System.EventHandler(this.txtOrdenRes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "No de Orden ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cambiar el estado de la orden";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btncambiar
            // 
            this.btncambiar.Location = new System.Drawing.Point(348, 226);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(75, 23);
            this.btncambiar.TabIndex = 20;
            this.btncambiar.Text = "Cambiar";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Click += new System.EventHandler(this.btnEstadoRes_Click);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(109, 275);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(0, 17);
            this.lblCambio.TabIndex = 25;
            // 
            // Repartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrdencam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncambiar);
            this.Controls.Add(this.lblOrdenRep);
            this.Controls.Add(this.txtOrdenRep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOrdenRep);
            this.Name = "Repartidor";
            this.Text = "Repartidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrdenRep;
        private System.Windows.Forms.TextBox txtOrdenRep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOrdenRep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrdencam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncambiar;
        private System.Windows.Forms.Label lblCambio;
    }
}

