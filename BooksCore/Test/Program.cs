// See https://aka.ms/new-console-template for more information

using Books.DAL.Models;

Books.DAL.TE.BooksTE TBooks = new Books.DAL.TE.BooksTE();

Book book = new Book()
{
    BookName = "El principe Caspian",
    YearOfPublication = 1952,
    Editorial = 1,
    Author = 1
};

TBooks.CreateBook(book);


//TBooks.EditBook(book);

//Console.ReadLine();


