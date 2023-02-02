using ProyectoPoliza.Entidades;
using ProyectoPoliza.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPoliza.Interfaces
{
    public partial class PolizaForm : Form
    {
        RepositorioPoliza repositorioPoliza = new RepositorioPoliza();
        RepositorioAsegurados repositorioAsegurados = new RepositorioAsegurados();
        int idPoliza;
        public PolizaForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIdPoliza.Text == "")
                {
                    MessageBox.Show("Debe ingresar un ID de una poliza", "ATENCION", MessageBoxButtons.OK);
                    return;
                }
                //obtengo el id ingresado por teclado
                idPoliza = Convert.ToInt32(textBoxIdPoliza.Text);
                //creo un objeto poliza para guardar la poliza buscada
                Poliza polizaObtenida = new Poliza();
                //llamo al metodo del repositorio que me devuelve la poliza
                polizaObtenida = repositorioPoliza.getIdPoliza(idPoliza);

                //si no hay poliza con ese id se lo informo .
                if (polizaObtenida == null)
                {
                    MessageBox.Show("No existe una poliza con ese id !! Por favor ingrese otro id", "ATENCION", MessageBoxButtons.OK);
                    textBoxIdPoliza.Text = "";
                    return;
                }
                //devuelvo los datos de la poliza encontrada a pantalla
                NombreProductoTxt.Text = polizaObtenida.producto.Nombre;
                NombreTipoTxt.Text = polizaObtenida.TipoProducto.Nombre;
                estadoTxt.Text = polizaObtenida.Estado;

                //con este metodo obtengo y muestro en forma de lista la tabla de los asegurados activos de esa poliza
                devolverAseguradosActivosPoliza(idPoliza);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"  Por favor intente nuevamente", "ATENCION", MessageBoxButtons.OK);
            }
        }

        public void devolverAseguradosActivosPoliza(int idPoliza)
        {
            btnEliminar.Visible = true;
            txtNoHayAsegurados.Visible = false;
            tablaAsegurados.Visible = true;
            //creo la lista de los asegurados y la obtengo del repositorio asegurados
            List<Asegurados> listaAseguradosPoliza = new List<Asegurados>();
            listaAseguradosPoliza = repositorioAsegurados.getAseguradosPorPoliza(idPoliza);

            if(listaAseguradosPoliza.Count == 0)
            {
                txtNoHayAsegurados.Visible = true;
                txtNoHayAsegurados.Text = "NO HAY ASEGURADOS CON ESA POLIZA";
                //no muestro la tala
                btnEliminar.Visible = false;
                tablaAsegurados.Visible = false;
            }
            //limpio tabla 
            tablaAsegurados.Rows.Clear();

            //obtengo el año actual 
            int añoActual = @DateTime.Now.Year;
            foreach (var asegurado in listaAseguradosPoliza)
            {
                var filaTabla = new string[]
                {
                    asegurado.idAsegurado.ToString(),
                    asegurado.Dni.ToString(),
                    asegurado.Nombre,
                    (añoActual - asegurado.FechaNacimiento.Year).ToString()
                };
                tablaAsegurados.Rows.Add(filaTabla);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablaAsegurados.SelectedRows.Count == 1)
                {
                    var idAsegurado = Convert.ToInt32(tablaAsegurados.SelectedRows[0].Cells["IdAsegurado"].Value);

                    DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Cancel)
                        return;

                    repositorioAsegurados.EliminarAsegurado(idAsegurado);
                    //recargo la lista, haciendo la consulta nuevamente
                    devolverAseguradosActivosPoliza(idPoliza);

                    MessageBox.Show("Se elimino el asegurado con exito.", "Exito", MessageBoxButtons.OK);
                    return;

                }
                MessageBox.Show("Debe seleccionar solo un asegurado.", "Informacion", MessageBoxButtons.OK);
            }
            catch(ApplicationException exApp)
            {
                MessageBox.Show(exApp.Message, "Atencion", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK);
            }

        }
    }
}
