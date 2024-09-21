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
using System.ComponentModel.DataAnnotations;

namespace AdministracionArticulos
{
    public partial class FormArticulo : Form
    {
        private Articulo articulo = null;
        private List<string> listImagenes;

        public FormArticulo()
        {
            InitializeComponent();
        }

        public FormArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        /*---------------- EVENTS ----------------*/

        private void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloServices service = new ArticuloServices();

            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                
                articulo.Codigo = txtCodigoArticulo.Text;
                articulo.Nombre = txtNombreArticulo.Text;
                articulo.Descripcion = txtDescripcionArticulo.Text;
                articulo.Marca = (Marca)cbMarcaArticulo.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoriaArticulo.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecioArticulo.Text);

                if (ErrorsInFields(service) == false)
                {
                    if (articulo.Id != 0)
                    {
                        service.modify(articulo);
                        MessageBox.Show("Articulo modificado exitosamente");
                        Close();
                    }
                    else
                    {
                    
                        if (!service.repeatedCode(articulo.Codigo))
                        {
                            service.add(articulo);
                            MessageBox.Show("Articulo agregado exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error: Código de producto repetido\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorsInFields(service);
            }
        }

        private void FormArticulo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void nudImagenesPanelArticulo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ArticuloServices articuloService = new ArticuloServices();
                listImagenes = articuloService.listarImagenes(articulo.Codigo);

                if (listImagenes.Count > 0)
                {
                    nudImagenesPanelArticulo.Maximum = listImagenes.Count - 1;
                    uploadImagePanelArticulos(listImagenes[(int)nudImagenesPanelArticulo.Value]);
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

        private void btnGestionarImagenes_Click(object sender, EventArgs e)
        {
            FormImagen imagen = new FormImagen(articulo.Id);
            imagen.ShowDialog();
            cargar();
        }

        /*---------------- FUNCTIONS ----------------*/

        private void cargar()
        {
            ArticuloServices articuloService = new ArticuloServices();
            MarcaServices marcaServices = new MarcaServices();
            CategoriaServices categoriaServices = new CategoriaServices();

            try
            {

                lbPanelArticulo.Text = "Agregando Artículo";
                btnAceptarArticulo.Text = "Agregar";
                cbMarcaArticulo.DataSource = marcaServices.listar();
                cbMarcaArticulo.ValueMember = "Id";
                cbMarcaArticulo.DisplayMember = "Descripcion";
                cbCategoriaArticulo.DataSource = categoriaServices.listar();
                cbCategoriaArticulo.ValueMember = "Id";
                cbCategoriaArticulo.DisplayMember = "Descripcion";
                btnGestionarImagenes.Visible = false;
                lbGestionarImagenes.Visible = true;

                if (articulo != null)
                {
                    txtCodigoArticulo.ReadOnly = true;
                    lbPanelArticulo.Text = "Modificando Artículo";
                    btnAceptarArticulo.Text = "Modificar";
                    txtCodigoArticulo.Text = articulo.Codigo;
                    txtNombreArticulo.Text = articulo.Nombre;
                    txtDescripcionArticulo.Text = articulo.Descripcion;
                    cbMarcaArticulo.SelectedValue = articulo.Marca.Id;
                    cbCategoriaArticulo.SelectedValue = articulo.Categoria.Id;
                    txtPrecioArticulo.Text = articulo.Precio.ToString();
                    btnGestionarImagenes.Visible = true;
                    lbGestionarImagenes.Visible = false;


                    nudImagenesPanelArticulo.Visible = true;
                    listImagenes = articuloService.listarImagenes(articulo.Codigo);
                    if (listImagenes.Count > 0)
                    {
                        nudImagenesPanelArticulo.Maximum = listImagenes.Count - 1;
                        uploadImagePanelArticulos(listImagenes[(int)nudImagenesPanelArticulo.Value]);
                    }
                    else
                    {
                        uploadImagePanelArticulos("DefaultImage");
                        nudImagenesPanelArticulo.Maximum = 0;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void uploadImagePanelArticulos(string image)
        {
            try
            {
                pbPanelArticulo.Load(image);
            }
            catch (Exception ex)
            {
                pbPanelArticulo.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        private bool ErrorsInFields(ArticuloServices service)
        {
            try
            {
                bool response = false;
                var resultadosValidacion = service.ValidateTypes(articulo);
                foreach (var resultado in resultadosValidacion)
                {
                    MessageBox.Show(resultado.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (resultadosValidacion.Any())
                {
                    response = true;
                }

                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique los datos cargados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
    }
}
