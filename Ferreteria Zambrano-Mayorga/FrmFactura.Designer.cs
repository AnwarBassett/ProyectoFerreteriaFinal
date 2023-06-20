namespace Ferreteria_Zambrano_Mayorga
{
    partial class FrmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            dgvFactura = new DataGridView();
            txtCantidad = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbListProducto = new ComboBox();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            txtTotal = new TextBox();
            label8 = new Label();
            txtFactura = new TextBox();
            txtPrecio = new TextBox();
            txtSubTotal = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            cbClienteList = new ComboBox();
            label9 = new Label();
            txtNombreCliente = new TextBox();
            txtNombreUsuario = new TextBox();
            cbusuario = new ComboBox();
            lbInfo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvFactura
            // 
            dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(12, 289);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowTemplate.Height = 25;
            dgvFactura.Size = new Size(767, 197);
            dgvFactura.TabIndex = 0;
            dgvFactura.CellDoubleClick += dataGridView1_CellDoubleClick;
            dgvFactura.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(110, 160);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 2;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            txtCantidad.Leave += txtCantidad_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 221);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 12;
            label7.Text = "SubTotal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 192);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 163);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 10;
            label5.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 134);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 9;
            label4.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 105);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 8;
            label3.Text = "Id Vendedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 47);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 7;
            label2.Text = "N° Factura:";
            // 
            // cbListProducto
            // 
            cbListProducto.FormattingEnabled = true;
            cbListProducto.Location = new Point(110, 131);
            cbListProducto.Name = "cbListProducto";
            cbListProducto.Size = new Size(100, 23);
            cbListProducto.TabIndex = 13;
            cbListProducto.SelectedIndexChanged += cbListProducto_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 21);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 14;
            label1.Text = "Fecha ";
            // 
            // dtpFecha
            // 
            dtpFecha.Cursor = Cursors.IBeam;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(110, 15);
            dtpFecha.MinDate = new DateTime(2019, 1, 1, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(100, 23);
            dtpFecha.TabIndex = 15;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.ActiveCaption;
            txtTotal.Location = new Point(110, 247);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 52;
            txtTotal.TabStop = false;
            txtTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(69, 250);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 51;
            label8.Text = "Total:";
            // 
            // txtFactura
            // 
            txtFactura.Location = new Point(110, 44);
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(100, 23);
            txtFactura.TabIndex = 53;
            txtFactura.TextChanged += textBox2_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(110, 189);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 55;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(110, 218);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 56;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(379, 237);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 57;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(460, 237);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(92, 23);
            btnEliminar.TabIndex = 58;
            btnEliminar.Text = "Eliminar Fila";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(558, 237);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 59;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbClienteList
            // 
            cbClienteList.FormattingEnabled = true;
            cbClienteList.Location = new Point(110, 73);
            cbClienteList.Name = "cbClienteList";
            cbClienteList.Size = new Size(100, 23);
            cbClienteList.TabIndex = 61;
            cbClienteList.SelectedIndexChanged += cbClienteList_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 76);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 62;
            label9.Text = "Id Cliente: ";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(216, 73);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(100, 23);
            txtNombreCliente.TabIndex = 63;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(216, 102);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 64;
            // 
            // cbusuario
            // 
            cbusuario.FormattingEnabled = true;
            cbusuario.Location = new Point(110, 102);
            cbusuario.Name = "cbusuario";
            cbusuario.Size = new Size(100, 23);
            cbusuario.TabIndex = 65;
            cbusuario.SelectedIndexChanged += cbusuario_SelectedIndexChanged;
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Location = new Point(31, 279);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(0, 15);
            lbInfo.TabIndex = 66;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(432, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(792, 499);
            ControlBox = false;
            Controls.Add(btnEliminar);
            Controls.Add(pictureBox1);
            Controls.Add(lbInfo);
            Controls.Add(cbusuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtNombreCliente);
            Controls.Add(label9);
            Controls.Add(cbClienteList);
            Controls.Add(btnGuardar);
            Controls.Add(btnAgregar);
            Controls.Add(txtSubTotal);
            Controls.Add(txtPrecio);
            Controls.Add(txtFactura);
            Controls.Add(txtTotal);
            Controls.Add(label8);
            Controls.Add(dtpFecha);
            Controls.Add(label1);
            Controls.Add(cbListProducto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCantidad);
            Controls.Add(dgvFactura);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmFactura";
            Text = "FrmFactura";
            WindowState = FormWindowState.Maximized;
            Load += FrmFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFactura;
        private TextBox txtCantidad;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbListProducto;
        private Label label1;
        private DateTimePicker dtpFecha;
        private TextBox txtTotal;
        private Label label8;
        private TextBox txtFactura;
        private TextBox txtPrecio;
        private TextBox txtSubTotal;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnGuardar;
        private ComboBox cbClienteList;
        private Label label9;
        private TextBox txtNombreCliente;
        private TextBox txtNombreUsuario;
        private ComboBox cbusuario;
        private Label lbInfo;
        private PictureBox pictureBox1;
    }
}