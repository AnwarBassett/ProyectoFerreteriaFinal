namespace Ferreteria_Zambrano_Mayorga
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            label1 = new Label();
            txtIdUsuario = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtNombreUser = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dgwUsuario = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            cbruc = new ComboBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgwUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "IdUsuario";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(162, 13);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(162, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 50);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre Completo";
            // 
            // txtNombreUser
            // 
            txtNombreUser.Location = new Point(162, 71);
            txtNombreUser.Name = "txtNombreUser";
            txtNombreUser.Size = new Size(100, 23);
            txtNombreUser.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 79);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre Usuario";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 108);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(162, 129);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 137);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 8;
            label5.Text = "Descripcion Empleado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 166);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 10;
            label6.Text = "IdRuc";
            // 
            // dgwUsuario
            // 
            dgwUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwUsuario.Location = new Point(30, 262);
            dgwUsuario.Name = "dgwUsuario";
            dgwUsuario.RowTemplate.Height = 25;
            dgwUsuario.Size = new Size(456, 216);
            dgwUsuario.TabIndex = 12;
            dgwUsuario.SelectionChanged += dgwUsuario_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(249, 233);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(330, 233);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(411, 233);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(320, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(350, 50);
            label7.Name = "label7";
            label7.Size = new Size(102, 26);
            label7.TabIndex = 31;
            label7.Text = "Usuarios";
            // 
            // cbruc
            // 
            cbruc.FormattingEnabled = true;
            cbruc.Location = new Point(162, 158);
            cbruc.Name = "cbruc";
            cbruc.Size = new Size(100, 23);
            cbruc.TabIndex = 32;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(162, 187);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 19);
            checkBox1.TabIndex = 33;
            checkBox1.Text = "Agregar Ruc";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(527, 489);
            ControlBox = false;
            Controls.Add(checkBox1);
            Controls.Add(cbruc);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgwUsuario);
            Controls.Add(label6);
            Controls.Add(txtDescripcion);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtNombreUser);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtIdUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            WindowState = FormWindowState.Maximized;
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgwUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdUsuario;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtNombreUser;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label5;
        private Label label6;
        private DataGridView dgwUsuario;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private PictureBox pictureBox1;
        private Label label7;
        private ComboBox cbruc;
        private CheckBox checkBox1;
    }
}