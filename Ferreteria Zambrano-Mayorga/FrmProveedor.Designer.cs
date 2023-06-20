namespace Ferreteria_Zambrano_Mayorga
{
    partial class FrmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedor));
            label4 = new Label();
            txtDoc = new TextBox();
            label3 = new Label();
            txtAdress = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            dgwProveedor = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            cbListRuc = new ComboBox();
            checkBox1 = new CheckBox();
            txtBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgwProveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 99);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 22;
            label4.Text = "Numero Documento";
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(137, 96);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(100, 23);
            txtDoc.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 70);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 20;
            label3.Text = "Direccion";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(137, 67);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(100, 23);
            txtAdress.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 44);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 18;
            label2.Text = "Id Proveedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre Proveedor";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 128);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 23;
            label5.Text = "ID Ruc";
            // 
            // dgwProveedor
            // 
            dgwProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProveedor.Location = new Point(3, 268);
            dgwProveedor.Name = "dgwProveedor";
            dgwProveedor.RowTemplate.Height = 25;
            dgwProveedor.Size = new Size(558, 262);
            dgwProveedor.TabIndex = 25;
            dgwProveedor.SelectionChanged += dgwProveedor_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(328, 239);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(409, 239);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(486, 239);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(328, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(368, 12);
            label6.Name = "label6";
            label6.Size = new Size(139, 26);
            label6.TabIndex = 30;
            label6.Text = "Proveedores";
            // 
            // cbListRuc
            // 
            cbListRuc.FormattingEnabled = true;
            cbListRuc.Location = new Point(137, 125);
            cbListRuc.Name = "cbListRuc";
            cbListRuc.Size = new Size(100, 23);
            cbListRuc.TabIndex = 32;
            cbListRuc.SelectedIndexChanged += cbListRuc_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(137, 154);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 19);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "Añadir RUC";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(137, 41);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(100, 23);
            txtBox1.TabIndex = 33;
            txtBox1.KeyPress += txtBox1_KeyPress;
            // 
            // FrmProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(567, 536);
            ControlBox = false;
            Controls.Add(txtBox1);
            Controls.Add(cbListRuc);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgwProveedor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDoc);
            Controls.Add(label3);
            Controls.Add(txtAdress);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmProveedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Proveedor";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += FrmProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtDoc;
        private Label label3;
        private TextBox txtAdress;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private Label label5;
        private DataGridView dgwProveedor;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private PictureBox pictureBox1;
        private Label label6;
        private ComboBox cbListRuc;
        private CheckBox checkBox1;
        private TextBox txtBox1;
    }
}