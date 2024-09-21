namespace AdministracionArticulos
{
    partial class FormArticulo
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
            this.lbCodigoArticulo = new System.Windows.Forms.Label();
            this.lbNombreArticulo = new System.Windows.Forms.Label();
            this.lbDescripcionArticulo = new System.Windows.Forms.Label();
            this.lbMarcaArticulo = new System.Windows.Forms.Label();
            this.lbCategoriaArticulo = new System.Windows.Forms.Label();
            this.lbPrecioArticulo = new System.Windows.Forms.Label();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.txtPrecioArticulo = new System.Windows.Forms.TextBox();
            this.lbPanelArticulo = new System.Windows.Forms.Label();
            this.btnAceptarArticulo = new System.Windows.Forms.Button();
            this.btnCancelarArticulo = new System.Windows.Forms.Button();
            this.cbMarcaArticulo = new System.Windows.Forms.ComboBox();
            this.cbCategoriaArticulo = new System.Windows.Forms.ComboBox();
            this.pbPanelArticulo = new System.Windows.Forms.PictureBox();
            this.nudImagenesPanelArticulo = new System.Windows.Forms.NumericUpDown();
            this.btnGestionarImagenes = new System.Windows.Forms.Button();
            this.lbGestionarImagenes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanelArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImagenesPanelArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigoArticulo
            // 
            this.lbCodigoArticulo.AutoSize = true;
            this.lbCodigoArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoArticulo.Location = new System.Drawing.Point(53, 94);
            this.lbCodigoArticulo.Name = "lbCodigoArticulo";
            this.lbCodigoArticulo.Size = new System.Drawing.Size(96, 26);
            this.lbCodigoArticulo.TabIndex = 0;
            this.lbCodigoArticulo.Text = "Código: ";
            // 
            // lbNombreArticulo
            // 
            this.lbNombreArticulo.AutoSize = true;
            this.lbNombreArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreArticulo.Location = new System.Drawing.Point(43, 135);
            this.lbNombreArticulo.Name = "lbNombreArticulo";
            this.lbNombreArticulo.Size = new System.Drawing.Size(107, 26);
            this.lbNombreArticulo.TabIndex = 1;
            this.lbNombreArticulo.Text = "Nombre: ";
            // 
            // lbDescripcionArticulo
            // 
            this.lbDescripcionArticulo.AutoSize = true;
            this.lbDescripcionArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcionArticulo.Location = new System.Drawing.Point(5, 180);
            this.lbDescripcionArticulo.Name = "lbDescripcionArticulo";
            this.lbDescripcionArticulo.Size = new System.Drawing.Size(136, 26);
            this.lbDescripcionArticulo.TabIndex = 2;
            this.lbDescripcionArticulo.Text = "Descripción:";
            // 
            // lbMarcaArticulo
            // 
            this.lbMarcaArticulo.AutoSize = true;
            this.lbMarcaArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcaArticulo.Location = new System.Drawing.Point(61, 222);
            this.lbMarcaArticulo.Name = "lbMarcaArticulo";
            this.lbMarcaArticulo.Size = new System.Drawing.Size(81, 26);
            this.lbMarcaArticulo.TabIndex = 3;
            this.lbMarcaArticulo.Text = "Marca:";
            // 
            // lbCategoriaArticulo
            // 
            this.lbCategoriaArticulo.AutoSize = true;
            this.lbCategoriaArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriaArticulo.Location = new System.Drawing.Point(24, 261);
            this.lbCategoriaArticulo.Name = "lbCategoriaArticulo";
            this.lbCategoriaArticulo.Size = new System.Drawing.Size(118, 26);
            this.lbCategoriaArticulo.TabIndex = 4;
            this.lbCategoriaArticulo.Text = "Categoria:";
            // 
            // lbPrecioArticulo
            // 
            this.lbPrecioArticulo.AutoSize = true;
            this.lbPrecioArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioArticulo.Location = new System.Drawing.Point(61, 303);
            this.lbPrecioArticulo.Name = "lbPrecioArticulo";
            this.lbPrecioArticulo.Size = new System.Drawing.Size(89, 26);
            this.lbPrecioArticulo.TabIndex = 5;
            this.lbPrecioArticulo.Text = "Precio: ";
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(160, 98);
            this.txtCodigoArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(151, 22);
            this.txtCodigoArticulo.TabIndex = 0;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(160, 140);
            this.txtNombreArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(151, 22);
            this.txtNombreArticulo.TabIndex = 1;
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(160, 180);
            this.txtDescripcionArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(151, 22);
            this.txtDescripcionArticulo.TabIndex = 2;
            // 
            // txtPrecioArticulo
            // 
            this.txtPrecioArticulo.Location = new System.Drawing.Point(160, 308);
            this.txtPrecioArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioArticulo.Name = "txtPrecioArticulo";
            this.txtPrecioArticulo.Size = new System.Drawing.Size(151, 22);
            this.txtPrecioArticulo.TabIndex = 5;
            // 
            // lbPanelArticulo
            // 
            this.lbPanelArticulo.AutoEllipsis = true;
            this.lbPanelArticulo.AutoSize = true;
            this.lbPanelArticulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPanelArticulo.Location = new System.Drawing.Point(11, 18);
            this.lbPanelArticulo.Name = "lbPanelArticulo";
            this.lbPanelArticulo.Size = new System.Drawing.Size(0, 35);
            this.lbPanelArticulo.TabIndex = 14;
            // 
            // btnAceptarArticulo
            // 
            this.btnAceptarArticulo.Location = new System.Drawing.Point(428, 395);
            this.btnAceptarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptarArticulo.Name = "btnAceptarArticulo";
            this.btnAceptarArticulo.Size = new System.Drawing.Size(151, 46);
            this.btnAceptarArticulo.TabIndex = 7;
            this.btnAceptarArticulo.UseVisualStyleBackColor = true;
            this.btnAceptarArticulo.Click += new System.EventHandler(this.btnAceptarArticulo_Click);
            // 
            // btnCancelarArticulo
            // 
            this.btnCancelarArticulo.Location = new System.Drawing.Point(611, 395);
            this.btnCancelarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarArticulo.Name = "btnCancelarArticulo";
            this.btnCancelarArticulo.Size = new System.Drawing.Size(151, 46);
            this.btnCancelarArticulo.TabIndex = 8;
            this.btnCancelarArticulo.Text = "Cancelar";
            this.btnCancelarArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarArticulo.Click += new System.EventHandler(this.btnCancelarArticulo_Click);
            // 
            // cbMarcaArticulo
            // 
            this.cbMarcaArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarcaArticulo.FormattingEnabled = true;
            this.cbMarcaArticulo.Location = new System.Drawing.Point(160, 222);
            this.cbMarcaArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMarcaArticulo.Name = "cbMarcaArticulo";
            this.cbMarcaArticulo.Size = new System.Drawing.Size(151, 24);
            this.cbMarcaArticulo.TabIndex = 3;
            // 
            // cbCategoriaArticulo
            // 
            this.cbCategoriaArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaArticulo.FormattingEnabled = true;
            this.cbCategoriaArticulo.Location = new System.Drawing.Point(160, 266);
            this.cbCategoriaArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoriaArticulo.Name = "cbCategoriaArticulo";
            this.cbCategoriaArticulo.Size = new System.Drawing.Size(151, 24);
            this.cbCategoriaArticulo.TabIndex = 4;
            // 
            // pbPanelArticulo
            // 
            this.pbPanelArticulo.Location = new System.Drawing.Point(445, 94);
            this.pbPanelArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPanelArticulo.Name = "pbPanelArticulo";
            this.pbPanelArticulo.Size = new System.Drawing.Size(285, 235);
            this.pbPanelArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPanelArticulo.TabIndex = 19;
            this.pbPanelArticulo.TabStop = false;
            // 
            // nudImagenesPanelArticulo
            // 
            this.nudImagenesPanelArticulo.Location = new System.Drawing.Point(531, 335);
            this.nudImagenesPanelArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudImagenesPanelArticulo.Name = "nudImagenesPanelArticulo";
            this.nudImagenesPanelArticulo.ReadOnly = true;
            this.nudImagenesPanelArticulo.Size = new System.Drawing.Size(120, 22);
            this.nudImagenesPanelArticulo.TabIndex = 9;
            this.nudImagenesPanelArticulo.Visible = false;
            this.nudImagenesPanelArticulo.ValueChanged += new System.EventHandler(this.nudImagenesPanelArticulo_ValueChanged);
            // 
            // btnGestionarImagenes
            // 
            this.btnGestionarImagenes.Location = new System.Drawing.Point(159, 356);
            this.btnGestionarImagenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestionarImagenes.Name = "btnGestionarImagenes";
            this.btnGestionarImagenes.Size = new System.Drawing.Size(151, 46);
            this.btnGestionarImagenes.TabIndex = 6;
            this.btnGestionarImagenes.Text = "Gestionar Imagenes";
            this.btnGestionarImagenes.UseVisualStyleBackColor = true;
            this.btnGestionarImagenes.Click += new System.EventHandler(this.btnGestionarImagenes_Click);
            // 
            // lbGestionarImagenes
            // 
            this.lbGestionarImagenes.AutoSize = true;
            this.lbGestionarImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGestionarImagenes.Location = new System.Drawing.Point(124, 356);
            this.lbGestionarImagenes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGestionarImagenes.Name = "lbGestionarImagenes";
            this.lbGestionarImagenes.Size = new System.Drawing.Size(187, 54);
            this.lbGestionarImagenes.TabIndex = 20;
            this.lbGestionarImagenes.Text = "Agregue el Artículo para\r\n    poder gestionar las \r\n            imagenes";
            // 
            // FormArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(784, 458);
            this.Controls.Add(this.lbGestionarImagenes);
            this.Controls.Add(this.btnGestionarImagenes);
            this.Controls.Add(this.nudImagenesPanelArticulo);
            this.Controls.Add(this.pbPanelArticulo);
            this.Controls.Add(this.cbCategoriaArticulo);
            this.Controls.Add(this.cbMarcaArticulo);
            this.Controls.Add(this.btnCancelarArticulo);
            this.Controls.Add(this.btnAceptarArticulo);
            this.Controls.Add(this.lbPanelArticulo);
            this.Controls.Add(this.txtPrecioArticulo);
            this.Controls.Add(this.txtDescripcionArticulo);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.lbPrecioArticulo);
            this.Controls.Add(this.lbCategoriaArticulo);
            this.Controls.Add(this.lbMarcaArticulo);
            this.Controls.Add(this.lbDescripcionArticulo);
            this.Controls.Add(this.lbNombreArticulo);
            this.Controls.Add(this.lbCodigoArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Artículo";
            this.Load += new System.EventHandler(this.FormArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPanelArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImagenesPanelArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigoArticulo;
        private System.Windows.Forms.Label lbNombreArticulo;
        private System.Windows.Forms.Label lbDescripcionArticulo;
        private System.Windows.Forms.Label lbMarcaArticulo;
        private System.Windows.Forms.Label lbCategoriaArticulo;
        private System.Windows.Forms.Label lbPrecioArticulo;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtDescripcionArticulo;
        private System.Windows.Forms.TextBox txtPrecioArticulo;
        private System.Windows.Forms.Label lbPanelArticulo;
        private System.Windows.Forms.Button btnAceptarArticulo;
        private System.Windows.Forms.Button btnCancelarArticulo;
        private System.Windows.Forms.ComboBox cbMarcaArticulo;
        private System.Windows.Forms.ComboBox cbCategoriaArticulo;
        private System.Windows.Forms.PictureBox pbPanelArticulo;
        private System.Windows.Forms.NumericUpDown nudImagenesPanelArticulo;
        private System.Windows.Forms.Button btnGestionarImagenes;
        private System.Windows.Forms.Label lbGestionarImagenes;
    }
}