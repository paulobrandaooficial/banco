namespace Dados
{
    public class ContaPessoaJuridica : Conta
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

        public override double Sacar(double Valor){
            this.Saldo -= Valor + 0.10;
            return this.Saldo; 
        }

        public override double Depositar(double Valor){
            this.Saldo += Valor + Saldo;
            return this.Saldo;            
        }

    }
}