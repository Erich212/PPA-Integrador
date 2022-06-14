namespace PPA_Integrador
{
    partial class FormularioCasoUso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_irPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_irPrincipal
            // 
            this.btn_irPrincipal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_irPrincipal.Location = new System.Drawing.Point(509, 302);
            this.btn_irPrincipal.Name = "btn_irPrincipal";
            this.btn_irPrincipal.Size = new System.Drawing.Size(158, 64);
            this.btn_irPrincipal.TabIndex = 0;
            this.btn_irPrincipal.Text = "Acceder";
            this.btn_irPrincipal.UseVisualStyleBackColor = true;
            this.btn_irPrincipal.Click += new System.EventHandler(this.btn_irPrincipal_Click);
            // 
            // FormularioLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 884);
            this.Controls.Add(this.btn_irPrincipal);
            this.Name = "FormularioLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_irPrincipal;
    }
}