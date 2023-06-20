namespace Ferreteria_Zambrano_Mayorga
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            dtpFecha = new DateTimePicker();
            dgvRuc = new DataGridView();
            cbTipoRuc = new ComboBox();
            cbActivo = new ComboBox();
            btnAgregar = new Button();
            label5 = new Label();
            label6 = new Label();
            btnActualizar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRuc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Ruc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 53);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 85);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha Creacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 116);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Activo";
            // 
            // txtId
            // 
            txtId.Location = new Point(127, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(127, 79);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(100, 23);
            dtpFecha.TabIndex = 7;
            // 
            // dgvRuc
            // 
            dgvRuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRuc.Location = new Point(30, 202);
            dgvRuc.Name = "dgvRuc";
            dgvRuc.RowTemplate.Height = 25;
            dgvRuc.Size = new Size(446, 152);
            dgvRuc.TabIndex = 8;
            // 
            // cbTipoRuc
            // 
            cbTipoRuc.FormattingEnabled = true;
            cbTipoRuc.Items.AddRange(new object[] { "1.Personal", "2.Empresarial" });
            cbTipoRuc.Location = new Point(127, 50);
            cbTipoRuc.Name = "cbTipoRuc";
            cbTipoRuc.Size = new Size(100, 23);
            cbTipoRuc.TabIndex = 9;
            // 
            // cbActivo
            // 
            cbActivo.FormattingEnabled = true;
            cbActivo.Items.AddRange(new object[] { "1.Si", "2.No" });
            cbActivo.Location = new Point(127, 108);
            cbActivo.Name = "cbActivo";
            cbActivo.Size = new Size(100, 23);
            cbActivo.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(401, 173);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 72F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(246, 28);
            label5.Name = "label5";
            label5.Size = new Size(254, 109);
            label5.TabIndex = 12;
            label5.Text = "RUC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 72F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(246, -65);
            label6.Name = "label6";
            label6.Size = new Size(239, 109);
            label6.TabIndex = 13;
            label6.Text = "____";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(320, 173);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(30, 173);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 15;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(512, 355);
            ControlBox = false;
            Controls.Add(btnCerrar);
            Controls.Add(btnActualizar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnAgregar);
            Controls.Add(cbActivo);
            Controls.Add(cbTipoRuc);
            Controls.Add(dgvRuc);
            Controls.Add(dtpFecha);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private DateTimePicker dtpFecha;
        private DataGridView dgvRuc;
        private ComboBox cbTipoRuc;
        private ComboBox cbActivo;
        private Button btnAgregar;
        private Label label5;
        private Label label6;
        private Button btnActualizar;
        private Button btnCerrar;
    }
}