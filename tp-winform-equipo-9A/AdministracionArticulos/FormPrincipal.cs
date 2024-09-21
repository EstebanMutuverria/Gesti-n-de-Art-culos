using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Services;

namespace AdministracionArticulos
{
    public partial class formPrincipal : Form
    {
        private List<Articulo> listArticulos;
        private List<Categoria> listCategorias;
        private List<Marca> listMarca;
        private List<string> listImagenes;
        private bool Marca;

        public formPrincipal()
        {
            InitializeComponent();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            cargarGrids();
            hideColumns();
        }

        /*---------------- EVENTS ----------------*/

        private void btAgregar_Click(object sender, EventArgs e)
        {
           if (rdArticulos.Checked)
            {
                FormArticulo articulo = new FormArticulo();
                articulo.ShowDialog();
            }
           else if (rdMarcas.Checked)
            {
                FormMarca marca = new FormMarca();
                marca.ShowDialog();
            }
            else
            {
             
                FormCategoria categoria = new FormCategoria();
                categoria.ShowDialog();
            }
            cargarGrids();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
              if (rdArticulos.Checked)
              {
                  Articulo selectedArt;
                  if (dgArticulos.CurrentRow != null)
                  {
                      selectedArt = (Articulo)dgArticulos.CurrentRow.DataBoundItem;
                      FormArticulo articulo = new FormArticulo(selectedArt);
                      articulo.ShowDialog();
                  }else
                  {
                        MessageBox.Show("Error: Debe seleccionar un artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
              }
              else if (rdMarcas.Checked)
              {
                  Marca selectedMarca;
                    if (dgMarcas.CurrentRow != null)
                    {
                      selectedMarca = (Marca)dgMarcas.CurrentRow.DataBoundItem;
                      FormMarca marca = new FormMarca(selectedMarca);
                      marca.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error: Debe seleccionar una marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
              }
              else
              {
                  Categoria selectedCat;
                    if (dgCategorias.CurrentRow != null)
                    {
                      selectedCat = (Categoria)dgCategorias.CurrentRow.DataBoundItem;
                      FormCategoria categoria = new FormCategoria(selectedCat);
                      categoria.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error: Debe seleccionar una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
              }
              cargarGrids();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (rdArticulos.Checked)
            {
                deleteArticulo();
            }
            else if (rdMarcas.Checked)
            {
                deleteMarca();
            }
            else
            {
                deleteCategoria();
            }
            cargarGrids();
        }

        private void dgArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ArticuloServices articuloService = new ArticuloServices();
                if (dgArticulos.CurrentRow != null)
                {
                  Articulo articuloSeleccionado = (Articulo)dgArticulos.CurrentRow.DataBoundItem;
                  listImagenes = articuloService.listarImagenes(articuloSeleccionado.Codigo);
                }
                nudImagenesArticulos.Value = 0;
                
                if (listImagenes.Count > 0)
                {
                    nudImagenesArticulos.Maximum = listImagenes.Count;
                    uploadImage(listImagenes[(int)nudImagenesArticulos.Value]);
                }
                else
                {
                    nudImagenesArticulos.Maximum = 0;
                    uploadImage("DefaultImage");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void nudImagenesArticulos_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgArticulos.CurrentRow != null && dgArticulos.CurrentRow.DataBoundItem != null)
                { 
                    ArticuloServices articuloService = new ArticuloServices();
                    Articulo articuloSeleccionado = (Articulo)dgArticulos.CurrentRow.DataBoundItem;
                    
                    if (articuloSeleccionado != null)
                    {
                        listImagenes = articuloService.listarImagenes(articuloSeleccionado.Codigo);
                        if (listImagenes.Count > 0)
                        {
                            nudImagenesArticulos.Maximum = listImagenes.Count - 1;
                            uploadImage(listImagenes[(int)nudImagenesArticulos.Value]);
                        }
                        else
                        {
                            uploadImage("DefaultImage");
                            nudImagenesArticulos.Maximum = 0;
                        }
                    }
                    else
                    {
                        uploadImage("DefaultImage");
                        nudImagenesArticulos.Maximum = 0;
                    }
                }
                else
                {
                    uploadImage("DefaultImage");
                    nudImagenesArticulos.Maximum = 0;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*---------------- FUNCTIONS ----------------*/

        private void cargarGrids()
        {
            ArticuloServices articuloService = new ArticuloServices();
            CategoriaServices categoriaService = new CategoriaServices();
            MarcaServices marcaService = new MarcaServices();

            try
            {
                listArticulos = articuloService.listar();
                dgArticulos.DataSource = listArticulos;
                if (listArticulos.Count > 0)
                {
                    listImagenes = articuloService.listarImagenes(listArticulos[0].Codigo);
                    
                    if (listImagenes.Count > 0)
                    {
                        uploadImage(listImagenes[0]);
                    }
                    else
                    {
                        uploadImage("DefaultImage");
                    }
                }
                else
                {
                    uploadImage("DefaultImage");
                }
                AjustarDgView(dgArticulos, 6);


                listCategorias = categoriaService.listar();
                dgCategorias.DataSource = listCategorias;
                AjustarDgView(dgCategorias, 6);                        

                listMarca = marcaService.listar();
                dgMarcas.DataSource = listMarca;
                AjustarDgView(dgMarcas, 6);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las grillas. Comuníquese con el Soporte.", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hideColumns()
        {
            dgArticulos.Columns["Id"].Visible = false;
            dgArticulos.Columns["Imagen"].Visible = false;
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

        private void uploadImage(string image)
        {
            try
            {
                pbPcArticulos.Load(image);
            }
            catch (Exception ex)
            {
                pbPcArticulos.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        public void deleteArticulo()
        {
            ArticuloServices service = new ArticuloServices();
            Articulo selectedArt;


            try
            {
                if (dgArticulos.CurrentRow != null)
                {
                  selectedArt = (Articulo)dgArticulos.CurrentRow.DataBoundItem;
                  DialogResult response = MessageBox.Show($"¿Éstá seguro de eliminar el Artículo '{selectedArt.Nombre}' con código '{selectedArt.Codigo}'?", "Eliminar Artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                  
                  if (response == DialogResult.Yes)
                  {
                      service.delete(selectedArt.Id);
                      cargarGrids();
                  }
                }
                else
                {
                    MessageBox.Show("Error: Debe seleccionar un artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteCategoria()
        {
            CategoriaServices service = new CategoriaServices();
            Categoria selectedCat;

            try
            {
                if (dgCategorias.CurrentRow != null)
                {
                    selectedCat = (Categoria)dgCategorias.CurrentRow.DataBoundItem;
                    DialogResult response = MessageBox.Show($"¿Éstá seguro de eliminar la categoria '{selectedCat.Descripcion}'?", "Eliminar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (response == DialogResult.Yes)
                    {
                        service.delete(selectedCat.Id);
                        cargarGrids();
                    }
                }
                else
                {
                    MessageBox.Show("Error: Debe seleccionar una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteMarca()
        {
            MarcaServices service = new MarcaServices();
            Marca selectedMarca;

            try
            {
                if (dgMarcas.CurrentRow != null)
                {
                    selectedMarca = (Marca)dgMarcas.CurrentRow.DataBoundItem;
                    DialogResult response = MessageBox.Show($"¿Éstá seguro de eliminar la marca '{selectedMarca.Descripcion}'?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (response == DialogResult.Yes)
                    {
                        service.delete(selectedMarca.Id);
                        cargarGrids();
                    }
                }
                else
                {
                    MessageBox.Show("Error: Debe seleccionar una marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtFiltroArticulo_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroArticulo.Text;

            if (filtro != "")
            {
             listaFiltrada = listArticulos.FindAll(
                 art =>
                 art.Codigo.ToLower().Contains(filtro.ToLower()) ||
                 art.Nombre.ToLower().Contains(filtro.ToLower()) ||
                 art.Categoria.ToString().ToLower().Contains(filtro.ToLower()) ||
                 art.Marca.ToString().ToLower().Contains(filtro.ToLower())
                 );

            }
            else
            {
                listaFiltrada = listArticulos;
            }


            dgArticulos.DataSource = null;
            dgArticulos.DataSource = listaFiltrada;
            hideColumns();

        }

        private void dgArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgArticulos.CurrentRow != null && dgArticulos.CurrentRow.DataBoundItem != null)
                {
                    ArticuloServices articuloService = new ArticuloServices();
                    Articulo articuloSeleccionado = (Articulo)dgArticulos.CurrentRow.DataBoundItem;

                    if (articuloSeleccionado != null)
                    {
                        listImagenes = articuloService.listarImagenes(articuloSeleccionado.Codigo);
                        if (listImagenes.Count > 0)
                        {
                            nudImagenesArticulos.Maximum = listImagenes.Count - 1;
                            uploadImage(listImagenes[(int)nudImagenesArticulos.Value]);
                        }
                        else
                        {
                            uploadImage("DefaultImage");
                            nudImagenesArticulos.Maximum = 0;
                        }
                    }
                    else
                    {
                        uploadImage("DefaultImage");
                        nudImagenesArticulos.Maximum = 0;
                    }
                }
                else
                {
                    uploadImage("DefaultImage");
                    nudImagenesArticulos.Maximum = 0;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
