namespace OOP.Intro.Homework.Solution.ExerciseOne
{
    public class Book
    {
        // Fields
        private string title;
        private string author;
        private int year;

        // Constructor
        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        // Getters and setters for the fields
        public string GetAuthor()
        {
            return this.author;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public int GetYear()
        {
            return this.year;
        }

        public void SetAuthor(string newAuthor)
        {
            this.author = newAuthor;
        }

        public void SetTitle(string newTitle)
        {
            this.title = newTitle;
        }

        public void SetYear(int newYear)
        {
            this.year = newYear;
        }
    }
}
