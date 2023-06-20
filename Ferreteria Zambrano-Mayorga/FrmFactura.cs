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
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = iTextSharp.text.Image;

namespace Ferreteria_Zambrano_Mayorga
{
    public partial class FrmFactura : Form
    {
        public HttpClient client;
        JsonSerializerOptions u = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };


        public List<Producto> listaproducto = new List<Producto>();
        public List<Usuario> listausuario = new List<Usuario>();
        public List<Cliente> listaCliente = new List<Cliente>();
        public int counter = 1;
        public Salidas sl;
        public SalidasDetalle sdl;
        public List<SalidasDetalle> listasalidasDet = new List<SalidasDetalle>();
        System.Data.DataTable table = new DataTable();
        public async void CargarSalidas()
        {
            HttpResponseMessage response = await client.GetAsync("/api/Salida");
            if (response.IsSuccessStatusCode)
            {

                string responseData = await response.Content.ReadAsStringAsync();
                List<Salidas> listaSalidas = JsonSerializer.Deserialize<List<Salidas>>(responseData, u);
                do
                {
                    sl = listaSalidas.Find(x => x.IdFactura == counter);
                    if (sl == null)
                    {
                        txtFactura.Text = counter.ToString();
                    }
                    else
                    {
                        counter++;
                        txtFactura.Text = counter.ToString();
                    }
                } while (sl != null);
            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }
        public async void CargarDatosSalidas()
        {
            HttpResponseMessage response = await client.GetAsync("/api/SalidaDetalle");
            if (response.IsSuccessStatusCode)
            {

                string responseData = await response.Content.ReadAsStringAsync();
            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }
        public async void CargarDatosProductos()
        {
            HttpResponseMessage response = await client.GetAsync("/api/Producto");
            if (response.IsSuccessStatusCode)
            {

                string responseData = await response.Content.ReadAsStringAsync();
                List<Producto> listaproductoTemp = JsonSerializer.Deserialize<List<Producto>>(responseData, u);
                foreach (Producto li in listaproductoTemp)
                {
                    listaproducto.Add(li);
                }

                cbListProducto.DataSource = listaproducto;
                cbListProducto.ValueMember = "IdProducto";
                cbListProducto.DisplayMember = "NombreProducto";
                cbListProducto.SelectedValue = 0;
            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }

        public async void CargarDatosUsuario()
        {
            HttpResponseMessage response = await client.GetAsync("/api/Usuario");
            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                List<Usuario> listausuarioTemp = JsonSerializer.Deserialize<List<Usuario>>(responseData, u);
                foreach (Usuario mi in listausuarioTemp)
                {
                    listausuario.Add(mi);
                }
                cbusuario.DataSource = listausuario;
                cbusuario.ValueMember = "IdUsuario";
                cbusuario.DisplayMember = "IdUsuario";
                cbusuario.SelectedValue = 0;
            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }

        public async void CargarDatosCliente()
        {
            HttpResponseMessage response = await client.GetAsync("/api/Cliente");
            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                List<Cliente> listaclienteTemp = JsonSerializer.Deserialize<List<Cliente>>(responseData, u);
                foreach (Cliente ni in listaclienteTemp)
                {
                    listaCliente.Add(ni);
                }
                cbClienteList.DataSource = listaCliente;
                cbClienteList.ValueMember = "IdCliente";
                cbClienteList.DisplayMember = "IdCliente";
                cbClienteList.SelectedValue = 0;
            }
            else
            {
                MessageBox.Show("Error al realizar la solicitud: " + response.StatusCode);
            }
        }
        public FrmFactura()
        {
            InitializeComponent();
            listaproducto.Add(new Producto
            {
                IdProducto = 0,
                NombreProducto = "Seleccione",
                Cantidad = 0,
                Precio = 0,
                Categoria = "Se desconoce",
                Descripcion = "Se desconoce",
                Fecha = DateTime.Now,
                IdProveedor = 0
            });
            listausuario.Add(new Usuario
            {
                IdUsuario = 0,
                NombreUsuario = "Seleccione",
                NombreCompleto = "Se desconoce",
                Clave = "Se desconoce",
                Descripcion = "Se desconoce",
                IdRuc = 0
            });
            listaCliente.Add(new Cliente
            {
                IdCliente = 0,
                NombreCompleto = "Desconocido",
                Contraseña = "Desconocido",
                IdRuc = 0
            });

            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7136");

            table.Columns.Add("id", typeof(int));
            table.Columns.Add("IdProducto", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Cantidad", typeof(int));
            table.Columns.Add("Precio", typeof(double));
            table.Columns.Add("SubTotal", typeof(double));
            table.Columns.Add("IdSalida", typeof(int));

            dgvFactura.DataSource = table;
            dgvFactura.Refresh();

            CargarDatosProductos();
            CargarDatosUsuario();
            CargarDatosCliente();
            CargarSalidas();
            txtCantidad.Text = "0";
            txtSubTotal.Text = "0";
            txtPrecio.Text = "0";
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtPrecio.Enabled = false;
            txtSubTotal.Enabled = false;
            txtFactura.Enabled = false;

            dgvFactura.AllowUserToAddRows = false;
        }
        public void Clear()
        {
            txtCantidad.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtSubTotal.Text = string.Empty;
            cbListProducto.SelectedIndex = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {

            try
            {
                txtSubTotal.Text = (float.Parse(txtCantidad.Text) * float.Parse(txtPrecio.Text)).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error con el dato seleccionado");
            }
        }

        private void cbListProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = cbListProducto.SelectedIndex;
            if (indiceSeleccionado > 0)
            {
                int idSeleccionado = (int)cbListProducto.SelectedValue;
                Producto p = listaproducto.Find(x => x.IdProducto == idSeleccionado);
                if (p != null)
                {

                    txtPrecio.Text = p.Precio.ToString();

                }
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (cbListProducto.SelectedIndex == 0)
                {
                    MessageBox.Show("Error con datos nulo");
                }
                else
                {
                    cbusuario.Enabled = false;
                    cbClienteList.Enabled = false;
                    int idSeleccionado = (int)cbListProducto.SelectedValue;
                    Producto p = listaproducto.Find(x => x.IdProducto == idSeleccionado);
                    if (p != null)
                    {
                        txtPrecio.Text = p.Precio.ToString();
                    }
                    SalidasDetalle newsalida = new SalidasDetalle();
                    newsalida.CantidadProducto = int.Parse(txtCantidad.Text.ToString());
                    newsalida.PrecioUnitario = double.Parse(txtPrecio.Text.ToString());
                    newsalida.SubTotal = double.Parse(txtSubTotal.Text.ToString());
                    newsalida.Id = 0;
                    newsalida.IdProducto = p.IdProducto;
                    newsalida.NombreProducto = p.NombreProducto;
                    newsalida.SalidaId = int.Parse(txtFactura.Text.ToString());
                    if (newsalida.CantidadProducto <= 0 || newsalida.PrecioUnitario <= 0 || newsalida.SubTotal <= 0 ||
                        newsalida.IdProducto <= 0 || newsalida.NombreProducto == null || newsalida.SalidaId <= 0)
                    {
                        MessageBox.Show("Alguno de los datos es incorrecto, verifique e intente de nuevo");
                    }
                    else
                    {
                        table.Rows.Add(newsalida.Id, newsalida.IdProducto, p.NombreProducto, newsalida.CantidadProducto,
                                         newsalida.PrecioUnitario, newsalida.SubTotal, newsalida.SalidaId);
                        dgvFactura.DataSource = table;
                        dgvFactura.Refresh();
                    }
                    Clear();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex);
            }

        }
        List<SalidasDetalle> SalidasDet = new List<SalidasDetalle>();

        SalidasDetalle sld = new SalidasDetalle();
        public async void CrearLista()
        {
            try
            {

                foreach (DataGridViewRow row in dgvFactura.Rows)
                {
                    sld = new SalidasDetalle
                    {
                        Id = int.Parse(row.Cells[0].Value.ToString()),
                        IdProducto = int.Parse(row.Cells[1].Value.ToString()),
                        NombreProducto = row.Cells[2].Value.ToString(),
                        CantidadProducto = int.Parse(row.Cells[3].Value.ToString()),
                        PrecioUnitario = double.Parse(row.Cells[4].Value.ToString()),
                        SubTotal = double.Parse(row.Cells[5].Value.ToString()),
                        SalidaId = int.Parse(row.Cells[6].Value.ToString())

                    };
                    UpdateStock(sld.CantidadProducto, sld.IdProducto);

                    var jsonString = JsonSerializer.Serialize(sld, u);
                    var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("/api/SalidaDetalle", httpContent);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex);
            }
        }
        public async void UpdateStock(int Stock, int Id)
        {
            try
            {
                Producto nuevoproducto = new Producto();
                Producto p = listaproducto.Find(x => x.IdProducto == Id);
                if (p != null)
                {
                    nuevoproducto.NombreProducto = p.NombreProducto;
                    nuevoproducto.Descripcion = p.Descripcion;
                    nuevoproducto.Precio = p.Precio;
                    nuevoproducto.Fecha = p.Fecha;
                    nuevoproducto.Categoria = p.Categoria;
                    nuevoproducto.IdProveedor = p.IdProveedor;
                    nuevoproducto.Cantidad = (p.Cantidad - Stock);
                    nuevoproducto.IdProducto = Id;
                    var jsonString = JsonSerializer.Serialize(nuevoproducto, u);
                    var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync("/api/Producto/" + nuevoproducto.IdProducto, httpContent);

                }
                if (p.Cantidad <= Stock)
                {
                    MessageBox.Show("Se recomienda actualizar la cantidad de productos, se agregaran automaticamente mas productos");
                    nuevoproducto.NombreProducto = p.NombreProducto;
                    nuevoproducto.Descripcion = p.Descripcion;
                    nuevoproducto.Precio = p.Precio;
                    nuevoproducto.Fecha = p.Fecha;
                    nuevoproducto.Categoria = p.Categoria;
                    nuevoproducto.IdProveedor = p.IdProveedor;
                    int cant;
                    do
                    {
                        cant = ((p.Cantidad++) - Stock);

                    } while (p.Cantidad < Stock);
                    nuevoproducto.Cantidad = cant;
                    nuevoproducto.IdProducto = Id;
                    var jsonString = JsonSerializer.Serialize(nuevoproducto, u);
                    var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync("/api/Producto/" + nuevoproducto.IdProducto, httpContent);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error");
            }



        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFactura.SelectedRows.Count > 0)
            {
                DataGridViewRow clickFila = dgvFactura.SelectedRows[0];
                dgvFactura.Rows.Remove(clickFila);
            }
        }
        public void Save()
        {
            foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                SalidasDetalle sld = new SalidasDetalle
                {
                    Id = int.Parse(row.Cells[0].Value.ToString()),
                    IdProducto = int.Parse(row.Cells[1].Value.ToString()),
                    NombreProducto = row.Cells[2].Value.ToString(),
                    CantidadProducto = int.Parse(row.Cells[3].Value.ToString()),
                    PrecioUnitario = double.Parse(row.Cells[4].Value.ToString()),
                    SubTotal = double.Parse(row.Cells[5].Value.ToString()),
                    SalidaId = int.Parse(row.Cells[6].Value.ToString())

                };
                listasalidasDet.Add(sld);
            }
        }
        
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            cbClienteList.Enabled = true;
            cbusuario.Enabled = true;
            Save();
            double total = 0;
            foreach (SalidasDetalle sd in listasalidasDet)
            {
                total += sd.SubTotal;
            }

            txtTotal.Text = total.ToString();

            Salidas nuevasalida = new Salidas();
            nuevasalida.IdFactura = 0;
            nuevasalida.IdVendedor = int.Parse(cbusuario.Text.ToString());
            nuevasalida.NombreUsuario = txtNombreUsuario.Text;
            nuevasalida.IdClients = int.Parse(cbClienteList.Text.ToString());
            nuevasalida.NombreCliente = txtNombreCliente.Text;
            nuevasalida.FechaRegistroSalida = DateTime.Parse(dtpFecha.Text);
            nuevasalida.MontoTotal = double.Parse(txtTotal.Text.ToString());
            if (nuevasalida.IdVendedor <= 0 || nuevasalida.NombreCliente == null ||
                nuevasalida.IdClients <= 0 || nuevasalida.FechaRegistroSalida == null ||
                nuevasalida.NombreUsuario == null || nuevasalida.MontoTotal <= 0)
            {
                MessageBox.Show("Error al ingresar datos");
            }
            else
            {
                var jsonString = JsonSerializer.Serialize(nuevasalida, u);
                var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("/api/Salida", httpContent);
                GenerarPDF(nuevasalida.NombreUsuario, nuevasalida.NombreCliente, nuevasalida.MontoTotal);
                CrearLista();
            }

        }

        private void cbListVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbusuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelected = cbusuario.SelectedIndex;
            if (indiceSelected > 0)
            {
                int idSeleccionado = (int)cbusuario.SelectedValue;
                Usuario us = listausuario.Find(x => x.IdUsuario == idSeleccionado);
                if (us != null)
                {

                    txtNombreUsuario.Text = us.NombreCompleto.ToString();

                }
            }
        }

