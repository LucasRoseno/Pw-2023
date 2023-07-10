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
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace CSharpCampoBLOB
{
    public partial class Form1 : Form
    {
        ClasseConexao con;
        DataSet ds;
        private string caminhoImagem = null;
        int pos = 0; // para navegar entre os registros
        int posMAX = 0; //armazena o total de registros do DB

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofl = new OpenFileDialog();
            ofl.Title = "Adicionar Imagem";
            ofl.Filter = "All files (*.*)|*.*";
            if (ofl.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofl.OpenFile());
                    caminhoImagem = ofl.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao carregar a imagem");
                }
            }
            ofl.Dispose();
        }

        public static byte[] ImgToByte(string camImg) //converte a imagem em []bytes
        {
            FileStream fs = new FileStream(camImg, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imgByte = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            return imgByte;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdicionarImagem.Visible = false;
            btnSalvar.Visible = false;
            atualizar_dados();
        }

        private void atualizar_dados()
        {
            this.Cursor = Cursors.WaitCursor;
            pos = 0;
            con = new ClasseConexao();
            ds = new DataSet();
            ds = con.executa_sql("select * from contatosIMG");
            posMAX = ds.Tables[0].Rows.Count - 1;
            if (posMAX > 0)
            {
                txtNome.Text = ds.Tables[0].Rows[0]["nome"] + "";
                txtFone.Text = ds.Tables[0].Rows[0]["fone"] + "";
                Byte[] byteIMG = (Byte[])(ds.Tables[0].Rows[0]["img"]);
                pictureBox1.Image = Image.FromStream(new MemoryStream(byteIMG));
            }
            this.Cursor = Cursors.Default;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnAdicionarImagem.Visible = true;
            btnSalvar.Visible = true;
            txtNome.Text = "";
            txtFone.Text = "";
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
                pictureBox1.Refresh();
            }
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            String nome = txtNome.Text;
            String fone = txtFone.Text;
            byte[] imagem = ImgToByte(caminhoImagem);
            SqlCommand cmd = new SqlCommand("INSERT INTO contatosIMG(nome,fone,img) VALUES(@nome,@fone,@img)");
            cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 50).Value = nome;
            cmd.Parameters.Add("@fone", SqlDbType.NVarChar, 50).Value = fone;
            cmd.Parameters.Add("@img", SqlDbType.VarBinary, imagem.Length).Value = imagem;
            int x = con.executa_IncAltExcParametros(cmd); //retorna o número de linhas afetadas no DB
            if(x > 0)
            {
                btnAdicionarImagem.Visible = false;
                btnSalvar.Visible = false;
                atualizar_dados();
                MessageBox.Show("Registro Salvo");
            }
            else
            {
                MessageBox.Show("Falha ao inserir registro");
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtNome.Text = ds.Tables[0].Rows[0]["nome"] + "";
                txtFone.Text = ds.Tables[0].Rows[0]["fone"] + "";
                Byte[] byteIMG = (Byte[])(ds.Tables[0].Rows[0]["img"]);
                pictureBox1.Image = Image.FromStream(new MemoryStream(byteIMG));
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos < 0)
            pos = 0;
            txtNome.Text = ds.Tables[0].Rows[pos]["nome"] + "";
            txtFone.Text = ds.Tables[0].Rows[pos]["fone"] + "";
            Byte[] byteIMG = (Byte[])(ds.Tables[0].Rows[pos]["img"]);
            pictureBox1.Image = Image.FromStream(new MemoryStream(byteIMG));
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            pos++;
            if(pos > posMAX)
            pos = posMAX;
            txtNome.Text = ds.Tables[0].Rows[pos]["nome"] + "";
            txtFone.Text = ds.Tables[0].Rows[pos]["fone"] + "";
            Byte[] byteIMG = (Byte[])(ds.Tables[0].Rows[pos]["img"]);
            pictureBox1.Image = Image.FromStream(new MemoryStream(byteIMG));
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (posMAX > 0)
            {
                txtNome.Text = ds.Tables[0].Rows[posMAX]["nome"] + "";
                txtFone.Text = ds.Tables[0].Rows[posMAX]["fone"] + "";
                Byte[] byteIMG = (Byte[])(ds.Tables[0].Rows[posMAX]["img"]);
                pictureBox1.Image = Image.FromStream(new MemoryStream(byteIMG));
            }
        }
    }
}
