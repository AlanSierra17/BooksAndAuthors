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

        public List<Book> ReadAll()
        {
            List<Book> res = new List<Book>();

            using (var context = new BooksAndAuthorsContext())
            {
                try
                {
                    res = context.Books.ToList();
                    foreach (Book Book in res)
                    {
                        context.Entry(Book).Reference(r => r.EditorialNavigation).Load();
                        context.Entry(Book).Reference(r => r.AuthorNavigation).Load();

                    }

                    return res;

                }catch (Exception ex)
                {
                    throw new Exception("Se ha oresentado el siguiente error: " + ex.Message);
                }
                
            }

        }

        public Book ReadOne(int id)
        {
            Book res = new Book();

            using (var context = new BooksAndAuthorsContext())
                try
                {
                    {
                        res = context.Books.Where(p => p.IdBooks == id).FirstOrDefault();

                        if (res != null)
                        {
                            context.Entry(res).Reference(r => r.EditorialNavigation).Load();
                            context.Entry(res).Reference(r => r.AuthorNavigation).Load();
                        }

                    }

                    return res;

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
                        Book BookCtx = context.Books.Where(p => p.IdBooks == BookToEdit.IdBooks).FirstOrDefault();

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
                        res = context.Books.Where(p => p.IdBooks == id).FirstOrDefault();
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
