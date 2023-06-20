using Ferreteria_Zambrano_Mayorga.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_Zambrano_Mayorga
{
    public partial class FrmUsuario : Form
    {

        //WinfowsState = FormWinfowsState.Minimized;
        ////FrmUsuario.M
        ////WindowState= FrmUsuario.Maximized;

        public HttpClient client;
        public List<Ruc> listaRuc = new List<Ruc>();
        JsonSerializerOptions u = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
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
                cbruc.DataSource = listaRuc;
                cbruc.ValueMember = "IdRuc";
                cbruc.DisplayMember = "IdRuc";
                cbruc.SelectedValue = 0;
            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }
        public async void CargarDatosIniciales()
        {
            HttpResponseMessage response = await client.GetAsync("/api/Usuario");
            if (response.IsSuccessStatusCode)
            {

                string responseData = await response.Content.ReadAsStringAsync();
                List<Usuario> listausuario = JsonSerializer.Deserialize<List<Usuario>>(responseData, u);
                dgwUsuario.DataSource = listausuario;
            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }
        public FrmUsuario()
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
            CargarDatosIniciales();
        }
        public void Clear()
        {
            txtIdUsuario.Text = string.Empty;
            cbruc.SelectedIndex = 0;
            txtDescripcion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNombreUser.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario nuevousuario = new Usuario();
                nuevousuario.IdUsuario = 0;
                nuevousuario.NombreCompleto = txtNombre.Text;
                nuevousuario.NombreUsuario = txtNombreUser.Text;
                nuevousuario.Descripcion = txtDescripcion.Text;
                nuevousuario.IdRuc = int.Parse(cbruc.Text);
                nuevousuario.Clave = txtPassword.Text;
                if (nuevousuario.NombreCompleto == null || nuevousuario.NombreUsuario == null ||
                nuevousuario.Descripcion == null || nuevousuario.IdRuc <= 0 ||
                nuevousuario.Clave == null)
                {
                    MessageBox.Show("Error al ingresar los datos para agregar");
                }
                else
                {
                    var jsonString = JsonSerializer.Serialize(nuevousuario, u);
                    var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("/api/Usuario", httpContent);
                    CargarDatosIniciales();
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al enviar datos: " + ex);
            }

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario nuevousuario = new Usuario();
                nuevousuario.IdUsuario = int.Parse(txtIdUsuario.Text);
                nuevousuario.NombreCompleto = txtNombre.Text;
                nuevousuario.NombreUsuario = txtNombreUser.Text;
                nuevousuario.Descripcion = txtDescripcion.Text;
                nuevousuario.IdRuc = int.Parse(cbruc.Text);
                nuevousuario.Clave = txtPassword.Text;
                if (nuevousuario.IdUsuario <= 0 || nuevousuario.NombreCompleto == null || nuevousuario.NombreUsuario == null ||
                nuevousuario.Descripcion == null || nuevousuario.IdRuc <= 0 ||
                nuevousuario.Clave == null)
                {
                    MessageBox.Show("Error al ingresar los datos a actualizar");
                }
                else
                {
                    var jsonString = JsonSerializer.Serialize(nuevousuario, u);
                    var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync("/api/Usuario/" + nuevousuario.IdUsuario, httpContent);
                    CargarDatosIniciales();
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar datos: "+ex);
            }


        }

        private void dgwUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwUsuario.SelectedRows.Count > 0)
            {


                DataGridViewRow clickFila = dgwUsuario.SelectedRows[0];
                string Id = clickFila.Cells[0].Value.ToString();
                string Nombre = clickFila.Cells[1].Value.ToString();
                string Usuario = clickFila.Cells[2].Value.ToString();
                string Contraseña = clickFila.Cells[3].Value.ToString();
                string Descripcion = clickFila.Cells[4].Value.ToString();
                string IdRuc = clickFila.Cells[5].Value.ToString();

                txtIdUsuario.Text = Id;
                txtNombre.Text = Nombre;
                txtNombreUser.Text = Usuario;
                txtPassword.Text = Contraseña;
                txtDescripcion.Text = Descripcion;
                cbruc.Text = IdRuc;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                Usuario nuevousuario = new Usuario();
                nuevousuario.IdUsuario = int.Parse(txtIdUsuario.Text);
                HttpResponseMessage response = await client.DeleteAsync("/api/Usuario//" + nuevousuario.IdUsuario);
                CargarDatosIniciales();
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar los datos");
            }


        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            txtIdUsuario.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form1 Mostrar = new Form1();
                Mostrar.Show();
            }
        }
    }
}
