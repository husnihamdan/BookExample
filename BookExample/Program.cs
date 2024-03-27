
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("My Books");
List<Books> book = new List<Books>();

Books book1 = new Books("Mark Twain", "Adventures of Tom Sawyer", 200);
Books book2 = new Books("Lewis Carrol", "Alice in Wonderland", 276);
Books book3 = new Books("Coleridge", "Ancient Mariner", 554);

book.Add(book1);
book.Add(book2);
book.Add(book3);
Console.ForegroundColor = ConsoleColor.Green;
foreach (var Books in book)
{
    Console.WriteLine(Books.Author + " , " + Books.Name + " , " + Books.Pages+" Pages");
}
Console.ReadLine();



class Books
{
    public Books(string author, string name, int pages)
    {
        Author = author;
        Name = name;
        Pages = pages;
    }

    public string Author { get; set; }
    public string Name { get; set; }
    public int Pages { get; set; }
}