namespace Week4.OOP
{
    public class House
    {
        public House()
        {
            nrOfDoors = 0;
            nrOfWindows = 0;
        }

        public House(int nrOfDoors, int nrOfWindows, string name)
        {
            this.nrOfDoors = nrOfDoors;
            this.nrOfWindows = nrOfWindows;
            this.name = name;
        }

        public int nrOfDoors;
        public int nrOfWindows;
        public string name;
        public double length;
        public double width;
        public double height;

        public int GetNumberOfDoorsMinusOne()
        {
            return nrOfDoors - 1;
        }

        public void CloseAllWindows()
        {
            Console.WriteLine("All windows closed.");
        }

        public double GetSurfaceArea()
        {
            double surface = length * width * height;

            return surface;
        }

        ~House()
        {
            System.Diagnostics.Trace.WriteLine("Destructor");
        }
    }
}
