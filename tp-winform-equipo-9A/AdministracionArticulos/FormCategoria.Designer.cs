namespace AdministracionArticulos
{
    partial class FormCategoria
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
            this.txtDescripcionCat = new System.Windows.Forms.TextBox();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btnAceptarCategoria = new System.Windows.Forms.Button();
            this.lblDescripcionCat = new System.Windows.Forms.Label();
            this.lbPanelCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescripcionCat
            // 
            this.txtDescripcionCat.Location = new System.Drawing.Point(138, 75);
            this.txtDescripcionCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionCat.Name = "txtDescripcionCat";
            this.txtDescripcionCat.Size = new System.Drawing.Size(184, 22);
            this.txtDescripcionCat.TabIndex = 29;
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.Location = new System.Drawing.Point(207, 134);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(115, 45);
            this.btnCancelarCategoria.TabIndex = 28;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // btnAceptarCategoria
            // 
            this.btnAceptarCategoria.Location = new System.Drawing.Point(17, 134);
            this.btnAceptarCategoria.Name = "btnAceptarCategoria";
            this.btnAceptarCategoria.Size = new System.Drawing.Size(115, 45);
            this.btnAceptarCategoria.TabIndex = 27;
            this.btnAceptarCategoria.Text = "Agregar";
            this.btnAceptarCategoria.UseVisualStyleBackColor = true;
            this.btnAceptarCategoria.Click += new System.EventHandler(this.btnAceptarCategoria_Click);
            // 
            // lblDescripcionCat
            // 
            this.lblDescripcionCat.AutoSize = true;
            this.lblDescripcionCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCat.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcionCat.Location = new System.Drawing.Point(12, 72);
            this.lblDescripcionCat.Name = "lblDescripcionCat";
            this.lblDescripcionCat.Size = new System.Drawing.Size(120, 25);
            this.lblDescripcionCat.TabIndex = 26;
            this.lblDescripcionCat.Text = "Descripción:";
            // 
            // lbPanelCategoria
            // 
            this.lbPanelCategoria.AutoEllipsis = true;
            this.lbPanelCategoria.AutoSize = true;
            this.lbPanelCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPanelCategoria.Location = new System.Drawing.Point(12, 9);
            this.lbPanelCategoria.Name = "lbPanelCategoria";
            this.lbPanelCategoria.Size = new System.Drawing.Size(0, 22);
            this.lbPanelCategoria.TabIndex = 30;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(348, 197);
            this.Controls.Add(this.lbPanelCategoria);
            this.Controls.Add(this.txtDescripcionCat);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnAceptarCategoria);
            this.Controls.Add(this.lblDescripcionCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Categoría";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcionCat;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btnAceptarCategoria;
        private System.Windows.Forms.Label lblDescripcionCat;
        private System.Windows.Forms.Label lbPanelCategoria;
    }
}