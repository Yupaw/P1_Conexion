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
            System.Windows.Forms.Button btnAgregar;
            System.Windows.Forms.Button btnLimpiarCapt;
            System.Windows.Forms.Button btnbuscar;
            System.Windows.Forms.Button btnActualizar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Button btnEliminar;
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
            btnAgregar = new System.Windows.Forms.Button();
            btnLimpiarCapt = new System.Windows.Forms.Button();
            btnbuscar = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = System.Drawing.Color.Transparent;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAgregar.ForeColor = System.Drawing.Color.White;
            btnAgregar.Location = new System.Drawing.Point(291, 183);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(84, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR\r\n";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiarCapt
            // 
            btnLimpiarCapt.BackColor = System.Drawing.Color.Transparent;
            btnLimpiarCapt.FlatAppearance.BorderSize = 0;
            btnLimpiarCapt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnLimpiarCapt.ForeColor = System.Drawing.Color.White;
            btnLimpiarCapt.Location = new System.Drawing.Point(291, 370);
            btnLimpiarCapt.Name = "btnLimpiarCapt";
            btnLimpiarCapt.Size = new System.Drawing.Size(84, 23);
            btnLimpiarCapt.TabIndex = 27;
            btnLimpiarCapt.Text = "LIMPIAR";
            btnLimpiarCapt.UseVisualStyleBackColor = false;
            btnLimpiarCapt.Click += new System.EventHandler(this.btnLimpiarAct_Click);
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = System.Drawing.Color.Transparent;
            btnbuscar.FlatAppearance.BorderSize = 0;
            btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnbuscar.ForeColor = System.Drawing.Color.White;
            btnbuscar.Location = new System.Drawing.Point(291, 284);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new System.Drawing.Size(84, 23);
            btnbuscar.TabIndex = 30;
            btnbuscar.Text = "BUSCAR";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = System.Drawing.Color.Transparent;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnActualizar.ForeColor = System.Drawing.Color.White;
            btnActualizar.Location = new System.Drawing.Point(291, 236);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(84, 23);
            btnActualizar.TabIndex = 31;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 238);
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
            this.label3.Location = new System.Drawing.Point(57, 333);
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
            this.label4.Location = new System.Drawing.Point(57, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencias";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAgCode
            // 
            this.txtAgCode.BackColor = System.Drawing.Color.DimGray;
            this.txtAgCode.ForeColor = System.Drawing.Color.White;
            this.txtAgCode.Location = new System.Drawing.Point(142, 183);
            this.txtAgCode.Name = "txtAgCode";
            this.txtAgCode.Size = new System.Drawing.Size(100, 20);
            this.txtAgCode.TabIndex = 5;
            this.txtAgCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAgNombre
            // 
            this.txtAgNombre.BackColor = System.Drawing.Color.DimGray;
            this.txtAgNombre.ForeColor = System.Drawing.Color.White;
            this.txtAgNombre.Location = new System.Drawing.Point(142, 238);
            this.txtAgNombre.Name = "txtAgNombre";
            this.txtAgNombre.Size = new System.Drawing.Size(100, 20);
            this.txtAgNombre.TabIndex = 6;
            this.txtAgNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // txtAgDesc
            // 
            this.txtAgDesc.BackColor = System.Drawing.Color.DimGray;
            this.txtAgDesc.ForeColor = System.Drawing.Color.White;
            this.txtAgDesc.Location = new System.Drawing.Point(142, 333);
            this.txtAgDesc.Name = "txtAgDesc";
            this.txtAgDesc.Size = new System.Drawing.Size(100, 20);
            this.txtAgDesc.TabIndex = 7;
            this.txtAgDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // txtAgPrecio
            // 
            this.txtAgPrecio.BackColor = System.Drawing.Color.DimGray;
            this.txtAgPrecio.ForeColor = System.Drawing.Color.White;
            this.txtAgPrecio.Location = new System.Drawing.Point(142, 284);
            this.txtAgPrecio.Name = "txtAgPrecio";
            this.txtAgPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtAgPrecio.TabIndex = 8;
            this.txtAgPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtAgExist
            // 
            this.txtAgExist.BackColor = System.Drawing.Color.DimGray;
            this.txtAgExist.ForeColor = System.Drawing.Color.White;
            this.txtAgExist.Location = new System.Drawing.Point(142, 388);
            this.txtAgExist.Name = "txtAgExist";
            this.txtAgExist.Size = new System.Drawing.Size(100, 20);
            this.txtAgExist.TabIndex = 9;
            this.txtAgExist.TextChanged += new System.EventHandler(this.txtExist_TextChanged);
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
            this.panel1.Size = new System.Drawing.Size(421, 132);
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
            this.pictureBox3.Location = new System.Drawing.Point(389, 12);
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
            this.pictureBox4.Location = new System.Drawing.Point(365, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.btnRegMenuF2.Location = new System.Drawing.Point(291, 415);
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
            this.txtAgCate.Location = new System.Drawing.Point(142, 438);
            this.txtAgCate.Name = "txtAgCate";
            this.txtAgCate.Size = new System.Drawing.Size(100, 20);
            this.txtAgCate.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(57, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Categorias";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.Color.Transparent;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEliminar.ForeColor = System.Drawing.Color.White;
            btnEliminar.Location = new System.Drawing.Point(291, 328);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(84, 23);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(421, 525);
            this.Controls.Add(btnEliminar);
            this.Controls.Add(btnActualizar);
            this.Controls.Add(btnbuscar);
            this.Controls.Add(this.txtAgCate);
            this.Controls.Add(this.label7);
            this.Controls.Add(btnLimpiarCapt);
            this.Controls.Add(this.btnRegMenuF2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(btnAgregar);
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
            this.ForeColor = System.Drawing.Color.Transparent;
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
    }
}