// ·······················································
// : _     ___ ____  ____  _____ ____  ___    _    ____  :
// :| |   |_ _| __ )|  _ \| ____|  _ \|_ _|  / \  / ___| :
// :| |    | ||  _ \| |_) |  _| | |_) || |  / _ \ \___ \ :
// :| |___ | || |_) |  _ <| |___|  _ < | | / ___ \ ___) |:
// :|_____|___|____/|_| \_\_____|_| \_\___/_/   \_\____/ :
// ·······················································

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
    public partial class Form2 : Form // Declara la clase Form2 que hereda de Form
    {
        public Form2() // Constructor de la clase Form2
        {
            InitializeComponent();
            btnEliminar.Enabled = false; // Deshabilita el botón btnEliminar
            btnActualizar.Enabled = false; // Deshabilita el botón btnActualizar
        }

        // ···············································
        // :    _    ____ ____  _____ ____    _    ____  :
        // :   / \  / ___|  _ \| ____/ ___|  / \  |  _ \ :
        // :  / _ \| |  _| |_) |  _|| |  _  / _ \ | |_) |:
        // : / ___ \ |_| |  _ <| |__| |_| |/ ___ \|  _ < :
        // :/_/   \_\____|_| \_\_____\____/_/   \_\_| \_\:
        // ···············································

        private void AgregarProducto() // Método para agregar un producto a la base de datos
        {
            MySqlConnection conexionBD = Conexion.conex(); // Crea una conexión a la base de datos
            try
            {
                conexionBD.Open(); // Abre la conexión

                // Verificar si el código ya existe
                MySqlCommand verificarComando = new MySqlCommand();
                verificarComando.Connection = conexionBD;
                verificarComando.CommandText = "SELECT COUNT(*) FROM captura WHERE codigo = @codigo";
                verificarComando.Parameters.AddWithValue("@codigo", txtAgCode.Text);
                int count = Convert.ToInt32(verificarComando.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("El código ingresado ya existe. Por favor, ingrese un código diferente.");
                    return;
                }

                MySqlCommand comando = new MySqlCommand(); // Crea un nuevo comando SQL
                comando.Connection = conexionBD; // Establece la conexión del comando
                comando.CommandText = "Insert into captura(codigo,nombre,precio,descripcion,existencias,categorias) values('" + txtAgCode.Text + "','" + txtAgNombre.Text + "','" + txtAgPrecio.Text + "','" + txtAgDesc.Text + "','" + txtAgExist.Text + "','" + txtAgCate.Text + "'); "; // Establece la consulta SQL para insertar un nuevo producto
                comando.ExecuteNonQuery(); // Ejecuta la consulta SQL
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + a.StackTrace); // Muestra un mensaje de error si ocurre una excepción
            }
            MessageBox.Show("datos registrados correctamente"); // Muestra un mensaje de éxito

            LimpiarCuadrosDeTexto(); // Limpia los cuadros de texto
            MostrarProductos(); // Actualiza el DataGridView mostrando los productos actualizados
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            AgregarProducto(); // Llama al método para agregar un producto
        }

        // ·········································
        // : ____  _   _ ____   ____    _    ____  :
        // :| __ )| | | / ___| / ___|  / \  |  _ \ :
        // :|  _ \| | | \___ \| |     / _ \ | |_) |:
        // :| |_) | |_| |___) | |___ / ___ \|  _ < :
        // :|____/ \___/|____/ \____/_/   \_\_| \_\:
        // ·········································

        private void BuscarProducto() // Método para buscar un producto en la base de datos
        {
            MySqlConnection conexionBD = Conexion.conex(); // Crea una conexión a la base de datos
            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = "SELECT * FROM captura WHERE codigo = @codigo";
                comando.Parameters.AddWithValue("@codigo", txtAgCode.Text);

                MySqlDataReader reader = comando.ExecuteReader(); // Ejecuta la consulta SQL y obtiene un lector de datos
                if (reader.Read()) // Si se encontró un producto
                {
                    // Asigna los valores del producto encontrado a los cuadros de texto correspondientes
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

                btnEliminar.Enabled = true; // Habilita el botón de eliminar
                btnActualizar.Enabled = true; // Habilita el botón de actualizar

                conexionBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            BuscarProducto(); // Llama al método para buscar un producto
        }

        // ································································
        // :    _    ____ _____ _   _   _    _     ___ _____   _    ____  :
        // :   / \  / ___|_   _| | | | / \  | |   |_ _|__  /  / \  |  _ \ :
        // :  / _ \| |     | | | | | |/ _ \ | |    | |  / /  / _ \ | |_) |:
        // : / ___ \ |___  | | | |_| / ___ \| |___ | | / /_ / ___ \|  _ < :
        // :/_/   \_\____| |_|  \___/_/   \_\_____|___/____/_/   \_\_| \_\:
        // ································································

        private void ActualizarProducto() // Método para actualizar un producto en la base de datos
        {
            MySqlConnection conexionBD = Conexion.conex();
            try
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas actualizar este producto?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Muestra un mensaje de confirmación

                if (resultado == DialogResult.Yes) // Si se confirma la actualización
                {
                    conexionBD.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = conexionBD;
                    comando.CommandText = "UPDATE captura SET nombre = @nombre, descripcion = @descripcion, precio = @precio, existencias = @existencias, categorias = @categorias WHERE codigo = @codigo"; // Establece la consulta SQL para actualizar un producto
                    comando.Parameters.AddWithValue("@codigo", txtAgCode.Text); // Asigna el valor del código del producto a actualizar
                    comando.Parameters.AddWithValue("@nombre", txtAgNombre.Text); // Asigna el valor del nombre del producto a actualizar
                    comando.Parameters.AddWithValue("@descripcion", txtAgDesc.Text); // Asigna el valor de la descripción del producto a actualizar
                    comando.Parameters.AddWithValue("@precio", txtAgPrecio.Text); // Asigna el valor del precio del producto a actualizar
                    comando.Parameters.AddWithValue("@existencias", txtAgExist.Text); // Asigna el valor de las existencias del producto a actualizar
                    comando.Parameters.AddWithValue("@categorias", txtAgCate.Text); // Asigna el valor de la categoría del producto a actualizar
                    int filasAfectadas = comando.ExecuteNonQuery(); // Ejecuta la consulta SQL y devuelve el número de filas afectadas
                    if (filasAfectadas > 0) // Si se actualizó al menos una fila
                    {
                        MessageBox.Show("Datos actualizados correctamente");
                        MostrarProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para actualizar con el código proporcionado");
                    }
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
            LimpiarCuadrosDeTexto();
            btnActualizar.Enabled = false;
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            ActualizarProducto(); // Llama al método para actualizar un producto
        }

        // ··················································
        // : _____ _     ___ __  __ ___ _   _    _    ____  :
        // :| ____| |   |_ _|  \/  |_ _| \ | |  / \  |  _ \ :
        // :|  _| | |    | || |\/| || ||  \| | / _ \ | |_) |:
        // :| |___| |___ | || |  | || || |\  |/ ___ \|  _ < :
        // :|_____|_____|___|_|  |_|___|_| \_/_/   \_\_| \_\:
        // ··················································

        private void EliminarProducto() // Método para eliminar un producto de la base de datos
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                MySqlConnection conexionBD = Conexion.conex();
                try
                {
                    conexionBD.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = conexionBD;
                    comando.CommandText = "DELETE FROM captura WHERE codigo = @codigo"; // Establece la consulta SQL para eliminar un producto por su código
                    comando.Parameters.AddWithValue("@codigo", txtAgCode.Text); // Asigna el valor del código del producto a eliminar
                    comando.ExecuteNonQuery(); // Ejecuta la consulta SQL
                    MessageBox.Show("Datos eliminados correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar datos: " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                    LimpiarCuadrosDeTexto();
                    MostrarProductos();
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            EliminarProducto(); // Llama al método para eliminar un producto
        }

        // ···········································
        // : _     ___ __  __ ____ ___    _    ____  :
        // :| |   |_ _|  \/  |  _ \_ _|  / \  |  _ \ :
        // :| |    | || |\/| | |_) | |  / _ \ | |_) |:
        // :| |___ | || |  | |  __/| | / ___ \|  _ < :
        // :|_____|___|_|  |_|_|  |___/_/   \_\_| \_\:
        // ···········································

        private void LimpiarCuadrosDeTexto() // Define el método LimpiarCuadrosDeTexto
        {
            txtAgCode.Clear(); // Limpia el cuadro de texto txtAgCode
            txtAgNombre.Clear(); // Limpia el cuadro de texto txtAgNombre
            txtAgPrecio.Clear(); // Limpia el cuadro de texto txtAgPrecio
            txtAgDesc.Clear(); // Limpia el cuadro de texto txtAgDesc
            txtAgExist.Clear(); // Limpia el cuadro de texto txtAgExist
            txtAgCate.Clear(); // Limpia el cuadro de texto txtAgCate

            btnEliminar.Enabled = false; // Deshabilita el botón btnEliminar
            btnActualizar.Enabled = false; // Deshabilita el botón btnActualizar
        }

        private void btnLimpiarCapt_Click(object sender, EventArgs e)
        {
            LimpiarCuadrosDeTexto(); // Llama al método para limpiar los cuadros de texto

            MessageBox.Show("Se han limpiado todos los cuadros de texto."); // Muestra un mensaje indicando que se limpiaron los cuadros de texto
        }


        // ····································································
        // : _____ _   _ _   _  ____ ___ ___  _   _ _____ ____    ____  _____ :
        // :|  ___| | | | \ | |/ ___|_ _/ _ \| \ | | ____/ ___|  |  _ \| ____|:
        // :| |_  | | | |  \| | |    | | | | |  \| |  _| \___ \  | | | |  _|  :
        // :|  _| | |_| | |\  | |___ | | |_| | |\  | |___ ___) | | |_| | |___ :
        // :|_|    \___/|_| \_|\____|___\___/|_|_\_|_____|____/_ |____/|_____|:
        // :| |      / \    |_ _| \ | |_   _| ____|  _ \|  ___/ \   |__  /    :
        // :| |     / _ \    | ||  \| | | | |  _| | |_) | |_ / _ \    / /     :
        // :| |___ / ___ \   | || |\  | | | | |___|  _ <|  _/ ___ \  / /_     :
        // :|_____/_/   \_\ |___|_| \_| |_| |_____|_| \_\_|/_/   \_\/____|    :
        // ····································································

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")] // Importa la función ReleaseCapture de user32.dll basicamente sirve para poder mover la pestaña
        private extern static void ReleaseCapture(); // Declara externamente la función ReleaseCapture 

        [DllImport("user32.dll", EntryPoint = "SendMessage")] // Importa la función SendMessage de user32.dll 
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam); // Declara externamente la función SendMessage

        private void Form2_Load(object sender, EventArgs e)
        {
            MostrarProductos(); // Llama al método para mostrar productos en el DataGridView
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abre el Form3 y cierra el Form actual
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza la ventana actual

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        private void txtAgCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Verifica si la tecla presionada no es de control y no es un dígito
            {
                e.Handled = true; // Indica que la tecla presionada no será procesada
            }
        }

        private void txtAgPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAgExist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void MostrarProductos() // Método para mostrar los productos en el DataGridView
        {
            MySqlConnection conexionBD = Conexion.conex();
            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = "SELECT * FROM captura";

                DataTable dt = new DataTable(); // Crea un nuevo DataTable
                dt.Load(comando.ExecuteReader()); // Carga los datos del comando al DataTable

                dgvBD.DataSource = dt; // Establece el origen de datos del DataGridView al DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            finally
            {
                conexionBD.Close(); // Cierra la conexión
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); // Llama a la función ReleaseCapture para permitir mover la ventana sin bordes
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Envía un mensaje al sistema operativo para simular el arrastre de la ventana
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void text_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dgvBD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtAgCate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}