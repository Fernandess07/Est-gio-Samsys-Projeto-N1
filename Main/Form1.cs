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
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber600, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Amber700, TextShade.WHITE);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            SqlConnection con = new SqlConnection(@"Data Source=PTFERNANDES\SQLEXPRESS;Initial Catalog=Produtos;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[Produtos] ([ID],[NOME],[MARCA],[PRECO]) VALUES ('" + materialTextBox21.Text + "', '" + materialTextBox24.Text + "', '" + materialTextBox23.Text + "', '" + materialTextBox22.Text + "€')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
