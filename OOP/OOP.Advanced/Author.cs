namespace OOP.Advanced
{
    public class Author
    {
        // Name - Custom, Email, Country
        private string name;

        public Author()
        { }

        public Author(string name)
        {
            this.name = name;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                this.name = value; 
            }
        }

        private string email;

        public string Email { get { return email; } 
            set 
            {
                if (value.Contains("@") && value.Contains("."))
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("Email is not valid.");
                }
            } 
        }

        public string Country { get; set; }

        public void SetName(string name)
        {
            if (name.Length < 10)
            {
                Console.WriteLine("Error");
            }

            if (name.Length > 30)
            {
                Console.WriteLine("Error");
            }

            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
