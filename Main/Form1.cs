using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : MaterialForm
    {
        
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection con = new SqlConnection(@"Data Source=PTFERNANDES\SQLEXPRESS;Initial Catalog=Produtos;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber600, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Amber700, TextShade.WHITE);
        }

        private void btnLimpar(object sender, EventArgs e)
        {
            if (verificartextBoxes() != true)
            {
                return;
            }
            DialogResult OP = MessageBox.Show("Tem a certeza que deseja limpar?", "Aviso", MessageBoxButtons.YesNo);
            if (OP == DialogResult.Yes)
            {
                Limpar();
            }
        }
        private void btnEnviar(object sender, EventArgs e)
        {
            if (verificartextBoxes() != true)
            {
                return;
            }
            if (VerificarPreco() != "")
            {
                MessageBox.Show(VerificarPreco());
                return;
            }
            if (EnviarDados() != "")
            {
                MessageBox.Show(EnviarDados());
                return;
            }
            if (MostrarDados() != "" )
            {
                MessageBox.Show(MostrarDados());
                return;
            }
            else
            {
                MessageBox.Show("O/A " + txtNome.Text.Trim() + " da marca " + txtMarca.Text.Trim() + " foi adicionado ao sistema com o valor de " + txtPreco.Text.Trim() + "€");
                Limpar();
            }
        }

        private void Limpar()
        {
            txtMarca.Text = "";
            txtPreco.Text = "";
            txtNome.Text = "";
        }

        private bool verificartextBoxes()
        {
            if (txtMarca.Text.Trim() == "" && txtPreco.Text.Trim() == "" && txtNome.Text.Trim() == "")
            {
                return false;
            }

            if (txtMarca.Text.Trim() == "" || txtPreco.Text.Trim() == "")
            {
                return false;
            }
       
            return true;
        

        }
        private string EnviarDados()
        {
            try { 
                SqlCommand cmd = new SqlCommand();
                con.Open();
                //Adicionar os Valores aos Campos
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Produtos (NOME,MARCA,PRECO)Values(@nome,@marca,@preco)";
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                cmd.Parameters.AddWithValue("@preco", txtPreco.Text + "€");
                cmd.ExecuteNonQuery();
                con.Close();
                return "";

            }
            catch
            {
                con.Close();
                return "Não foi possivel Enviar os Dados";
            }
        }
        private string MostrarDados()
        {
            try 
            { 
                adpt = new SqlDataAdapter("select * from Produtos", con);
                dt = new DataTable();
                adpt.Fill(dt);
                produtosDataGridView.DataSource = dt;
                return "";
            }
            catch
            {
                return "Não foi possivel Conectar à Base de Dados.";
            }
        }

        private void materialTabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            MostrarDados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDados();
        }


        private string VerificarPreco()
        {
            try
            {
                int i = Convert.ToInt32(txtPreco.Text);
                if (i < 0)
                {
                    return "Preço não pode ser negativo";
                }
                return "";
            }
            catch
            {
                return "Preço Invalido.";
            }
            
        }

        private void produtosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 5 && e.RowIndex > -1)
            {
                DataGridViewRow row = this.produtosDataGridView.Rows[e.RowIndex];
                string id = row.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                string nome = row.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                string marca = row.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                string preco = row.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                if(VerificarCelulas(nome,marca,preco)!= "")
                {
                    MessageBox.Show(VerificarCelulas(nome,marca,preco));
                    return;
                }
                if(Update(nome, marca, preco, id) != "")
                {
                    MessageBox.Show(Update(nome, marca, preco, id));
                    MostrarDados();
                    return;
                }
                
                
            }
            else if (e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                DataGridViewRow row = this.produtosDataGridView.Rows[e.RowIndex];
                DialogResult op = MessageBox.Show("Deseja mesmo eliminar a linha?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (op != DialogResult.Yes)
                {
                    return;
                }
                int d = e.RowIndex;
                string id = row.Cells["dataGridViewTextBoxColumn1"].Value.ToString();

                if(Eliminar(id) != "")
                {
                    MessageBox.Show(Eliminar(id));
                    return;
                }
                MostrarDados();

            }
            else if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                MessageBox.Show("Não é possivel alterar o ID.");

            }
        }

        private string Eliminar(string id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Produtos WHERE Id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                return "";
            }
            catch
            {
                return "Não foi possivel eliminar os dados.";
            }
        }

        private string Update(string nome, string marca, string preco, string id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE Produtos set Nome = @Nome ,Marca = @marca,Preco = @preco WHERE Id= @ID";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Marca", marca);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@ID",id);

                
                cmd.ExecuteNonQuery();
                con.Close();
                return "Dados Atualizados.";
            }
            catch
            {
                return "";
            }

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void produtosDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (produtosDataGridView.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBoxColumn4_KeyPress);
                }
            }
        }
        private void dataGridViewTextBoxColumn4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void produtosDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.produtosDataGridView.Rows[e.RowIndex];
            string preco = row.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
            if (preco.EndsWith("€") == false)
            {
                row.Cells["dataGridViewTextBoxColumn4"].Value = preco + "€";
            }
        }
        private string VerificarCelulas(string nome, string marca, string preco)
        {
            if (nome.Trim() == "")
            {
                return "Introduza o Nome do Produto";
            }
            if (marca.Trim() == "")
            {
                return "Introduza o marca do Produto";
            }
            if (preco.Remove(preco.Length - 1) == "")
            {
                return "Introduza o marca do Produto";
            }
            return "";
        }
    }
}