public class Book {
    public string Title;
    public string Author;
    public int Year;
    public int Pages;
    public bool IsAvailable;
    public double Rating;

    public Book(string title, string author, int year, int pages) {
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;
        IsAvailable = true;
        Rating = 0;
    }

    public void RateBook(double newRating) {
        if (newRating < 0 || newRating > 10) {
            return;
        }

        Rating = newRating;
    }
}