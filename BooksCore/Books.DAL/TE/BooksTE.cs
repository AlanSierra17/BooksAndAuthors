using Books.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL.TE
{
    public class BooksTE
    {
        //CRUD Libros

        public List<Book> ReadAll()
        {
            List<Book> BookList = new List<Book>();
            List<Author> authorList = new List<Author>();

            using (var context = new BooksAndAuthorsContext())
            {
                try
                {
                    BookList = context.Books.ToList();
                    authorList = context.Authors.ToList();
                    foreach (Book Book in BookList)
                    {
                        context.Entry(Book).Reference(r => r.EditorialNavigation).Load();
                        context.Entry(Book).Reference(r => r.AuthorNavigation).Load();
                        
                        foreach (Author Author in authorList)
                        {
                            context.Entry(Author).Reference(r => r.NationalityNavigation).Load();
                        }

                    }

                    return BookList;

                }catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }
                
            }

        }

        public Book ReadOne(int IdBook)
        {
            Book Book = new Book();
            Author Author = new Author();


            using (var context = new BooksAndAuthorsContext())
                try
                {
                    {
                        Book = context.Books.Where(b => b.IdBooks == IdBook).FirstOrDefault();
                        Author = context.Authors.FirstOrDefault();

                        if (Book != null)
                        {
                            context.Entry(Book).Reference(r => r.EditorialNavigation).Load();
                            context.Entry(Book).Reference(r => r.AuthorNavigation).Load();
                            
                            context.Entry(Author).Reference(r => r.NationalityNavigation).Load();
                            
                        }

                    }

                    return Book;

                }catch(Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }

         
        }


        public void CreateBook(Book BookToCreate)
        {
            using (var context = new BooksAndAuthorsContext())
                try
                {
                    {
                        context.Books.Add(BookToCreate);
                        context.SaveChanges();
                    }
                }catch (Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }
            

        }


        public void EditBook(Book BookToEdit)
        {
            using (var context = new BooksAndAuthorsContext())
                try
                {
                    {
                        Book BookCtx = context.Books.Where(b => b.IdBooks == BookToEdit.IdBooks).FirstOrDefault();

                        BookCtx.BookName = BookToEdit.BookName;
                        BookCtx.YearOfPublication = BookToEdit.YearOfPublication;
                        BookCtx.Editorial = BookToEdit.Editorial;
                        BookCtx.Author = BookToEdit.Author;

                        context.SaveChanges();

                    }
                }catch(Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }
            
        }

     
        public void DeleteBook(int id)
        {
            using (var context = new BooksAndAuthorsContext())
                try
                {
                    {
                        Book res = new Book();
                        res = context.Books.Where(b => b.IdBooks == id).FirstOrDefault();
                        context.Remove(res);
                        context.SaveChanges();

                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Se ha presentado el siguiente error: " + ex.Message);
                }
            
        }

    }
}
