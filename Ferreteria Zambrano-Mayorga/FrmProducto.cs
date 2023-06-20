using System.Data;
using System.IO;
using System.Net.Http;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Ferreteria_Zambrano_Mayorga.Modelos;
using Microsoft.VisualBasic.ApplicationServices;

namespace Ferreteria_Zambrano_Mayorga
{
    public partial class FrmProducto : Form
    {
        public HttpClient client;
        List<Producto> listaproducto = new List<Producto>();
        JsonSerializerOptions u = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public async void CargarDatosIniciales()
        {
            HttpResponseMessage response = await client.GetAsync("/api/Producto");
            if (response.IsSuccessStatusCode)
            {

                string responseData = await response.Content.ReadAsStringAsync();
                listaproducto = JsonSerializer.Deserialize<List<Producto>>(responseData, u);

                dgwProducto.DataSource = listaproducto;
            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }
        public List<Proveedor> listaproveedor = new List<Proveedor>();
        public async void CargarDatosProveedor()
        {
            HttpResponseMessage response = await client.GetAsync("/api/Proveedor");
            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                List<Proveedor> listaproveedorTemp = JsonSerializer.Deserialize<List<Proveedor>>(responseData, u);
                foreach (Proveedor mi in listaproveedorTemp)
                {
                    listaproveedor.Add(mi);
                }
                cbProveedor.DataSource = listaproveedor;
                cbProveedor.ValueMember = "IdProveedor";
                cbProveedor.DisplayMember = "IdProveedor";
                cbProveedor.SelectedValue = 0;
            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }
        public FrmProducto()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7136");

            listaproveedor.Add(new Proveedor
            {
                IdProveedor = 0,
                IdRuc = 0,
                Direccion = "desconocida",
                NumeroDocumento = "Desconocido",
                NombreProveedor = "Desconocido"
            });
            CargarDatosIniciales();
            CargarDatosProveedor();
            GenerarId();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        //private void label5_Click(object sender, EventArgs e)
        //{
        //}

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevoproducto = new Producto();
                nuevoproducto.IdProducto = int.Parse(txtIdProducto.Text);
                nuevoproducto.NombreProducto = txtNombre.Text;
                nuevoproducto.Precio = int.Parse(txtPrecio.Text);
                nuevoproducto.Cantidad = int.Parse(txtCantidad.Text);
                nuevoproducto.Fecha = DateTime.Parse(dtpFecha.Text);
                nuevoproducto.Descripcion = txtDescripcion.Text;
                nuevoproducto.Categoria = cbCategoria.Text;
                nuevoproducto.IdProveedor = int.Parse(cbProveedor.Text);
                var jsonString = JsonSerializer.Serialize(nuevoproducto, u);
                var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("/api/Producto", httpContent);
                CargarDatosIniciales();
            }
            catch (Exception)
            {

                MessageBox.Show("Valores incorrectos");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevoproducto = new Producto();
                nuevoproducto.IdProducto = int.Parse(txtIdProducto.Text);
                nuevoproducto.NombreProducto = txtNombre.Text;
                nuevoproducto.Precio = int.Parse(txtPrecio.Text);
                nuevoproducto.Cantidad = int.Parse(txtCantidad.Text);
                nuevoproducto.Fecha = DateTime.Parse(dtpFecha.Text);
                nuevoproducto.Descripcion = txtDescripcion.Text;
                nuevoproducto.Categoria = cbCategoria.Text;
                nuevoproducto.IdProveedor = int.Parse(cbProveedor.Text);

                var jsonString = JsonSerializer.Serialize(nuevoproducto, u);
                var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync("/api/Producto/" + nuevoproducto.IdProducto, httpContent);
                CargarDatosIniciales();
            }
            catch (Exception)
            {

                MessageBox.Show("Valores incorrectos");
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgwProducto_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwProducto.SelectedRows.Count > 0)
            {
                DataGridViewRow clickFila = dgwProducto.SelectedRows[0];
                string Id = clickFila.Cells[0].Value.ToString();
                string Nombre = clickFila.Cells[1].Value.ToString();
                string Precio = clickFila.Cells[2].Value.ToString();
                string Cantidad = clickFila.Cells[3].Value.ToString();
                string Fecha = clickFila.Cells[4].Value.ToString();
                string Descripcion = clickFila.Cells[5].Value.ToString();
                string Categoria = clickFila.Cells[6].Value.ToString();
                string Idproveedor = clickFila.Cells[7].Value.ToString();

                txtNombre.Text = Nombre;
                txtIdProducto.Text = Id;
                txtPrecio.Text = Precio;
                txtCantidad.Text = Cantidad;
                dtpFecha.Text = Fecha;
                txtDescripcion.Text = Descripcion;
                cbCategoria.SelectedText = Categoria;
                cbProveedor.Text = Idproveedor;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevoproducto = new Producto();
                nuevoproducto.IdProducto = int.Parse(txtIdProducto.Text);
                HttpResponseMessage response = await client.DeleteAsync("/api/Producto/" + nuevoproducto.IdProducto);
                CargarDatosIniciales();
            }
            catch (Exception)
            {

                MessageBox.Show("Valores incorrectos");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void GenerarId()
        {
            Random random = new Random(DateTime.Now.GetHashCode());
            int numeroIrrepetible = random.Next();
            txtIdProducto.Text = Convert.ToString(numeroIrrepetible);
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgwProducto.Rows)
                {
                    row.Visible = row.Cells["Categoria"].Value.ToString().ToUpper().Contains(cbCategoriaFiltro.Text.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El elemento no existe o es invalido");
            }

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            PanelAdd.Visible = false;
            txtIdProducto.Enabled = false;
            pCategoria.Visible = true;
        }

        private void btnActivarPanel_Click(object sender, EventArgs e)
        {
            PanelAdd.Visible = true;
            pCategoria.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            PanelAdd.Visible = false;
            pCategoria.Visible = true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
