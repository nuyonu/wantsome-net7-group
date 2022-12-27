namespace OOP.Intro.Homework.Solution.ExerciseTwo
{
    public class Product
    {
        // Fields
        private string name;
        private double price;
        private int quantity;

        // Constructor
        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        // Getters and setters for the fields
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }
    }
}
