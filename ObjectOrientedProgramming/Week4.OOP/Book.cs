namespace Week4.OOP
{
    public class Book
    {
        public string title;
        public int year;
        public string genre;
        public Author author;

        public Book(string title, int year, string genre, Author author)
        {
            this.title = title;
            this.year = year;
            this.genre = genre;
            this.author = author;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Book: title = {title}, year = {year}, genre = {genre} and Author is {author.firstName} {author.middleName} {author.lastName}.");
        }
    }
}


// Exercise 1:
// Author -> firstName, lastName, middleName -> constructor
// Book -> title, year, genre, author: Author -> constructor

// GetTitle() -> title
// PrintInfo() - afiseaza la consola "Book: title = <TITLE>, year = <YEAR>, genre = <GENRE> and Author is <FIRSTNAME> <MIDDLENAME> <LASTNAME>."