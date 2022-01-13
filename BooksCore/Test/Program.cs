// See https://aka.ms/new-console-template for more information

using Books.DAL.Models;

Books.DAL.TE.BooksTE TBooks = new Books.DAL.TE.BooksTE();

Book book = new Book()
{
    IdBooks = 1,
    BookName = "El leon la bruja y el ropero editado",
    YearOfPublication = 1950,
    Editorial = 1,
    Author = 1
};

//TBooks.CreateBook(book);


TBooks.EditBook(book);

Console.ReadLine();