        private void cbClienteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelected = cbClienteList.SelectedIndex;
            if (indiceSelected > 0)
            {
                int idSeleccionado = (int)cbClienteList.SelectedValue;
                Cliente cl = listaCliente.Find(x => x.IdCliente == idSeleccionado);
                if (cl != null)
                {

                    txtNombreCliente.Text = cl.NombreCompleto.ToString();

                }
            }
        }

        private void btnPanel1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
        public void GenerarPDF(string nameuser, string namercustomer, double Ttl)
        {
            string nombrePdf = txtFactura.Text;
            string rutaImagen = "Logo.jpg";
            string rutaArc = nombrePdf + ".pdf";
            FileStream fileStream = new FileStream(rutaArc, FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fileStream);

            doc.Open();

            doc.AddAuthor("Ferreteria Zambrano-Mayorga");
            doc.AddTitle("Factura N°" + nombrePdf);

            iTextSharp.text.Font standarfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            Image imagen = Image.GetInstance(rutaImagen);
            imagen.ScaleToFit(80, 80);
            imagen.Alignment = Element.ALIGN_CENTER;
            doc.Add(imagen);
            doc.Add(new Paragraph("Factura de Ferreteria N°" + nombrePdf));
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Fecha Creacion: " + DateTime.Now));
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Nombre de Vendedor: " + nameuser));
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Nombre de Cliente: " + namercustomer));
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("====================================="));
            doc.Add(Chunk.NEWLINE);


            PdfPTable fac = new PdfPTable(4);
            fac.WidthPercentage = 100;

            PdfPCell clProducto = new PdfPCell(new Phrase("Producto", standarfont));
            clProducto.BorderWidth = 0;
            clProducto.BorderWidthBottom = 0.75f;

            PdfPCell clPrecio = new PdfPCell(new Phrase("Precio", standarfont));
            clPrecio.BorderWidth = 0;
            clPrecio.BorderWidthBottom = 0.75f;

            PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", standarfont));
            clCantidad.BorderWidth = 0;
            clCantidad.BorderWidthBottom = 0.75f;

            PdfPCell clSubTotal = new PdfPCell(new Phrase("SubTotal", standarfont));
            clSubTotal.BorderWidth = 0;
            clSubTotal.BorderWidthBottom = 0.75f;

            fac.AddCell(clProducto);
            fac.AddCell(clPrecio);
            fac.AddCell(clCantidad);
            fac.AddCell(clSubTotal);

            foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                clProducto = new PdfPCell(new Phrase(row.Cells[2].Value.ToString(), standarfont));
                clProducto.BorderWidth = 0;

                clPrecio = new PdfPCell(new Phrase(row.Cells[4].Value.ToString(), standarfont));
                clPrecio.BorderWidth = 0;

                clCantidad = new PdfPCell(new Phrase(row.Cells[3].Value.ToString(), standarfont));
                clCantidad.BorderWidth = 0;

                clSubTotal = new PdfPCell(new Phrase(row.Cells[5].Value.ToString()));
                clSubTotal.BorderWidth = 0;

                fac.AddCell(clProducto);
                fac.AddCell(clPrecio);
                fac.AddCell(clCantidad);
                fac.AddCell(clSubTotal);
            }
            doc.Add(fac);
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Total: " + Ttl));
            doc.Add(Chunk.NEWLINE);


            doc.Close();
            pw.Close();
            MessageBox.Show("La Factura se ha imprimido");
            Borrar();
        }

        public void Borrar()
        {
            cbClienteList.SelectedIndex = 0;
            cbusuario.SelectedIndex = 0;
            int f;
            f = dgvFactura.RowCount;
            for (int i = f - 1; i >= 0; i--)
            {
                dgvFactura.Rows.RemoveAt(i);
            }
            CargarSalidas();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void cbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
