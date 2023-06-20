using System.Net.Http;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Ferreteria_Zambrano_Mayorga.Modelos;
using Microsoft.VisualBasic.ApplicationServices;

namespace Ferreteria_Zambrano_Mayorga
{
    public partial class FrmCliente : Form
    {
        public HttpClient client;
        JsonSerializerOptions u = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public List<Ruc> listaRuc = new List<Ruc>();
        List<Cliente> listacliente = new List<Cliente>();
        public async void CargarDatosIniciales()
        {
            HttpResponseMessage response = await client.GetAsync("/api/Cliente");
            if (response.IsSuccessStatusCode)
            {

                string responseData = await response.Content.ReadAsStringAsync();
                listacliente = JsonSerializer.Deserialize<List<Cliente>>(responseData, u);
                dgvClientes.DataSource = listacliente;


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

                string responseData = await response.Content.ReadAsStringAsync();
                List<Ruc> listaRucTemp = JsonSerializer.Deserialize<List<Ruc>>(responseData, u);
                foreach (Ruc li in listaRucTemp)
                {
                    listaRuc.Add(li);
                }
                cbRuc.DataSource = listaRuc;
                cbRuc.ValueMember = "IdRuc";
                cbRuc.SelectedValue = 0;


            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }
        public FrmCliente()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7136");
            CargarDatosIniciales();
            CargarDatosRuc();
            txtId.Enabled = false;
        }

        private async void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevocliente = new Cliente();
                nuevocliente.NombreCompleto = txtNombre.Text;
                nuevocliente.IdCliente = 0;
                nuevocliente.Contraseña = txtContraseña.Text;
                nuevocliente.IdRuc = int.Parse(cbRuc.Text);
                if (nuevocliente.NombreCompleto == null ||
                    nuevocliente.Contraseña == null || nuevocliente.IdRuc <= 0)
                {
                    MessageBox.Show("Existen datos erroneos, corrigalos antes de agregarlos");
                }
                else
                {
                    var jsonString = JsonSerializer.Serialize(nuevocliente, u);
                    var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("/api/Cliente", httpContent);
                    CargarDatosIniciales();
                }
                clean();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al enviar los datos: " + ex);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevocliente = new Cliente();
                nuevocliente.NombreCompleto = txtNombre.Text;
                nuevocliente.IdCliente = int.Parse(txtId.Text);
                nuevocliente.Contraseña = txtContraseña.Text;
                nuevocliente.IdRuc = int.Parse(cbRuc.Text);
                if (nuevocliente.NombreCompleto == null ||
                    nuevocliente.Contraseña == null || nuevocliente.IdRuc <= 0)
                {
                    MessageBox.Show("Existen datos erroneos, corrigalos antes de agregarlos");
                }
                else
                {
                    var jsonString = JsonSerializer.Serialize(nuevocliente, u);
                    var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync("/api/Cliente/" + nuevocliente.IdCliente, httpContent);
                    CargarDatosIniciales();
                }
                clean();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar datos: " + ex);
            }

        }
        public void clean()
        {
            txtNombre.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtId.Text = string.Empty;
            cbRuc.Text = string.Empty;
            txtId.Enabled = true;
        }
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                txtId.Enabled = false;
                DataGridViewRow clickFila = dgvClientes.SelectedRows[0];
                string Id = clickFila.Cells[0].Value.ToString();
                string nombre = clickFila.Cells[1].Value.ToString();
                string contraseña = clickFila.Cells[2].Value.ToString();
                string IdRuc = clickFila.Cells[3].Value.ToString();

                txtNombre.Text = nombre;
                txtId.Text = Id;
                txtContraseña.Text = contraseña;
                cbRuc.Text = IdRuc;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Cliente nuevocliente = new Cliente();
            nuevocliente.IdCliente = int.Parse(txtId.Text);
            HttpResponseMessage response = await client.DeleteAsync("/api/Cliente/" + nuevocliente.IdCliente);
            CargarDatosIniciales();
            clean();
        }

        private void ckbRuc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRuc.Checked)
            {
                Form1 Mostrar = new Form1();
                Mostrar.Show();
                //this.Hide();
            }
        }
    }
}
