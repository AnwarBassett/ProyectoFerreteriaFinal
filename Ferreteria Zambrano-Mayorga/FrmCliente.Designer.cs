namespace Ferreteria_Zambrano_Mayorga
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbRuc = new ComboBox();
            txtId = new TextBox();
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            ckbRuc = new CheckBox();
            pictureBox1 = new PictureBox();
            dgvClientes = new DataGridView();
            btnAñadir = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 43);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 72);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Id Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 101);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Ruc:";
            // 
            // cbRuc
            // 
            cbRuc.FormattingEnabled = true;
            cbRuc.Location = new Point(110, 98);
            cbRuc.Name = "cbRuc";
            cbRuc.Size = new Size(100, 23);
            cbRuc.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(110, 69);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(110, 40);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 11);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // ckbRuc
            // 
            ckbRuc.AutoSize = true;
            ckbRuc.Location = new Point(110, 127);
            ckbRuc.Name = "ckbRuc";
            ckbRuc.Size = new Size(77, 19);
            ckbRuc.TabIndex = 9;
            ckbRuc.Text = "Crear Ruc";
            ckbRuc.UseVisualStyleBackColor = true;
            ckbRuc.CheckedChanged += ckbRuc_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(309, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 193);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(502, 150);
            dgvClientes.TabIndex = 11;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(12, 164);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(75, 23);
            btnAñadir.TabIndex = 12;
            btnAñadir.Text = "Agregar";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 164);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 164);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(526, 355);
            ControlBox = false;
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAñadir);
            Controls.Add(dgvClientes);
            Controls.Add(pictureBox1);
            Controls.Add(ckbRuc);
            Controls.Add(txtNombre);
            Controls.Add(txtContraseña);
            Controls.Add(txtId);
            Controls.Add(cbRuc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCliente";
            Text = "Cliente";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbRuc;
        private TextBox txtId;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private CheckBox ckbRuc;
        private PictureBox pictureBox1;
        private DataGridView dgvClientes;
        private Button btnAñadir;
        private Button btnUpdate;
        private Button btnDelete;
    }
}