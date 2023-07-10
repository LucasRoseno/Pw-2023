using BoletoNet;
using System;
using BoletoNet;

namespace PrjMasterPage_Italo
{
    public partial class Boleto : System.Web.UI.Page
    {
       

        public string NumeroDocumento { get; private set; }
        public Sacado Sacado { get; private set; }
        public object Instrucoes { get; private set; }
        public EspecieDocumento_Itau EspecieDocumento { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public static implicit operator BoletoNet.Boleto(Boleto v)
        {
            throw new NotImplementedException();
        }

        protected void btnGerar_Click(object sender, EventArgs e)
        {
            string vencimento = txtVencimento.Text;
            //String valorBoleto = txtValor.Text;
            Decimal valBol = Convert.ToDecimal(txtValor.Text);
            String numeroDocumento = "B20005446";

            //cedente
            String cedente_codigo = "1111111";
            String cedente_nossoNumeroBoleto = "22222222";
            String cedente_cpfCnpj = "123.456.789-01";
            String cedente_nome = "MEU BANCO CHEGA E CHORA";
            String cedente_agencia = "1000";
            String cedente_conta = "22507";
            String cedente_digitoConta = "6";

            //sacado
            String sacado_cpfCnpj = "000.000.000-00";
            String sacado_nome = txtSacado.Text;
            String sacado_endereco = txtEndereco.Text;
            String sacado_bairro = txtBairro.Text;
            String sacado_cidade = txtCidade.Text;
            String sacado_cep = txtCEP.Text;
            String sacado_uf = txtUF.Text;

            Cedente cedente = new Cedente(cedente_cpfCnpj,
            cedente_nome,
            cedente_agencia,
            cedente_conta,
            cedente_digitoConta);
            cedente.Codigo = cedente_codigo;

            BoletoNet.Boleto boleto = new BoletoNet.Boleto(Convert.ToDateTime(vencimento), valBol, "109", cedente_nossoNumeroBoleto, cedente);
            boleto.NumeroDocumento = numeroDocumento;

            Sacado sacado = new Sacado(sacado_cpfCnpj, sacado_nome);
            boleto.Sacado = sacado;
            boleto.Sacado.Endereco.End = sacado_endereco;
            boleto.Sacado.Endereco.Bairro = sacado_bairro;
            boleto.Sacado.Endereco.Cidade = sacado_cidade;
            boleto.Sacado.Endereco.CEP = sacado_cep;
            boleto.Sacado.Endereco.UF = sacado_uf;

            Instrucao_Itau instrucao = new Instrucao_Itau();
            instrucao.Descricao = "Não Receber após o vencimento";

            boleto.Instrucoes.Add(instrucao);
                ;
            EspecieDocumento_Itau especie = new EspecieDocumento_Itau("99");
            boleto.EspecieDocumento = especie;

            BoletoBancario boleto_bancario = new BoletoBancario();
            boleto_bancario.CodigoBanco = 341;
            boleto_bancario.Boleto = boleto;
            boleto_bancario.MostrarCodigoCarteira = true;
            boleto_bancario.Boleto.Valida();

            boleto_bancario.MostrarComprovanteEntrega = true;

            pnl_dados.Visible = false;
            pnl_boleto.Controls.Add(boleto_bancario);

        }
    }
}