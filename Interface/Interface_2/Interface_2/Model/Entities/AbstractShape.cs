using Interface_2.Model.Enums;

namespace Interface_2.Model.Entities {
    abstract class AbstractShape : IShape {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
