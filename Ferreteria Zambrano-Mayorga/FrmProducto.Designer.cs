namespace Ferreteria_Zambrano_Mayorga
{
    partial class FrmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            dgwProducto = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            txtDescripcion = new TextBox();
            label7 = new Label();
            txtPrecio = new TextBox();
            label8 = new Label();
            txtIdProducto = new TextBox();
            dtpFecha = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            cbCategoria = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            pictureBox1 = new PictureBox();
            cbCategoriaFiltro = new ComboBox();
            PanelAdd = new Panel();
            pCategoria = new Panel();
            label11 = new Label();
            btnActivarPanel = new Button();
            cbProveedor = new ComboBox();
            btnFiltro = new Button();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelAdd.SuspendLayout();
            pCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 86);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 107);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 35;
            label3.Text = "Id Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 107);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 33;
            label2.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(81, 104);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 32;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 49);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 31;
            label1.Text = "Nombre ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(81, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 30;
            // 
            // dgwProducto
            // 
            dgwProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducto.Location = new Point(12, 288);
            dgwProducto.Name = "dgwProducto";
            dgwProducto.RowTemplate.Height = 25;
            dgwProducto.Size = new Size(589, 185);
            dgwProducto.TabIndex = 38;
            dgwProducto.SelectionChanged += dgwProducto_SelectionChanged;
            // 
            // label5
            // 
            label5.Location = new Point(609, 32);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 48;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(191, 49);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 44;
            label6.Text = "Descripcion";
            label6.Click += label6_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(276, 46);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(121, 23);
            txtDescripcion.TabIndex = 43;
            txtDescripcion.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 78);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 42;
            label7.Text = "Precio";
            label7.Click += label7_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(81, 75);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 41;
            txtPrecio.TextChanged += textBox3_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 20);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 40;
            label8.Text = "IdProducto";
            label8.Click += label8_Click;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(81, 17);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 39;
            txtIdProducto.TextChanged += textBox4_TextChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(276, 14);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(121, 23);
            dtpFecha.TabIndex = 47;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(191, 20);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 49;
            label9.Text = "Fecha";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(191, 75);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 50;
            label10.Text = "Categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "", "Fontaneria", "Herramientas", "Fijacion", "Sellador", "Construccion", "Iluminacion", "Cerrajeria", "Jardineria" });
            cbCategoria.Location = new Point(276, 75);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(121, 23);
            cbCategoria.TabIndex = 51;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 131);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 52;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 133);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 133);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 55;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(445, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cbCategoriaFiltro
            // 
            cbCategoriaFiltro.FormattingEnabled = true;
            cbCategoriaFiltro.Items.AddRange(new object[] { "", "Fontaneria", "Herramientas", "Fijacion", "Sellador", "Construccion", "Iluminacion", "Cerrajeria", "Jardineria" });
            cbCategoriaFiltro.Location = new Point(171, 14);
            cbCategoriaFiltro.Name = "cbCategoriaFiltro";
            cbCategoriaFiltro.Size = new Size(121, 23);
            cbCategoriaFiltro.TabIndex = 58;
            cbCategoriaFiltro.TextChanged += comboBox1_TextChanged;
            // 
            // PanelAdd
            // 
            PanelAdd.Controls.Add(cbProveedor);
            PanelAdd.Controls.Add(btnFiltro);
            PanelAdd.Controls.Add(dtpFecha);
            PanelAdd.Controls.Add(txtNombre);
            PanelAdd.Controls.Add(label1);
            PanelAdd.Controls.Add(btnUpdate);
            PanelAdd.Controls.Add(txtCantidad);
            PanelAdd.Controls.Add(btnDelete);
            PanelAdd.Controls.Add(label2);
            PanelAdd.Controls.Add(btnAdd);
            PanelAdd.Controls.Add(cbCategoria);
            PanelAdd.Controls.Add(label3);
            PanelAdd.Controls.Add(label10);
            PanelAdd.Controls.Add(label4);
            PanelAdd.Controls.Add(label9);
            PanelAdd.Controls.Add(txtIdProducto);
            PanelAdd.Controls.Add(label8);
            PanelAdd.Controls.Add(txtPrecio);
            PanelAdd.Controls.Add(label6);
            PanelAdd.Controls.Add(label7);
            PanelAdd.Controls.Add(txtDescripcion);
            PanelAdd.Location = new Point(12, 1);
            PanelAdd.Name = "PanelAdd";
            PanelAdd.Size = new Size(417, 179);
            PanelAdd.TabIndex = 59;
            // 
            // pCategoria
            // 
            pCategoria.Controls.Add(label11);
            pCategoria.Controls.Add(btnActivarPanel);
            pCategoria.Controls.Add(cbCategoriaFiltro);
            pCategoria.Location = new Point(12, 186);
            pCategoria.Name = "pCategoria";
            pCategoria.Size = new Size(307, 63);
            pCategoria.TabIndex = 63;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label11.Location = new Point(6, 13);
            label11.Name = "label11";
            label11.Size = new Size(162, 24);
            label11.TabIndex = 60;
            label11.Text = "Filtrar Categoria";
            // 
            // btnActivarPanel
            // 
            btnActivarPanel.Location = new Point(6, 40);
            btnActivarPanel.Name = "btnActivarPanel";
            btnActivarPanel.Size = new Size(112, 23);
            btnActivarPanel.TabIndex = 61;
            btnActivarPanel.Text = "Agregar Producto";
            btnActivarPanel.UseVisualStyleBackColor = true;
            btnActivarPanel.Click += btnActivarPanel_Click;
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(276, 104);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(121, 23);
            cbProveedor.TabIndex = 57;
            cbProveedor.SelectedIndexChanged += cbProveedor_SelectedIndexChanged;
            cbProveedor.KeyPress += cbProveedor_KeyPress;
            // 
            // btnFiltro
            // 
            btnFiltro.Location = new Point(339, 153);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(75, 23);
            btnFiltro.TabIndex = 56;
            btnFiltro.Text = "Filtrar";
            btnFiltro.UseVisualStyleBackColor = true;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(460, 48);
            label12.Name = "label12";
            label12.Size = new Size(132, 29);
            label12.TabIndex = 62;
            label12.Text = "Productos";
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(612, 483);
            ControlBox = false;
            Controls.Add(pCategoria);
            Controls.Add(label12);
            Controls.Add(PanelAdd);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(dgwProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducto";
            Text = "FrmProducto";
            WindowState = FormWindowState.Maximized;
            Load += FrmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelAdd.ResumeLayout(false);
            PanelAdd.PerformLayout();
            pCategoria.ResumeLayout(false);
            pCategoria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCantidad;
        private Label label1;
        private TextBox txtNombre;
        private DataGridView dgwProducto;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox txtDescripcion;
        private Label label7;
        private TextBox txtPrecio;
        private Label label8;
        private TextBox txtIdProducto;
        private DateTimePicker dtpFecha;
        private Label label9;
        private Label label10;
        private ComboBox cbCategoria;
        private Button btnAdd;
        private Button button2;
        private Button btnDelete;
        private Button btnUpdate;
        private PictureBox pictureBox1;
        private ComboBox cbCategoriaFiltro;
        private Panel PanelAdd;
        private Label label11;
        private Button btnActivarPanel;
        private Label label12;
        private Panel pCategoria;
        private Button btnFiltro;
        private ComboBox cbProveedor;
    }
}