namespace OOP.Advanced
{
    public abstract class Vehicle
    {
        public string Color { get; set; }

        public string Name { get; set; }

        public int NumberOfWheels { get; set; }

        public abstract void Start();
    }

    public class AudiVehicle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Audi Start");
        }
    }

    public class FordVehicle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Ford Start");
        }
    }
}
