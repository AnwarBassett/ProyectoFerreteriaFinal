using Ferreteria_Zambrano_Mayorga.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ferreteria_Zambrano_Mayorga
{
    public partial class FrmProveedor : Form
    {
        public HttpClient client;
        public List<Ruc> listaRuc = new List<Ruc>();
        JsonSerializerOptions u = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public async void CargarDatosIniciales()
        {
            HttpResponseMessage response = await client.GetAsync("/api/Proveedor");
            if (response.IsSuccessStatusCode)
            {

                string responseData = await response.Content.ReadAsStringAsync();
                List<Proveedor> listaproveedor = JsonSerializer.Deserialize<List<Proveedor>>(responseData, u);
                dgwProveedor.DataSource = listaproveedor;
            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }
        public async void CargarDatosRuc()
        {
            HttpResponseMessage response = await client.GetAsync("/api/Ruc");
            if (response.IsSuccessStatusCode)
            {
                Ruc nuevRuc = new Ruc();
                string responseData = await response.Content.ReadAsStringAsync();
                List<Ruc> listaRucTemp = JsonSerializer.Deserialize<List<Ruc>>(responseData, u);
                foreach (Ruc li in listaRucTemp)
                {
                    listaRuc.Add(li);
                }
                listaRuc = listaRuc.OrderByDescending(x => x.FechaActivacion).ToList();
                cbListRuc.DataSource = listaRuc;
                cbListRuc.ValueMember = "IdRuc";
                cbListRuc.DisplayMember = "IdRuc";
                cbListRuc.SelectedValue = 0;
            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }
        public FrmProveedor()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7136");
            listaRuc.Add(new Ruc
            {
                IdRuc = 0,
                TipoRuc = "Desconocido",
                FechaActivacion = DateTime.Today,
                Activo = false
            });
            txtBox1.Enabled = false;
            CargarDatosIniciales();
            CargarDatosRuc();

        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {

        }
        List<int> listaDatos = new List<int>();

        public void Clear()
        {
            txtNombre.Text = string.Empty;
            txtBox1.Text = string.Empty;
            txtAdress.Text = string.Empty;
            cbListRuc.Text = string.Empty;
            txtDoc.Text = string.Empty;


        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {

            Proveedor nuevoproveedor = new Proveedor();
            nuevoproveedor.NombreProveedor = txtNombre.Text;
            nuevoproveedor.IdProveedor = 0;
            nuevoproveedor.Direccion = txtAdress.Text;
            nuevoproveedor.NumeroDocumento = txtDoc.Text;
            nuevoproveedor.IdRuc = int.Parse(cbListRuc.Text);
            if (nuevoproveedor.NombreProveedor == null || nuevoproveedor.Direccion == null ||
                nuevoproveedor.NumeroDocumento == null || nuevoproveedor.IdRuc <= 0)
            {
                MessageBox.Show("No puede agregar esos datos erroneos");
            }
            else
            {
                var jsonString = JsonSerializer.Serialize(nuevoproveedor, u);
                var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("/api/Proveedor", httpContent);
                CargarDatosIniciales();
                Clear();
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor nuevoproveedor = new Proveedor();
                nuevoproveedor.NombreProveedor = txtNombre.Text;
                nuevoproveedor.IdProveedor = int.Parse(txtBox1.Text);
                nuevoproveedor.Direccion = txtAdress.Text;
                nuevoproveedor.NumeroDocumento = txtDoc.Text;
                nuevoproveedor.IdRuc = int.Parse(cbListRuc.Text);
                if (nuevoproveedor.NombreProveedor == null || nuevoproveedor.Direccion == null ||
                    nuevoproveedor.NumeroDocumento == null || nuevoproveedor.IdRuc <= 0 || nuevoproveedor.IdProveedor <= 0)
                {
                    MessageBox.Show("No puede agregar esos datos erroneos");
                }
                else
                {
                    var jsonString = JsonSerializer.Serialize(nuevoproveedor, u);
                    var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync("/api/Proveedor/" + nuevoproveedor.IdProveedor, httpContent);
                    CargarDatosIniciales();
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar datos: " + ex);
            }

        }

        private void dgwProveedor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwProveedor.SelectedRows.Count > 0)
            {
                DataGridViewRow clickFila = dgwProveedor.SelectedRows[0];
                string Id = clickFila.Cells[0].Value.ToString();
                string nombre = clickFila.Cells[1].Value.ToString();
                string doc = clickFila.Cells[2].Value.ToString();
                string direccion = clickFila.Cells[3].Value.ToString();
                string IdRuc = clickFila.Cells[4].Value.ToString();

                txtNombre.Text = nombre;
                txtBox1.Text = Id;
                txtDoc.Text = doc;
                txtAdress.Text = direccion;
                cbListRuc.Text = IdRuc;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor nuevoproveedor = new Proveedor();
                nuevoproveedor.IdProveedor = int.Parse(txtBox1.Text);
                HttpResponseMessage response = await client.DeleteAsync("/api/Proveedor/" + nuevoproveedor.IdProveedor);
                CargarDatosIniciales();
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar Proveedor");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form1 Mostrar = new Form1();
                Mostrar.Show();
            }
        }

        private void cbListRuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
