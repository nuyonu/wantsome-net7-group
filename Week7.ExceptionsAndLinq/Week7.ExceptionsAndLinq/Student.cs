namespace Week7.ExceptionsAndLinq
{
    public class Student
    {
        private string name;
        private string email;

        public int Id { get; set; }

        public string Name 
        { 
            get
            {
                return name; 
            }
            set
            {
                if (value.Length < 4)
                {
                    throw new NameException("Name can't have length lower than 4.");
                }

                if (value.Length > 10)
                {
                    throw new NameException("Name can't have length greater than 10.");
                }

                name = value;
            } 
        }

        public string Email 
        {
            get { return email; }
            set
            {
                if (value.Length < 5)
                {
                    throw new EmailException("Invalid email.");
                }

                if (!value.Contains("@") || !value.Contains(".")) 
                {
                    throw new EmailException("Invalid email.");
                }

                email = value;
            }
        }
    }

    public class NameException : Exception
    {
        public NameException(string? message) : base(message)
        { }
    }

    public class EmailException : Exception
    {
        public EmailException(string? message) : base(message)
        { }
    }
}
