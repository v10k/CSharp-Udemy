
namespace Exercicio_proposto.Entities {
    class PessoaFisica : Pessoa {
        public double Gastos { get; set; }

        public PessoaFisica() {

        }

        public PessoaFisica(string nome, double rendaAnual, double gastos) : base(nome, rendaAnual) {
            Gastos = gastos;
        }

        public override double CalculaImposto() {
            if (RendaAnual < 20000.00) {
                return (RendaAnual * 0.15) - (Gastos * 0.5);
            }
            return (RendaAnual * 0.25) - (Gastos * 0.5);
        }
    }
}
