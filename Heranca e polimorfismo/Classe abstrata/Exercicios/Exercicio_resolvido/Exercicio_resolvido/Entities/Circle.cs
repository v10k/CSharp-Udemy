using System;
using Exercicio_resolvido.Entities.Enums;

namespace Exercicio_resolvido.Entities {
    class Circle : Shape {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base (color) {
            Radius = radius;
        }

        public override double Area() {
            return Math.PI * Radius * Radius;
        }
    }
}
