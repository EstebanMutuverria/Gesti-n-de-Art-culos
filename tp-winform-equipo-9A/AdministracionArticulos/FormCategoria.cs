using Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionArticulos
{
    public partial class FormCategoria : Form
    {
        private Categoria categoria = null;
        public FormCategoria()
        {
            InitializeComponent();
        }

        public FormCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaServices service = new CategoriaServices();

            try
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }

                categoria.Descripcion = txtDescripcionCat.Text;

                if (ErrorsInFields(service) == false)
                {
                    if (categoria.Id != 0 && !service.repeatedDescripcion(categoria.Descripcion))
                    {
                        service.modify(categoria);
                        MessageBox.Show("Categoría modificada exitosamente");
                        Close();
                    }
                    else
                    {
                        if (!service.repeatedDescripcion(categoria.Descripcion))
                        {
                            service.add(categoria);
                            MessageBox.Show("Categoría agregada exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error: Descripción de categoría repetida\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                ErrorsInFields(service);
            }
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargar()
        {
            CategoriaServices services = new CategoriaServices();

            try
            {
                lbPanelCategoria.Text = "Agregando Categoría";
                btnAceptarCategoria.Text = "Agregar";
                if (categoria != null) 
                {
                    lbPanelCategoria.Text = "Modificando Categoría";
                    btnAceptarCategoria.Text = "Modificar";
                    txtDescripcionCat.Text = categoria.Descripcion;
                }
            }
            catch (Exception ex)
            {

              throw ex;
                    
            }

        }

        private bool ErrorsInFields(CategoriaServices service)
        {
            try
            {
                bool response = false;
                var resultadosValidacion = service.ValidateTypes(categoria);

                foreach (var resultado in resultadosValidacion)
                {
                    MessageBox.Show(resultado.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void FormCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
