namespace Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewOrden = new System.Windows.Forms.Button();
            this.lblCrearOrden = new System.Windows.Forms.Label();
            this.btnEstadoRes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrdenRes = new System.Windows.Forms.TextBox();
            this.txtOrdenRep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOrdenRep = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOrdenRes = new System.Windows.Forms.Label();
            this.lblOrdenRep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presione el boton para crear orden";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNewOrden
            // 
            this.btnNewOrden.Location = new System.Drawing.Point(402, 41);
            this.btnNewOrden.Name = "btnNewOrden";
            this.btnNewOrden.Size = new System.Drawing.Size(94, 23);
            this.btnNewOrden.TabIndex = 1;
            this.btnNewOrden.Text = "CrearOrden";
            this.btnNewOrden.UseVisualStyleBackColor = true;
            this.btnNewOrden.Click += new System.EventHandler(this.btnNewOrden_Click);
            // 
            // lblCrearOrden
            // 
            this.lblCrearOrden.AutoSize = true;
            this.lblCrearOrden.Location = new System.Drawing.Point(77, 88);
            this.lblCrearOrden.Name = "lblCrearOrden";
            this.lblCrearOrden.Size = new System.Drawing.Size(0, 17);
            this.lblCrearOrden.TabIndex = 2;
            // 
            // btnEstadoRes
            // 
            this.btnEstadoRes.Location = new System.Drawing.Point(315, 195);
            this.btnEstadoRes.Name = "btnEstadoRes";
            this.btnEstadoRes.Size = new System.Drawing.Size(75, 23);
            this.btnEstadoRes.TabIndex = 3;
            this.btnEstadoRes.Text = "Obtener ";
            this.btnEstadoRes.UseVisualStyleBackColor = true;
            this.btnEstadoRes.Click += new System.EventHandler(this.btnEstadoRes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Obtener estado de Orden del Restaurante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "No de Orden ";
            // 
            // txtOrdenRes
            // 
            this.txtOrdenRes.Location = new System.Drawing.Point(179, 195);
            this.txtOrdenRes.Name = "txtOrdenRes";
            this.txtOrdenRes.Size = new System.Drawing.Size(100, 22);
            this.txtOrdenRes.TabIndex = 6;
            // 
            // txtOrdenRep
            // 
            this.txtOrdenRep.Location = new System.Drawing.Point(182, 331);
            this.txtOrdenRep.Name = "txtOrdenRep";
            this.txtOrdenRep.Size = new System.Drawing.Size(100, 22);
            this.txtOrdenRep.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "No de Orden ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Obtener estado de Orden del Repartidor";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnOrdenRep
            // 
            this.btnOrdenRep.Location = new System.Drawing.Point(318, 331);
            this.btnOrdenRep.Name = "btnOrdenRep";
            this.btnOrdenRep.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenRep.TabIndex = 7;
            this.btnOrdenRep.Text = "Obtener ";
            this.btnOrdenRep.UseVisualStyleBackColor = true;
            this.btnOrdenRep.Click += new System.EventHandler(this.btnOrdenRep_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(608, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "___________________________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(608, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "___________________________________________________________________________";
            // 
            // lblOrdenRes
            // 
            this.lblOrdenRes.AutoSize = true;
            this.lblOrdenRes.Location = new System.Drawing.Point(102, 232);
            this.lblOrdenRes.Name = "lblOrdenRes";
            this.lblOrdenRes.Size = new System.Drawing.Size(0, 17);
            this.lblOrdenRes.TabIndex = 13;
            // 
            // lblOrdenRep
            // 
            this.lblOrdenRep.AutoSize = true;
            this.lblOrdenRep.Location = new System.Drawing.Point(102, 370);
            this.lblOrdenRep.Name = "lblOrdenRep";
            this.lblOrdenRep.Size = new System.Drawing.Size(0, 17);
            this.lblOrdenRep.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.lblOrdenRep);
            this.Controls.Add(this.lblOrdenRes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrdenRep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOrdenRep);
            this.Controls.Add(this.txtOrdenRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEstadoRes);
            this.Controls.Add(this.lblCrearOrden);
            this.Controls.Add(this.btnNewOrden);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cliente ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewOrden;
        private System.Windows.Forms.Label lblCrearOrden;
        private System.Windows.Forms.Button btnEstadoRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrdenRes;
        private System.Windows.Forms.TextBox txtOrdenRep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOrdenRep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOrdenRes;
        private System.Windows.Forms.Label lblOrdenRep;
    }
}

