namespace Exercicio_proposto.Entities {
    abstract class Pessoa {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa() {

        }

        protected Pessoa(string nome, double rendaAnual) {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalculaImposto();
    }
}
