using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Controle_de_Estoque
{
    public partial class loguin : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BJ13LQ8\MSSQLSERVER01;Initial Catalog = estoque;User ID=sa;Password=320474";
        Criptografia cript = new Criptografia();
        public loguin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
   

        public void limpaCadastro()
        {
            txtCadPass.Text = "";
            txtCadEmail.Text = "";
            txtCadConfirmPass.Text = "";
            txtCadUser.Text = "";
        }
        public bool validaCadastro()
        {
            if ((txtCadConfirmPass.Text == "" || txtCadEmail.Text == "" || txtCadPass.Text == "" || txtCadUser.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!");
                return true;
            }
            if (txtCadUser.Text.ToString().Length < 4)
            {
                MessageBox.Show("Nome de usuário muito curto!");
                return true;
            }
            if (!txtCadEmail.Text.ToString().Contains('@'))
            {
                MessageBox.Show("Digite um e-mail válido!");
                return true;
            }
            if (txtCadPass.Text.ToString().Length < 6)
            {
                MessageBox.Show("Senha muito curta!");
                return true;
            }
            if (txtCadPass.Text.ToString() != txtCadConfirmPass.Text.ToString())
            {
                MessageBox.Show("Senhas não conferem!");
                return true;
            }
            return false;
        }

        private void btnCadVoltar_Click(object sender, EventArgs e)
        {
            pnLoguin.Visible = true;
            pnCad.Visible = false;
        }

        private void btnCad_Click_1(object sender, EventArgs e)
        {
            pnLoguin.Visible = false;
            pnCad.Location = new Point(200, 37);
            pnCad.Visible = true;
        }

        private void btnLoguin_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((txtLoguin.Text == "") || (txtPass.Text == ""))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }

                SqlConnection conn = new SqlConnection(connectionString);
                {
                    conn.Open();
                    var senhaDescriptografada = cript.Base64Encode(txtPass.Text);
                    var slqQuery = "SELECT * FROM USUARIOS WHERE usuario= '" + txtLoguin.Text + "' and senha='" + senhaDescriptografada + "'";

                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = slqQuery;
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        bool isAdm = false;
                        if (dt.Rows[0][4].ToString() == "1")
                        {
                            isAdm = true;
                        }
                            Form1 novoform = new Form1(isAdm);                        
                            novoform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Credenciais inválidas");
                    }
                    conn.Close();
                }
            }
            catch (Exception erro)
            {

            }
        }

        private void btnCadCadastrar_Click_1(object sender, EventArgs e)
        {

            if (validaCadastro() == true)
                return;

            try
            {

                /*cadastra*/
                SqlConnection conn = new SqlConnection(connectionString);
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    //Verifica se já existe user
                    var slqQueryVerifica = "select * from usuarios where usuario = '" + txtCadUser.Text + "'";
                    command.CommandText = slqQueryVerifica;
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Usuário já existente!");
                        return;
                    }

                    var senhaCriptografada = cript.Base64Encode(txtCadPass.Text);
                    var slqQuery = "insert into usuarios (usuario, email, senha) values ('" + txtCadUser.Text + "', '" + txtCadEmail.Text + "', '" + senhaCriptografada + "')";

                    command.CommandText = slqQuery;
                    command.ExecuteNonQuery();
                    conn.Close();
                    limpaCadastro();
                    MessageBox.Show("Usuário cadastrado com sucesso");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar, contate o administrador do sistema!");
            }
        }
    }
}
