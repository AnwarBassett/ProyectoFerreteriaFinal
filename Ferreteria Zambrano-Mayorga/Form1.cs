using Ferreteria_Zambrano_Mayorga.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ferreteria_Zambrano_Mayorga
{
    public partial class Form1 : Form
    {
        public HttpClient client;
        JsonSerializerOptions u = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async void CargarDatosIniciales()
        {
            HttpResponseMessage response = await client.GetAsync("/api/Ruc");
            if (response.IsSuccessStatusCode)
            {

                string responseData = await response.Content.ReadAsStringAsync();
                List<Ruc> listacliente = JsonSerializer.Deserialize<List<Ruc>>(responseData, u);
                dgvRuc.DataSource = listacliente;


            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7136");
            CargarDatosIniciales();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void GenerarRuc()
        {
            Random random = new Random(DateTime.Now.GetHashCode());
            int numeroIrrepetible = random.Next();
            txtId.Text = Convert.ToString(numeroIrrepetible);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            GenerarRuc();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            Ruc nuevoruc = new Ruc();
            nuevoruc.IdRuc = int.Parse(txtId.Text);
            nuevoruc.TipoRuc = cbTipoRuc.Text;
            if (Convert.ToString(cbActivo) == "Si")
            {
                nuevoruc.Activo = true;
            }
            else if (Convert.ToString(cbActivo) == "No")
            {
                nuevoruc.Activo = false;
            }
            nuevoruc.FechaActivacion = DateTime.Parse(dtpFecha.Text);
            var jsonString = JsonSerializer.Serialize(nuevoruc, u);
            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("/api/Ruc", httpContent);
            CargarDatosIniciales();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            Ruc nuevoruc = new Ruc();
            nuevoruc.IdRuc = int.Parse(txtId.Text);
            nuevoruc.TipoRuc = cbTipoRuc.Text;
            if (Convert.ToString(cbActivo) == "Si")
            {
                nuevoruc.Activo = true;
            }
            else if (Convert.ToString(cbActivo) == "No")
            {
                nuevoruc.Activo = false;
            }
            nuevoruc.FechaActivacion = DateTime.Parse(dtpFecha.Text);
            var jsonString = JsonSerializer.Serialize(nuevoruc, u);
            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync("/api/Ruc/" + nuevoruc.IdRuc, httpContent);
            CargarDatosIniciales();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
