using Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionArticulos
{
    public partial class FormImagen : Form
    {
        private List<Imagen> listImagen;
        private Imagen Imagen = null;
        private int ArticuloId = 0;

        public FormImagen(int ArticuloId)
        {
            InitializeComponent();
            this.ArticuloId = ArticuloId;
        }

        private void FormImagen_Load(object sender, EventArgs e)
        {
            cargar();
        }
        /*---------------- EVENTS ----------------*/
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            ImagenServices service = new ImagenServices();

            try
            {
                Imagen = new Imagen();

                Imagen.IdArticulo = ArticuloId;
                Imagen.ImagenUrl = txtUrlImagen.Text;

                service.add(Imagen);
                MessageBox.Show("Articulo agregado exitosamente");
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void btnVerImagen_Click(object sender, EventArgs e)
        {
            try
            {
                uploadImagePanelArticulos(txtUrlImagen.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgImagenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Imagen selectedRow;
                    selectedRow = (Imagen)dgImagenes.CurrentRow.DataBoundItem;

                    uploadImagePanelArticulos(selectedRow.ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtUrlImagen_Click(object sender, EventArgs e)
        {
            try
            {
                uploadImagePanelArticulos("DefaultImage");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            ImagenServices service = new ImagenServices();
            Imagen selectedImage;

            try
            {
                selectedImage = (Imagen)dgImagenes.CurrentRow.DataBoundItem;

                DialogResult response = MessageBox.Show($"¿Éstá seguro de eliminar la imagen seleccionada?", "Eliminar Imagen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                {
                    service.delete(selectedImage);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /*---------------- FUNCTIONS ----------------*/

        private void cargar()
        {
            ImagenServices imagenServices = new ImagenServices();

            try
            {
                listImagen = imagenServices.listar(ArticuloId);
                dgImagenes.DataSource = listImagen;
                dgImagenes.Columns["Id"].Visible = false;
                dgImagenes.Columns["IdArticulo"].Visible = false;
                txtUrlImagen.Text = "";
                AjustarDgView(dgImagenes, 5);

                if (listImagen.Count > 0)
                {
                    uploadImagePanelArticulos(listImagen[0].ToString());
                }
                else
                {
                    uploadImagePanelArticulos("DefaultImage");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AjustarDgView(DataGridView dataGridView, int maxVisibleRows)
        {
            int recordCount = dataGridView.Rows.Count;
            int rowHeight = dataGridView.RowTemplate.Height;
            int headerHeight = dataGridView.ColumnHeadersHeight;


            int totalHeight = (recordCount > maxVisibleRows ? maxVisibleRows : recordCount) * rowHeight + headerHeight + 2;

            dataGridView.Height = totalHeight;

            if (recordCount > maxVisibleRows)
            {
                dataGridView.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                dataGridView.ScrollBars = ScrollBars.None;
            }
        }

        private void uploadImagePanelArticulos(string image)
        {
            try
            {
                pbPanelImagenes.Load(image);
            }
            catch (Exception ex)
            {
                pbPanelImagenes.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

    }
}
