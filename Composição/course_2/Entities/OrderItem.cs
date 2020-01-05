namespace course_2.Entities {
    class OrderItem {
        
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }


        public OrderItem() {

        }

        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal(int quantity, double price) {
            return quantity * price;
        }

        public override string ToString() {
            return $"{Product.Name}, ${Price}, Quantity: {Quantity}, SubTotal: {SubTotal(Quantity, Price)}";
        }
    }
}
