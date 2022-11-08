using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// importando o driver de conexão
using MySql.Data.MySqlClient;

namespace PortariaApp
{
    public partial class frmTestarConexao : Form
    {
        public frmTestarConexao()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //instanciando a classe de conexão do mysql

            MySqlConnection conn = new MySqlConnection();
            
            //criando a string de conexão
            conn.ConnectionString = "Server=localhost;Port=3306;Database=dbPortaria;Uid=root;Pwd=''";

            //abrindo o banco de dados
            try { 
            conn.Open();
            lblMsm.Text = "Banco de dados conectado";
            }
            catch (MySqlException)
            {
                lblMsm.Text= "Erro ao Conectar";
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            //criando a string de conexão
            conn.ConnectionString = "Server=localhost;Port=3306;Database=dbPortaria;Uid=root;Pwd=''";
            try
            {
                //abrindo o banco de dados
                conn.Close();

                lblMsm.Text = "Banco de dados desconectado";
            }
            catch (MySqlException)
            {
                lblMsm.Text = "Erro ao Conectar";
            }
        }
    }
}
