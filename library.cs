public class Book {
    public string Title;
    public string Author;
    public int Year;
    public int Pages;
    public bool IsAvailable;

    public Book(string title, string author, int year, int pages) {
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;
        IsAvailable = false;
    }
}