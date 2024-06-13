using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Conexion
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private Form6 form6;

        public Form2(Form6 form6)
        {
            InitializeComponent();
            this.form6 = form6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conex();
            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = ("Insert into captura(codigo,nombre,precio,descripcion,existencias,categorias) values('" + txtAgCode.Text + "','" + txtAgNombre.Text + "','" + txtAgPrecio.Text + "','" + txtAgDesc.Text + "','" + txtAgExist.Text + "','" + txtAgCate.Text + "'); "); //esto es para guardarlo
                comando.ExecuteNonQuery();
                conexionBD.Close();//siempre hay que cerrarlo
            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message + a.StackTrace);
            }
            MessageBox.Show("datos registrados correctamente");
        }

        private void txtExist_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLimpiarAct_Click(object sender, EventArgs e)
        {
            txtAgCode.Clear();
            txtAgNombre.Clear();
            txtAgPrecio.Clear();
            txtAgDesc.Clear();
            txtAgExist.Clear();
            txtAgCate.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void text_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conex();
            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = "SELECT * FROM captura WHERE codigo = @codigo";
                comando.Parameters.AddWithValue("@codigo", txtAgCode.Text);

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    txtAgCode.Text = reader["codigo"].ToString();
                    txtAgNombre.Text = reader["nombre"].ToString();
                    txtAgPrecio.Text = reader["precio"].ToString();
                    txtAgDesc.Text = reader["descripcion"].ToString();
                    txtAgExist.Text = reader["existencias"].ToString();
                    txtAgCate.Text = reader["categorias"].ToString();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
                conexionBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            {
                ActualizarProducto();
            }
        }

        private void ActualizarProducto()
        {
            MySqlConnection conexionBD = Conexion.conex();
            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = "UPDATE captura SET nombre = @nombre, descripcion = @descripcion, precio = @precio, existencias = @existencias, categorias = @categorias WHERE codigo = @codigo";
                comando.Parameters.AddWithValue("@codigo", txtAgCode.Text);
                comando.Parameters.AddWithValue("@nombre", txtAgNombre.Text);
                comando.Parameters.AddWithValue("@descripcion", txtAgDesc.Text);
                comando.Parameters.AddWithValue("@precio", txtAgPrecio.Text);
                comando.Parameters.AddWithValue("@existencias", txtAgExist.Text);
                comando.Parameters.AddWithValue("@categorias", txtAgCate.Text);
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Datos actualizados correctamente");
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para actualizar con el código proporcionado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conex();
            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = "DELETE FROM captura WHERE codigo = @codigo";
                comando.Parameters.AddWithValue("@codigo", txtAgCode.Text);
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Datos eliminados correctamente");
                    txtAgCode.Text = "";

                }
                else
                {
                    MessageBox.Show("No se encontraron datos para eliminar con el código proporcionado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
    }
    
