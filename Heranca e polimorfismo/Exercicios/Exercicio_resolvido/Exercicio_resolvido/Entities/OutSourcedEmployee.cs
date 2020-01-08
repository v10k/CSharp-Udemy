namespace Exercicio_resolvido.Entities {
    class OutSourcedEmployee : Employee {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee() {

        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalChage) : base(name, hours, valuePerHour) {
            AdditionalCharge = additionalChage;
        }

        public override double Payment() {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
