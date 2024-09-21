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
    public partial class FormMarca : Form
    {
        private Marca marca = null;

        public FormMarca()
        {
            InitializeComponent();
        }
        public FormMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MarcaServices service = new MarcaServices();
            
            try
            {
                if (marca == null)
                {
                    marca = new Marca();
                }

                marca.Descripcion = TxtBoxDescripcion.Text;

                if (ErrorsInFields(service) == false)
                {
                    if (marca.Id != 0 && !service.repeatedDescripcion(marca.Descripcion))
                    {
                        service.modify(marca);
                        MessageBox.Show("Marca modificado exitosamente");
                        Close();
                    }
                    else
                    {
                        if (!service.repeatedDescripcion(marca.Descripcion))
                        {
                            service.add(marca);
                            MessageBox.Show("Marca agregada exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error: Descripción de marca repetida\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                ErrorsInFields(service);
            }
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloServices articuloService = new ArticuloServices();
            MarcaServices marcaServices = new MarcaServices();
            CategoriaServices categoriaServices = new CategoriaServices();

            try
            {
                lbPanelMarca.Text = "Agregando Marca";
                if (marca != null)
                {
                    lbPanelMarca.Text = "Modificando Marca";
                    BtnAgregar.Text = "Modificar";
                    TxtBoxDescripcion.Text = marca.Descripcion;  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool ErrorsInFields(MarcaServices service)
        {
            try
            {
                bool response = false;
                var resultadosValidacion = service.ValidateTypes(marca);

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

    }
}
