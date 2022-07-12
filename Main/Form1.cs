using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (verificar() == true) 
            { 
                DialogResult OP = MessageBox.Show("Tem a certeza que deseja limpar?", "Aviso", MessageBoxButtons.YesNo);
                if (OP == DialogResult.Yes)
                {
                    Limpar();
                }
            }
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
                if (verificar()==true)
                {
                    if (idcheck() == true)
                    { 
                        try
                        {
                            int i = Convert.ToInt32(materialTextBox21.Text);
                            if (i >= 0)
                            {
                                try
                                {
                                    int u = Convert.ToInt32(materialTextBox23.Text);
                                    if (u >= 0)
                                    {
                                            string msg = "O/A " + materialTextBox24.Text + " de ID N°" + materialTextBox21.Text + " da marca " + materialTextBox22.Text + " foi adicionado ao sistema com o valor de " + materialTextBox23.Text + "€";
                                            MessageBox.Show(msg);
                                            Enviar();
                                            ins();
                                            Limpar();
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Preço Invalido.");
                                }
                            }
                            else 
                            {
                                MessageBox.Show("O ID necessita de ser um número inteiro.");
                            }
                        }
                        catch 
                        {
                            MessageBox.Show("O ID necessita de ser um número inteiro.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID já utilizado.");
                    }
                }
        }

        private void Limpar()
        {
            materialTextBox21.Text = "";
            materialTextBox22.Text = "";
            materialTextBox23.Text = "";
            materialTextBox24.Text = "";
        }

        private bool verificar()
        {
            if (materialTextBox21.Text.Trim() != "" || materialTextBox22.Text.Trim() != "" || materialTextBox23.Text.Trim() != "" || materialTextBox24.Text.Trim() != "")
            {
                if (materialTextBox22.Text.Trim() != "" && materialTextBox23.Text.Trim() != "") {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void Enviar()
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[Produtos] ([ID],[NOME],[MARCA],[PRECO]) VALUES ('" + materialTextBox21.Text + "', '" + materialTextBox24.Text + "', '" + materialTextBox22.Text + "', '" + materialTextBox23.Text + "€')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void ins()
        {
            adpt = new SqlDataAdapter("select * from Produtos", con);
            dt = new DataTable();
            adpt.Fill(dt);
            produtosDataGridView.DataSource = dt;
        }

        private void materialTabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            ins();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'produtosDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.produtosDataSet.Produtos);
            ins();
        }
        private bool idcheck()
        {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select ID from Produtos where ID='"+materialTextBox21.Text +"'", con);
                string CHK = (string)cmd.ExecuteScalar();
                
                if (CHK == materialTextBox21.Text)
                {
                    con.Close();
                    return false;
                }
                else 
                {
                con.Close();
                return true;
                }
        }

        private void produtosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                DataGridViewRow row = this.produtosDataGridView.Rows[e.RowIndex];
                string id = row.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                string nome = row.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                string marca = row.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                string preco = row.Cells["dataGridViewTextBoxColumn4"].Value.ToString();

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Produtos WHERE Id='" + id + "'", con);
                SqlCommand cmd2 = new SqlCommand(@"INSERT INTO[dbo].[Produtos] ([ID],[NOME],[MARCA],[PRECO]) VALUES ('" + id + "', '" + nome + "', '" + marca + "', '" + preco + "')", con);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Dados Atualizados.");

            }
            else if(e.ColumnIndex == 4)
            {
                DialogResult op = MessageBox.Show("Deseja mesmo eliminar a coluna?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (op == DialogResult.Yes) 
                { 
                int d = e.RowIndex;
                DataGridViewRow row = this.produtosDataGridView.Rows[e.RowIndex];
                string id = row.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                produtosDataGridView.Rows.RemoveAt(d);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Produtos WHERE Id='" + id + "'",con);
                cmd.ExecuteNonQuery();
                con.Close();
                }
            }
            else if(e.ColumnIndex== 0)
            {
                MessageBox.Show("Não é possivel alterar o ID");
            }
            
        }
    }
   
}