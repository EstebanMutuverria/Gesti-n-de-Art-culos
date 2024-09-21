namespace AdministracionArticulos
{
    partial class FormImagen
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
            this.dgImagenes = new System.Windows.Forms.DataGridView();
            this.pbPanelImagenes = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.btnVerImagen = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanelImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgImagenes
            // 
            this.dgImagenes.AllowUserToResizeColumns = false;
            this.dgImagenes.AllowUserToResizeRows = false;
            this.dgImagenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImagenes.Location = new System.Drawing.Point(12, 24);
            this.dgImagenes.Name = "dgImagenes";
            this.dgImagenes.ReadOnly = true;
            this.dgImagenes.RowHeadersWidth = 51;
            this.dgImagenes.RowTemplate.Height = 24;
            this.dgImagenes.Size = new System.Drawing.Size(634, 190);
            this.dgImagenes.TabIndex = 0;
            this.dgImagenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgImagenes_CellClick);
            // 
            // pbPanelImagenes
            // 
            this.pbPanelImagenes.Location = new System.Drawing.Point(188, 319);
            this.pbPanelImagenes.Name = "pbPanelImagenes";
            this.pbPanelImagenes.Size = new System.Drawing.Size(288, 288);
            this.pbPanelImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPanelImagenes.TabIndex = 1;
            this.pbPanelImagenes.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(188, 273);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(142, 40);
            this.btnAgregarImagen.TabIndex = 2;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.Location = new System.Drawing.Point(12, 554);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(142, 53);
            this.btnEliminarImagen.TabIndex = 3;
            this.btnEliminarImagen.Text = "Eliminar Imagen Seleccionada";
            this.btnEliminarImagen.UseVisualStyleBackColor = true;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(116, 245);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(423, 22);
            this.txtUrlImagen.TabIndex = 4;
            this.txtUrlImagen.Click += new System.EventHandler(this.txtUrlImagen_Click);
            // 
            // btnVerImagen
            // 
            this.btnVerImagen.Location = new System.Drawing.Point(336, 273);
            this.btnVerImagen.Name = "btnVerImagen";
            this.btnVerImagen.Size = new System.Drawing.Size(142, 40);
            this.btnVerImagen.TabIndex = 5;
            this.btnVerImagen.Text = "Ver";
            this.btnVerImagen.UseVisualStyleBackColor = true;
            this.btnVerImagen.Click += new System.EventHandler(this.btnVerImagen_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(504, 554);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(142, 53);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(658, 619);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVerImagen);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pbPanelImagenes);
            this.Controls.Add(this.dgImagenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Imagenes";
            this.Load += new System.EventHandler(this.FormImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanelImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgImagenes;
        private System.Windows.Forms.PictureBox pbPanelImagenes;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnEliminarImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button btnVerImagen;
        private System.Windows.Forms.Button btnCerrar;
    }
}