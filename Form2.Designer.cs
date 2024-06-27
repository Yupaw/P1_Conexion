namespace P1_Conexion
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgCode = new System.Windows.Forms.TextBox();
            this.txtAgNombre = new System.Windows.Forms.TextBox();
            this.txtAgDesc = new System.Windows.Forms.TextBox();
            this.txtAgPrecio = new System.Windows.Forms.TextBox();
            this.txtAgExist = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRegMenuF2 = new System.Windows.Forms.Button();
            this.txtAgCate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarCapt = new System.Windows.Forms.Button();
            this.dgvBD = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencias\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAgCode
            // 
            this.txtAgCode.BackColor = System.Drawing.Color.DimGray;
            this.txtAgCode.ForeColor = System.Drawing.Color.White;
            this.txtAgCode.Location = new System.Drawing.Point(105, 175);
            this.txtAgCode.Name = "txtAgCode";
            this.txtAgCode.Size = new System.Drawing.Size(100, 20);
            this.txtAgCode.TabIndex = 5;
            this.txtAgCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtAgCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgCode_KeyPress);
            // 
            // txtAgNombre
            // 
            this.txtAgNombre.BackColor = System.Drawing.Color.DimGray;
            this.txtAgNombre.ForeColor = System.Drawing.Color.White;
            this.txtAgNombre.Location = new System.Drawing.Point(105, 227);
            this.txtAgNombre.Name = "txtAgNombre";
            this.txtAgNombre.Size = new System.Drawing.Size(100, 20);
            this.txtAgNombre.TabIndex = 6;
            this.txtAgNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // txtAgDesc
            // 
            this.txtAgDesc.BackColor = System.Drawing.Color.DimGray;
            this.txtAgDesc.ForeColor = System.Drawing.Color.White;
            this.txtAgDesc.Location = new System.Drawing.Point(105, 325);
            this.txtAgDesc.Name = "txtAgDesc";
            this.txtAgDesc.Size = new System.Drawing.Size(100, 20);
            this.txtAgDesc.TabIndex = 7;
            this.txtAgDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // txtAgPrecio
            // 
            this.txtAgPrecio.BackColor = System.Drawing.Color.DimGray;
            this.txtAgPrecio.ForeColor = System.Drawing.Color.White;
            this.txtAgPrecio.Location = new System.Drawing.Point(105, 280);
            this.txtAgPrecio.Name = "txtAgPrecio";
            this.txtAgPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtAgPrecio.TabIndex = 8;
            this.txtAgPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtAgPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgPrecio_KeyPress);
            // 
            // txtAgExist
            // 
            this.txtAgExist.BackColor = System.Drawing.Color.DimGray;
            this.txtAgExist.ForeColor = System.Drawing.Color.White;
            this.txtAgExist.Location = new System.Drawing.Point(105, 380);
            this.txtAgExist.Name = "txtAgExist";
            this.txtAgExist.Size = new System.Drawing.Size(100, 20);
            this.txtAgExist.TabIndex = 9;
            this.txtAgExist.TextChanged += new System.EventHandler(this.txtExist_TextChanged);
            this.txtAgExist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgExist_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(138, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "CAPTURA DE PRODUCTOS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 132);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(659, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(635, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnRegMenuF2
            // 
            this.btnRegMenuF2.BackColor = System.Drawing.Color.Transparent;
            this.btnRegMenuF2.FlatAppearance.BorderSize = 0;
            this.btnRegMenuF2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegMenuF2.ForeColor = System.Drawing.Color.White;
            this.btnRegMenuF2.Location = new System.Drawing.Point(242, 422);
            this.btnRegMenuF2.Name = "btnRegMenuF2";
            this.btnRegMenuF2.Size = new System.Drawing.Size(84, 43);
            this.btnRegMenuF2.TabIndex = 12;
            this.btnRegMenuF2.Text = "CERRAR SESIÓN";
            this.btnRegMenuF2.UseVisualStyleBackColor = false;
            this.btnRegMenuF2.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAgCate
            // 
            this.txtAgCate.BackColor = System.Drawing.Color.DimGray;
            this.txtAgCate.ForeColor = System.Drawing.Color.White;
            this.txtAgCate.Location = new System.Drawing.Point(105, 429);
            this.txtAgCate.Name = "txtAgCate";
            this.txtAgCate.Size = new System.Drawing.Size(100, 20);
            this.txtAgCate.TabIndex = 29;
            this.txtAgCate.TextChanged += new System.EventHandler(this.txtAgCate_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Categorias";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(242, 324);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 30);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(242, 272);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 37);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(242, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 25);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(242, 222);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 28);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnLimpiarCapt
            // 
            this.btnLimpiarCapt.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarCapt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarCapt.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCapt.Location = new System.Drawing.Point(242, 377);
            this.btnLimpiarCapt.Name = "btnLimpiarCapt";
            this.btnLimpiarCapt.Size = new System.Drawing.Size(84, 28);
            this.btnLimpiarCapt.TabIndex = 35;
            this.btnLimpiarCapt.Text = "LIMPIAR";
            this.btnLimpiarCapt.UseVisualStyleBackColor = false;
            this.btnLimpiarCapt.Click += new System.EventHandler(this.btnLimpiarCapt_Click);
            // 
            // dgvBD
            // 
            this.dgvBD.AllowUserToAddRows = false;
            this.dgvBD.AllowUserToDeleteRows = false;
            this.dgvBD.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvBD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBD.GridColor = System.Drawing.Color.DimGray;
            this.dgvBD.Location = new System.Drawing.Point(369, 175);
            this.dgvBD.Name = "dgvBD";
            this.dgvBD.ReadOnly = true;
            this.dgvBD.Size = new System.Drawing.Size(291, 290);
            this.dgvBD.TabIndex = 36;
            this.dgvBD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBD_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(691, 514);
            this.Controls.Add(this.dgvBD);
            this.Controls.Add(this.btnLimpiarCapt);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtAgCate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegMenuF2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAgExist);
            this.Controls.Add(this.txtAgPrecio);
            this.Controls.Add(this.txtAgDesc);
            this.Controls.Add(this.txtAgNombre);
            this.Controls.Add(this.txtAgCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAgCode;
        private System.Windows.Forms.TextBox txtAgNombre;
        private System.Windows.Forms.TextBox txtAgDesc;
        private System.Windows.Forms.TextBox txtAgPrecio;
        private System.Windows.Forms.TextBox txtAgExist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegMenuF2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtAgCate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarCapt;
        private System.Windows.Forms.DataGridView dgvBD;
    }
}