using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cajero_Electronico
{
    public partial class Login : Form
    {
        #region Variables
        public static string ID;
        public static string NCuenta;
        public bool Ok = false;
        string CNCuenta;
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-LOSUUGM;Initial Catalog=Usuarios_CajeroElectronico;Integrated Security=True");
        #endregion
        public Login()
        {
            InitializeComponent();
        }
        //Ejecutar el código "SoloNumeros"
        public void NTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ejecuta el código que solo permite números en el texto
            SoloNumeros(e);
        }
        public void PIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        //Código que solo permite números en el Textbox
        public bool SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return e.Handled;
        }
        //Código que se ejecuta al presionar el botón "Sguiente"
        public void button1_Click(object sender, EventArgs e)
        {
            IniciarSesion();
            //Sí los campos de texto están vacíos notifica al usuario 
            if (NTarjeta.Text == "" && PIN.Text == "")
            {
                MessageBox.Show("No has introducido ningún dato!", "Error");
            }
        }
        //Cierra la aplicación al pulsar el botón "Salir"
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IniciarSesion()
        {

            cn.Open();
            SqlCommand cm = new SqlCommand("select Num_Cuenta, PIN, id from Usuario where Num_Cuenta='" + NTarjeta.Text + "' and PIN='" + PIN.Text + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                ID = dr["id"].ToString();
                NCuenta = dr["Num_Cuenta"].ToString();
                MessageBox.Show("Bienvenido!", "Sistema");
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();

            }
            else if (NTarjeta.Text != "" || PIN.Text != "")
            {
                MessageBox.Show("Número de Cuenta o PIN Incorrectos", "Error");
            }
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CrearUsuario.Visible = false;
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrearUsuario.Dock = DockStyle.Fill;
            CrearUsuario.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XOX();
        }
        private void XOX()
        {
            if (NuevoPIN.Text != "" && NuevoNCuenta.Text != "" && NNombre.Text != "")
            {
                if (NuevoPIN.Text == CNPIN.Text)
                {
                    SqlCommand Revision_NoRepeticion = new SqlCommand("Select Num_Cuenta from Usuario where Num_Cuenta='" + NuevoNCuenta.Text + "'", cn);

                    cn.Open();
                    SqlDataReader reader = Revision_NoRepeticion.ExecuteReader();
                    if (reader.Read())
                    {
                        CNCuenta = (reader["Num_Cuenta"].ToString());
                    }

                    reader.Close();
                    if (CNCuenta != NuevoNCuenta.Text && NuevoNCuenta.Text.Length == 6)
                    {
                        SqlCommand cm = new SqlCommand("Insert into Usuario (Num_Cuenta, PIN) values ('" + NuevoNCuenta.Text + "', '" + NuevoPIN.Text + "' )", cn);
                        SqlCommand command = new SqlCommand("Insert into Datos (Nombre, Dinero) values ('" + NNombre.Text + "', '" + 500 + "' )", cn);
                        cm.ExecuteNonQuery();
                        reader.Close();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Tu cuenta se ha creado correctamente!", "Sistema");
                        reader.Close();
                        CrearUsuario.Hide();


                    }
                    else if (NuevoNCuenta.Text.Length != 6)
                    {
                        MessageBox.Show("El número de cuenta debe ser de 6 dígitos!", "Error");
                        cn.Close();
                        return;
                    }
                    else
                    {

                        MessageBox.Show("Este Número de Cuenta ya existe!", "Error");
                        cn.Close();
                        return;
                    }



                    cn.Close();
                }
                else
                {
                    MessageBox.Show("El PIN y la confirmación de PIN no coinciden", "Error");
                }
            }
            else if (NuevoPIN.Text == "" || NuevoNCuenta.Text == "" || NNombre.Text == "" || CNPIN.Text == "")
            {

                MessageBox.Show("Debes rellenar todos los campos!", "Error");
                return;

            }
            else
            {
                MessageBox.Show("No has introducido ningún dato!", "Error");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
       
    
  

