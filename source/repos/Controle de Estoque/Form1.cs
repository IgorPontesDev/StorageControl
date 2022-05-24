using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BJ13LQ8\MSSQLSERVER01;Initial Catalog = estoque;User ID=sa;Password=320474";
        public int selectedRowIndex;
        public bool adm = false;
        public bool maximized = false;
        public Form1(bool isAdm)
        {
            InitializeComponent();
            adm = isAdm;
            if (!adm) {
                btnUser.Enabled = false;
            }
            this.Size = new System.Drawing.Size(915, 500);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnUser.Location = new Point(166, 0);
            mostraPanelUsuario();
            escondePanelProdutos();
            hideHome();
            escondePanelClientes();
            SqlConnection conn = new SqlConnection(connectionString);
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                //Verifica se já existe user
                var slqQueryVerifica = "select * from usuarios";
                command.CommandText = slqQueryVerifica;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                //usar loop e percorrer o data table adicionando na view
                adapter.Fill(dt);
                dgvUser.DataSource = dt;
                dgvUser.Columns[0].Width = 100;
                dgvUser.Columns[1].Width = 205;
                dgvUser.Columns[2].Width = 200;
                dgvUser.Columns[3].Width = 150;
                dgvUser.Columns[4].Width = 50;
                conn.Close();
            }
        }
        public void mostraPanelUsuario()
        {
            pnUser.Visible = true;
        }
        public void escondePanelUsuario()
        {
            pnUser.Visible = false;

        }
        public void mostraPanelProdutos()
        {
            btnEditProdConfirm.Visible = true;
        }
        public void escondePanelProdutos()
        {
            btnEditProdConfirm.Visible = false;

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            
            btnEditProdConfirm.Location = new Point(166, 00);

            mostraPanelProdutos();
            escondePanelUsuario();
            hideHome();
            escondePanelClientes();
            SqlConnection conn = new SqlConnection(connectionString);
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                //Verifica se já existe user
                var slqQueryVerifica = "select * from produtos";
                command.CommandText = slqQueryVerifica;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                //usar loop e percorrer o data table adicionando na view
                adapter.Fill(dt);
                dgvProduct.DataSource = dt;
                dgvProduct.Columns[0].Width = 100;
                dgvProduct.Columns[1].Width = 255;
                dgvProduct.Columns[2].Width = 150;
                dgvProduct.Columns[3].Width = 100;
                conn.Close();
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            pnClientes.Location = new Point(166, 0);           
            escondePanelUsuario();
            escondePanelProdutos();
            hideHome();
            mostraPanelClientes();
            SqlConnection conn = new SqlConnection(connectionString);
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                //Verifica se já existe user
                var slqQueryVerifica = "select * from clientes";
                command.CommandText = slqQueryVerifica;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                //usar loop e percorrer o data table adicionando na view
                adapter.Fill(dt);
                dgvClientes.DataSource = dt;
                dgvClientes.Columns[0].Width = 30;
                dgvClientes.Columns[1].Width = 100;
                dgvClientes.Columns[2].Width = 150;
                dgvClientes.Columns[3].Width = 250;
                dgvClientes.Columns[4].Width = 80;
                conn.Close();
            }
        }

        public void escondePanelClientes()
        {
            pnClientes.Visible = false;
        }
        public void mostraPanelClientes()
        {
            pnClientes.Visible = true;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnCad.Location = new Point(150, 100);
            pnCad.Visible = true;
        }

        private void pnCad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadCadastrar_Click(object sender, EventArgs e)
        {
            Criptografia cript = new Criptografia();
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
                    atualizarGridUser();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnCadVoltar_Click(object sender, EventArgs e)
        {
            pnCad.Visible = false;
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
        public bool validaEdit()
        {
            if ((txtEditUser.Text == "" || txtEditEmail.Text == "" || txtEditNovaSenha.Text == "" || txtEditConfirmarNovaSenha.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!");
                return true;
            }
            return false;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            atualizarGridUser();
        }
        public void atualizarGridUser()
        {
            cbUser.Text = "";
            txtUserSearch.Text = "";
            SqlConnection conn = new SqlConnection(connectionString);
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                //Verifica se já existe user
                var slqQueryVerifica = "select * from usuarios";
                command.CommandText = slqQueryVerifica;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                //usar loop e percorrer o data table adicionando na view
                adapter.Fill(dt);
                dgvUser.DataSource = dt;

                conn.Close();
            }
        }
        public void atualizarGridProd()
        {
            cbListProducts.Text = "";
            txtProdFilter.Text = "";
            SqlConnection conn = new SqlConnection(connectionString);
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                //Verifica se já existe user
                var slqQueryVerifica = "select * from produtos";
                command.CommandText = slqQueryVerifica;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                //usar loop e percorrer o data table adicionando na view
                adapter.Fill(dt);
                dgvProduct.DataSource = dt;
                conn.Close();
            }
        }
        private void btnExcluirUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUser.Rows[selectedRowIndex].Cells["id"].FormattedValue.ToString());
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand query = new SqlCommand("DELETE FROM USUARIOS WHERE ID = '" + id + "'", con);
                query.ExecuteNonQuery();
                MessageBox.Show("Usuário deletado!");
                con.Close();
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }



        private void btnEditVoltar_Click(object sender, EventArgs e)
        {
            pnEditUser.Visible = false;
        }

        private void btnEditUsuario_Click(object sender, EventArgs e)
        {
            pnEditUser.Location = new Point(140, 80);
            pnEditUser.Visible = true;
            string usuario = dgvUser.Rows[selectedRowIndex].Cells["usuario"].FormattedValue.ToString();
            string email = dgvUser.Rows[selectedRowIndex].Cells["email"].FormattedValue.ToString();
            txtEditUser.Text = usuario;
            txtEditEmail.Text = email;
        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            DataTable dt = new DataTable();
            var sqlQuery = "";
            conn.Open();
            command.Connection = conn;
            switch (cbUser.Text)
            {
                case "":
                    MessageBox.Show("Selecione um filtro para a pesquisa");
                    return;
                case "Usuário":
                    sqlQuery = "select * from usuarios where usuario like '%" + txtUserSearch.Text + "%'";                                           
                    break;
                case "E-mail":
                    sqlQuery = "select * from usuarios where email like '%" + txtUserSearch.Text + "%'";              
                    break;
            }
            command.CommandText = sqlQuery;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgvUser.DataSource = dt;
            conn.Close();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (txtEditNovaSenha.Text.Length < 6)
            {
                MessageBox.Show("Nova senha muito curta!");
                return;
            }
            if (txtEditNovaSenha.Text != txtEditConfirmarNovaSenha.Text)
            {
                MessageBox.Show("Senhas não conferem");
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);
            Criptografia cript = new Criptografia();
            int id = Convert.ToInt32(dgvUser.Rows[selectedRowIndex].Cells["id"].FormattedValue.ToString());
            conn.Open();
            SqlCommand query = new SqlCommand("update usuarios set senha = '" + cript.Base64Encode(txtEditNovaSenha.Text) + "' where id = '" + id + "'", conn);
            query.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Senha alterada com sucesso!");
            atualizarGridUser();
        }

        public void hideHome()
        {           
            pnHomeMid.Visible = false;
        }
        public void showHome()
        {
            pnHomeMid.Visible = true;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (maximized)
            {
                this.Size = new System.Drawing.Size(915, 500);
                maximized = false;
            }
            else
            {
                this.Size = new System.Drawing.Size(1200, 900);
                maximized = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            showHome();
            escondePanelUsuario();
            escondePanelProdutos();
        }

        private void btnProdAdd_Click(object sender, EventArgs e)
        {
            pnAddProd.Location = new Point(140, 80);
            pnAddProd.Visible = true;               
            
        }

        private void btnProdAddReturn_Click(object sender, EventArgs e)
        {
            pnAddProd.Visible = false;
        }

        private void btnProdAddConfirm_Click(object sender, EventArgs e)
        {
            /*insere produto*/
            SqlConnection conn = new SqlConnection(connectionString);
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;               
                var slqQuery = "insert into produtos (descricao, categoria, valor, quantidade) values ('" + txtProdAddDesc.Text + "', '" + txtProdAddCat.Text + "', 'R$ " + txtProdAddPrice.Text + "', '" + txtProdAddQtd.Text + "')";
                command.CommandText = slqQuery;
                command.ExecuteNonQuery();
                conn.Close();
                limpaProdutos();
                MessageBox.Show("Produto cadastrado com sucesso");

            }
        }
        private void limpaProdutos()
        {
            txtProdAddPrice.Text = "";
            txtProdAddQtd.Text = "";
            txtProdAddDesc.Text = "";
            txtProdAddCat.Text = "";
        }

        private void btnProdDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProduct.Rows[selectedRowIndex].Cells["id"].FormattedValue.ToString());
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand query = new SqlCommand("DELETE FROM PRODUTOS WHERE ID = '" + id + "'", con);
                query.ExecuteNonQuery();
                MessageBox.Show("Produto deletado!");
                con.Close();
            }
        }


        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }

        private void btnEditProdReturn_Click(object sender, EventArgs e)
        {
            pnEditProd.Visible = false;
        }

        private void btnProdEdit_Click(object sender, EventArgs e)
        {
            pnEditProd.Location = new Point(140, 80);
            pnEditProd.Visible=true;
            string descricao = dgvProduct.Rows[selectedRowIndex].Cells["descricao"].FormattedValue.ToString();
            string categoria = dgvProduct.Rows[selectedRowIndex].Cells["categoria"].FormattedValue.ToString();
            string valor = dgvProduct.Rows[selectedRowIndex].Cells["valor"].FormattedValue.ToString();
            string quantidade = dgvProduct.Rows[selectedRowIndex].Cells["quantidade"].FormattedValue.ToString();
            txtEditProdDesc.Text = descricao;
            txtEditProdCat.Text = categoria;
            txtEditProdPrice.Text = valor;
            txtEditProdQtd.Text = quantidade;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProdSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            DataTable dt = new DataTable();            
            var slqQuery = "";
            conn.Open();
            command.Connection = conn;
            switch (cbListProducts.Text)
            {
                case "":
                    MessageBox.Show("Selecione um filtro para a pesquisa");
                    return;
                case "Descrição":                  
                    slqQuery = "select * from produtos where descricao like '%" + txtProdFilter.Text + "%'";             
                    break;
                case "Categoria":
                    slqQuery = "select * from produtos where categoria like '%" + txtProdFilter.Text + "%'";
                    break;
                case "Valor":
                    slqQuery = "select * from produtos where valor like '%" + txtProdFilter.Text + "%'";
                    break;
                case "Quantidade":
                    slqQuery = "select * from produtos where quantidade like '%" + txtProdFilter.Text + "%'";                                   
                    break;
            }
            command.CommandText = slqQuery;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgvProduct.DataSource = dt;
            conn.Close();

        }

        private void btnProdEditConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            int id = Convert.ToInt32(dgvProduct.Rows[selectedRowIndex].Cells["id"].FormattedValue.ToString());
            conn.Open();
            if(txtEditProdCat.Text == "" || txtEditProdDesc.Text == "" || txtEditProdPrice.Text == "" || txtEditProdQtd.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            SqlCommand query = new SqlCommand("update produtos set descricao = '" + txtEditProdDesc.Text + "', categoria = '" + txtEditProdCat.Text + "', valor = 'R$ " + txtEditProdPrice.Text + "', quantidade = '" + txtEditProdQtd.Text + "' where id = '" + id + "'", conn);
            query.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Produto alterado com sucesso!");
            pnEditProd.Visible = false;
        }

        private void btnProdRefresh_Click(object sender, EventArgs e)
        {
            atualizarGridProd();
        }

        private void btnProdExport_Click(object sender, EventArgs e)
        {
            //populando dataset
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string queryString = "SELECT * from produtos";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, conn);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "Produtos");
            conn.Close();
            try
                {
                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = "produtos.xls";
                    savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                    if (dset.Tables[0].Rows.Count > 0)
                    {
                        if (savefile.ShowDialog() == DialogResult.OK)
                        {
                            //using (StreamWriter sw = new StreamWriter(savefile.FileName))
                            //    sw.WriteLine("Hello World!");
                            StreamWriter wr = new StreamWriter(savefile.FileName);
                            for (int i = 0; i < dset.Tables[0].Columns.Count; i++)
                            {
                                wr.Write(dset.Tables[0].Columns[i].ToString().ToUpper() + "\t");
                            }

                            wr.WriteLine();

                            //write rows to excel file
                            for (int i = 0; i < (dset.Tables[0].Rows.Count); i++)
                            {
                                for (int j = 0; j < dset.Tables[0].Columns.Count; j++)
                                {
                                    if (dset.Tables[0].Rows[i][j] != null)
                                    {
                                        wr.Write(Convert.ToString(dset.Tables[0].Rows[i][j]) + "\t");
                                    }
                                    else
                                    {
                                        wr.Write("\t");
                                    }
                                }
                                //go to next line
                                wr.WriteLine();
                            }
                            //close file
                            wr.Close();
                            MessageBox.Show(this, "Arquivo salvo em: " + savefile.FileName, "Salvo com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else
                    {
                    MessageBox.Show(this, "Não tem dados a serem exportados, por favor adicione produtos", "Não foi possível exportar o arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                MessageBox.Show("Erro ao exportar!"+ ex.ToString());
                }
                finally
                {

                }
            
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            pnAddCliente.Location = new Point(150, 100);
            pnAddCliente.Visible = true;
        }

        private void btnClienteReturn_Click(object sender, EventArgs e)
        {
            pnAddCliente.Visible = false;
        }

        private void btnConfirmAddCliente_Click(object sender, EventArgs e)
        {

            try
            {
                if(txtNomeCliente.Text == "" || txtCEPCliente.Text == "" || txtCPFCliente.Text == "" || txtTelCliente.Text == "" || txtEnderecoCliente.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }
                /*cadastra*/
                SqlConnection conn = new SqlConnection(connectionString);
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    var slqQuery = "insert into clientes (nome, cpf, telefone, endereco, cep) values ('" + txtNomeCliente.Text + "', '" + txtCPFCliente.Text + "', '" + txtTelCliente.Text + "', '" + txtEnderecoCliente.Text + "', '" + txtCEPCliente.Text + "')";

                    command.CommandText = slqQuery;
                    command.ExecuteNonQuery();
                    conn.Close();
                    limpaCadastro();
                    MessageBox.Show("Cliente cadastrado com sucesso");
                    txtNomeCliente.Text = "";
                    txtCEPCliente.Text = "";
                    txtCPFCliente.Text = "";
                    txtTelCliente.Text = "";
                    txtEnderecoCliente.Text = "";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar, contate o administrador do sistema!");
            }
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvClientes.Rows[selectedRowIndex].Cells["id"].FormattedValue.ToString());
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand query = new SqlCommand("DELETE FROM clientes WHERE ID = '" + id + "'", con);
                query.ExecuteNonQuery();
                MessageBox.Show("Cliente deletado!");
                con.Close();
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }

        private void btnEditClienteReturn_Click(object sender, EventArgs e)
        {
            pnClientEdit.Visible = false;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            pnClientEdit.Location = new Point(150, 100);
            pnClientEdit.Visible = true;
            string nome = dgvClientes.Rows[selectedRowIndex].Cells["nome"].FormattedValue.ToString();
            string cpf = dgvClientes.Rows[selectedRowIndex].Cells["cpf"].FormattedValue.ToString();
            string tel = dgvClientes.Rows[selectedRowIndex].Cells["telefone"].FormattedValue.ToString();
            string endereco = dgvClientes.Rows[selectedRowIndex].Cells["endereco"].FormattedValue.ToString();
            string cep = dgvClientes.Rows[selectedRowIndex].Cells["cep"].FormattedValue.ToString();

            txtEditClienteNome.Text = nome;
            txtEditClienteCPF.Text = cpf;
            txtEditClienteTEL.Text = tel;
            txtEditClienteEndereco.Text = endereco;
            txtEditClienteCEP.Text = cep;
        }

        private void btnConfirmEditClient_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            int id = Convert.ToInt32(dgvClientes.Rows[selectedRowIndex].Cells["id"].FormattedValue.ToString());
            conn.Open();
            if (txtEditClienteTEL.Text == "" || txtEditClienteNome.Text == "" || txtEditClienteEndereco.Text == "" || txtEditClienteCPF.Text == "" || txtEditClienteCEP.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            SqlCommand query = new SqlCommand("update clientes set nome = '" + txtEditClienteNome.Text + "', cpf = '" + txtEditClienteCPF.Text + "', telefone = '" + txtEditClienteTEL.Text + "', endereco = '" + txtEditClienteEndereco.Text + "', cep = '" + txtEditClienteCEP.Text + "' where id = '" + id + "'", conn);
            query.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Dados do cliente alterados com sucesso!");
            pnEditProd.Visible = false;
            txtEditClienteTEL.Text = "";
            txtEditClienteNome.Text = "";
            txtEditClienteEndereco.Text = "";
            txtEditClienteCPF.Text = "";
            txtEditClienteCEP.Text = "";
        }

        private void btnClienteSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            DataTable dt = new DataTable();
            var sqlQuery = "";
            conn.Open();
            command.Connection = conn;
            switch (cbClientes.Text)
            {
                case "":
                    MessageBox.Show("Selecione um filtro para a pesquisa");
                    return;
                case "Nome":
                    sqlQuery = "select * from clientes where nome like '%" + txtClienteSearch.Text + "%'";
                    break;
                case "CPF":
                    sqlQuery = "select * from clientes where cpf like '%" + txtClienteSearch.Text + "%'";
                    break;
                case "Telefone":
                    sqlQuery = "select * from clientes where telefone like '%" + txtClienteSearch.Text + "%'";
                    break;
                case "Endereço":
                    sqlQuery = "select * from clientes where endereco like '%" + txtClienteSearch.Text + "%'";
                    break;
                case "CEP":
                    sqlQuery = "select * from clientes where cep like '%" + txtClienteSearch.Text + "%'";
                    break;
            }
            command.CommandText = sqlQuery;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgvClientes.DataSource = dt;
            conn.Close();
        }

        private void btnRefreshClientes_Click(object sender, EventArgs e)
        {
            cbClientes.Text = "";
            txtClienteSearch.Text = "";
            SqlConnection conn = new SqlConnection(connectionString);
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                var slqQueryVerifica = "select * from clientes";
                command.CommandText = slqQueryVerifica;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                //usar loop e percorrer o data table adicionando na view
                adapter.Fill(dt);
                dgvClientes.DataSource = dt;
                conn.Close();
            }
        }
    }
}
