namespace Exercicio_proposto.Entities {
    class PessoaJuridica : Pessoa {
        public int NFuncionario{ get; set; }

        public PessoaJuridica() {

        }

        public PessoaJuridica(string nome, double rendaAnual, int nFuncionario) : base(nome, rendaAnual) {
            NFuncionario = nFuncionario;
        }

        public override double CalculaImposto() {
            if (NFuncionario <= 10) {
                return RendaAnual * 0.16;
            }
            return RendaAnual * 0.14;
        }
    }
}
