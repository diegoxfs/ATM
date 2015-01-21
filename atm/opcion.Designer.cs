namespace atm
{
    partial class opcion
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
            this.btnConsultarSaldo = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.txtRetirar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConsultarSaldo
            // 
            this.btnConsultarSaldo.Location = new System.Drawing.Point(85, 44);
            this.btnConsultarSaldo.Name = "btnConsultarSaldo";
            this.btnConsultarSaldo.Size = new System.Drawing.Size(110, 48);
            this.btnConsultarSaldo.TabIndex = 0;
            this.btnConsultarSaldo.Text = "Consultar Saldo";
            this.btnConsultarSaldo.UseVisualStyleBackColor = true;
            this.btnConsultarSaldo.Click += new System.EventHandler(this.btnConsultarSaldo_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(85, 111);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(110, 44);
            this.btnRetirar.TabIndex = 1;
            this.btnRetirar.Text = "Retirar Dinero";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // txtRetirar
            // 
            this.txtRetirar.Location = new System.Drawing.Point(85, 175);
            this.txtRetirar.Name = "txtRetirar";
            this.txtRetirar.Size = new System.Drawing.Size(110, 20);
            this.txtRetirar.TabIndex = 2;
            // 
            // opcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtRetirar);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnConsultarSaldo);
            this.Name = "opcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "opcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarSaldo;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.TextBox txtRetirar;
    }
}