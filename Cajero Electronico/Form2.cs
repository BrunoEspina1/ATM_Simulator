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
    public partial class Form2 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-LOSUUGM;Initial Catalog=Usuarios_CajeroElectronico;Integrated Security=True");
        Login login = new Login();
        int CDinero;
        string[] Movimientos = new string[] {"Retiro de efectivo", "Deposito de efectivo"};
        public Form2()
        {
            InitializeComponent();
            IDCuenta();
            AcoplarPaneles();
            
        }
        //Aquí también se guarda la configuración del menú "Estado de Cuenta"
        private void IDCuenta()
        {
            SqlCommand cm = new SqlCommand("Select Usuario.Num_Cuenta,Usuario.id, Datos.Nombre, Datos.id, Datos.Dinero from Usuario inner join Datos on Usuario.id = Datos.id where Usuario.id ='"+ Login.ID+"'", cn);
            cn.Open();
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                Cuenta.Text = reader["Num_Cuenta"].ToString();
                Nombre.Text = reader["Nombre"].ToString() + "!";
                Dinero.Text = "$" + reader["Dinero"].ToString();
                Nombre2.Text = reader["Nombre"].ToString();
            }
            cn.Close();
        }
        #region Configuración de los botones del menú
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            IDCuenta();
            Estado_de_Cuenta.Visible = true;
            Estado_de_Cuenta.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListaMovimientos.Items.Clear();
            OcultarPaneles();
            Movimientos_Recientes.Visible = true;
            Movimientos_Recientes.Show();
            ListaMovimientos_Load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            Retiro_Rapido.Visible = true;
            Retiro_Rapido.Show();
        }
        private void Deposito_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            Deposito_Rapido.Visible = true;
            Deposito_Rapido.Show();
        }

        private void AcoplarPaneles()
        {
            Panel_principal.Dock = DockStyle.Fill;
            Estado_de_Cuenta.Dock = DockStyle.Fill;
            Movimientos_Recientes.Dock = DockStyle.Fill;
            Retiro_Rapido.Dock = DockStyle.Fill;
            Deposito_Rapido.Dock = DockStyle.Fill;
        }

        private void OcultarPaneles()
        {
            Estado_de_Cuenta.Visible = false;
            Movimientos_Recientes.Visible = false;
            Retiro_Rapido.Visible = false;
            Panel_principal.Visible = false;
            Deposito_Rapido.Visible = false;

        }
        #endregion
        #region  Menú Retiro
        private void RetirarDinero(int V = 0)
        {
            SqlCommand cm = new SqlCommand("Select id, Dinero from Datos where id='" + Login.ID + "'", cn);
            cn.Open();
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                CDinero = Int32.Parse(reader["Dinero"].ToString());
                if (CDinero > V)
                {
                    CDinero -= V;
                }
                else
                {
                    MessageBox.Show("No cuentas con los fondos suficientes!", "Sistema");
                    reader.Close();
                    cn.Close();
                    return;
                }
                reader.Close();
                SqlCommand command = new SqlCommand("UPDATE Datos Set Dinero='" + CDinero + "' where id = '" + Login.ID + "'", cn);
                
                int cant;
                cant = command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Retiro Exitoso. Tu nuevo saldo es:" + CDinero, "Sistema");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Sistema");
                }
                //Comando para actualizar los movimientos para la pestaña de movimientos recientes
                SqlCommand com = new SqlCommand("Insert into Movimientos (id_Usuario, id_Movimiento, Cantidad) values ('" + Login.ID + "', 0, '" + V + "');", cn);
                com.ExecuteNonQuery();



            }

            cn.Close();
            CDinero = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RetirarDinero(20);
        }

        private void Retirar50_Click(object sender, EventArgs e)
        {
            RetirarDinero(50);
        }

        private void Retirar100_Click(object sender, EventArgs e)
        {
            RetirarDinero(100);
        }
        private void Retirarn()
        {
            int n;
            if (RetirarX.Text != "")
            {
                n = Int32.Parse(RetirarX.Text);
                RetirarDinero(n);
            }
            else
            {
                MessageBox.Show("No has introducido ninguna cantidad!", "Sistema");
            }
            RetirarX.Text = "";
        }

        private void Retirar_Click(object sender, EventArgs e)
        {
            Retirarn();
        }
        #endregion

      
        private void ListaMovimientos_Load()
        {
            List<int> moves = new List<int>();
            List<int> ct = new List<int>();
            SqlCommand cm = new SqlCommand("Select id_Movimiento, Cantidad from Movimientos where id_Usuario = '" + Login.ID + "'", cn);
            cn.Open();
            SqlDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                moves.Add(Convert.ToInt32(reader["id_Movimiento"]));
                ct.Add(Convert.ToInt32(reader["Cantidad"]));


            }
            int x = moves.Count;
            for (int i = 0; i < x; i++)
            {

                ListaMovimientos.Items.Add("" + Movimientos[moves[i]] + " $" + ct[i]);
            }

            cn.Close();
        }
        private void Depositar_Dinero()
        {
            int X = Convert.ToInt32(CantidadDeposito.Text);
            SqlCommand cm = new SqlCommand("Select id, Dinero from Datos where id='" + Login.ID + "'", cn);
            cn.Open();
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                CDinero = Int32.Parse(reader["Dinero"].ToString());
                if (CDinero >= X)
                {
                    CDinero -= X;
                }
                else
                {
                    MessageBox.Show("No cuentas con los fondos suficientes!", "Sistema");
                    reader.Close();
                    cn.Close();
                    return;
                }
                
                SqlCommand command = new SqlCommand("UPDATE Datos Set Dinero='" + CDinero + "' where id = '" + Login.ID + "'", cn);
                reader.Close();
                //Añade Dinero a la otra cuenta
                int IDDestinatario = 0;
                SqlCommand GetID = new SqlCommand("Select Num_Cuenta, id from Usuario where Num_Cuenta = '" +NCuentaDestinatario.Text + "'", cn);
                SqlDataReader dataReader = GetID.ExecuteReader();
                if (dataReader.Read())
                {
                    IDDestinatario = Convert.ToInt32(dataReader["id"]);
                }
                dataReader.Close();
                SqlCommand Deposito = new SqlCommand("UPDATE Datos Set Dinero= Dinero + '" + X + "' where id = '" + IDDestinatario + "'", cn);
                Deposito.ExecuteNonQuery();
                int cant;
                cant = command.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Deposito Exitoso. Tu nuevo saldo es:" + CDinero, "Sistema");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Sistema");
                }
                //Comando para actualizar los movimientos para la pestaña de movimientos recientes
                SqlCommand com = new SqlCommand("Insert into Movimientos (id_Usuario, id_Movimiento, Cantidad) values ('" + Login.ID + "', 1, '" + X + "');", cn);
                com.ExecuteNonQuery();



            }

            cn.Close();
            CDinero = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Depositar_Dinero();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
